﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CareerCloud.ADODataAccessLayer
{
    public class SecurityLoginsRoleRepository : IDataRepository<SecurityLoginsRolePoco>
    {
        private string _connStr;
        public SecurityLoginsRoleRepository()
        {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            _connStr = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
        }
        public void Add(params SecurityLoginsRolePoco[] items)
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                foreach (SecurityLoginsRolePoco poco in items)
                {
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = connection;
                    comm.CommandText = @"INSERT INTO [dbo].[Security_Logins_Roles]
                                                   ([Id]
                                                   ,[Login]
                                                   ,[Role])
                                             VALUES
                                                   (@Id
                                                   ,@Login
                                                   ,@Role)";
                    comm.Parameters.AddWithValue("@Id", poco.Id);
                    comm.Parameters.AddWithValue("@Login",poco.Login);
                    comm.Parameters.AddWithValue("@Role", poco.Role);                                       
                    connection.Open();
                    int rowEffected = comm.ExecuteNonQuery();
                    connection.Close();

                }
            
        }
    }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityLoginsRolePoco> GetAll(params Expression<Func<SecurityLoginsRolePoco, object>>[] navigationProperties)
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = connection;
                comm.CommandText = @"SELECT [Id]
                                              ,[Login]
                                              ,[Role]
                                              ,[Time_Stamp]
                                          FROM [dbo].[Security_Logins_Roles]";
                connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                SecurityLoginsRolePoco[] pocos = new SecurityLoginsRolePoco[500];
                int index = 0;
                while (reader.Read())
                {
                    SecurityLoginsRolePoco poco = new SecurityLoginsRolePoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Login = reader.GetGuid(1);
                    poco.Role = reader.GetGuid(2);
                    poco.TimeStamp =reader.IsDBNull(3)?null:(byte[])reader[3];
                    pocos[index] = poco;
                    index++;
                }
                connection.Close();
                return pocos.Where(a => a != null).ToList();
            }
        }

        public IList<SecurityLoginsRolePoco> GetList(Expression<Func<SecurityLoginsRolePoco, bool>> where, params Expression<Func<SecurityLoginsRolePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginsRolePoco GetSingle(Expression<Func<SecurityLoginsRolePoco, bool>> where, params Expression<Func<SecurityLoginsRolePoco, object>>[] navigationProperties)
        {
            IQueryable<SecurityLoginsRolePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params SecurityLoginsRolePoco[] items)
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = connection;
                foreach (SecurityLoginsRolePoco poco in items)
                {
                    comm.CommandText = @"Delete Security_Logins_Roles where Id=@Id";
                    comm.Parameters.AddWithValue("@Id", poco.Id);
                    connection.Open();
                    comm.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void Update(params SecurityLoginsRolePoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                foreach (var poco in items)
                {
                    comm.CommandText = @"UPDATE [dbo].[Security_Logins_Roles]
                                                           SET [Id] = @Id
                                                              ,[Login] = @Login
                                                              ,[Role] = @Role                                                 
                                                         WHERE [Id]=@Id";
                    comm.Parameters.AddWithValue("@Id", poco.Id);
                    comm.Parameters.AddWithValue("@Login", poco.Login);
                    comm.Parameters.AddWithValue("@Role", poco.Role);
                                                        
                    conn.Open();
                    int count = comm.ExecuteNonQuery();
                    if (count != 1)
                    {
                        throw new Exception();
                    }
                    conn.Close();
                }

            }
        }
    }
}
