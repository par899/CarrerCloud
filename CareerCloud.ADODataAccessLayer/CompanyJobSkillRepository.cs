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
    public class CompanyJobSkillRepository : IDataRepository<CompanyJobSkillPoco>
    {
        private string _connStr;
        public CompanyJobSkillRepository()
            {
                     var config = new ConfigurationBuilder();
                var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
                config.AddJsonFile(path, false);
                    var root = config.Build();
                _connStr = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
            }
        public void Add(params CompanyJobSkillPoco[] items)
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                foreach (CompanyJobSkillPoco poco in items)
                {
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = connection;
                    comm.CommandText = @"INSERT INTO [dbo].[Company_Job_Skills]
                                               ([Id]
                                               ,[Job]
                                               ,[Skill]
                                               ,[Skill_Level]
                                               ,[Importance])
                                         VALUES
                                               (@Id
                                               ,@Job
                                               ,@Skill
                                               ,@Skill_Level
                                               ,@Importance)";
                    comm.Parameters.AddWithValue("@Id", poco.Id);
                    comm.Parameters.AddWithValue("@Job", poco.Job);
                    comm.Parameters.AddWithValue("@Skill", poco.Skill);
                    comm.Parameters.AddWithValue("@Skill_Level", poco.SkillLevel);
                    comm.Parameters.AddWithValue("@Importance", poco.Importance);

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

        public IList<CompanyJobSkillPoco> GetAll(params Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = connection;
                comm.CommandText = @"SELECT [Id]
                                              ,[Job]
                                              ,[Skill]
                                              ,[Skill_Level]
                                              ,[Importance]
                                              ,[Time_Stamp]
                                          FROM [dbo].[Company_Job_Skills]";
                connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                CompanyJobSkillPoco[] pocos = new CompanyJobSkillPoco[6000];
                int index = 0;
                while (reader.Read())
                {
                    CompanyJobSkillPoco poco = new CompanyJobSkillPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Job = reader.GetGuid(1);
                    poco.Skill = reader.GetString(2);
                    poco.SkillLevel = reader.GetString(3);
                    poco.Importance = reader.GetInt32(4);
                    poco.TimeStamp = (byte[])reader[5];
                    pocos[index] = poco;
                    index++;
                }
                connection.Close();
                return pocos.Where(a => a != null).ToList();
            }
        }

        public IList<CompanyJobSkillPoco> GetList(Expression<Func<CompanyJobSkillPoco, bool>> where, params Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobSkillPoco GetSingle(Expression<Func<CompanyJobSkillPoco, bool>> where, params Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobSkillPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyJobSkillPoco[] items)
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = connection;
                foreach (CompanyJobSkillPoco poco in items)
                {
                    comm.CommandText = @"Delete Company_Job_Skills where Id=@Id";
                    comm.Parameters.AddWithValue("@Id", poco.Id);
                    connection.Open();
                    comm.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void Update(params CompanyJobSkillPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                foreach (var poco in items)
                {
                    comm.CommandText = @"UPDATE [dbo].[Company_Job_Skills]
                                                           SET [Id] = @Id
                                                              ,[Job] = @Job
                                                              ,[Skill] = @Skill
                                                              ,[Skill_Level] = @Skill_Level
                                                              ,[Importance] = @Importance
                                                         WHERE [Id]=@Id";
                    comm.Parameters.AddWithValue("@Id", poco.Id);
                    comm.Parameters.AddWithValue("@Job", poco.Job);
                    comm.Parameters.AddWithValue("@Skill", poco.Skill);
                    comm.Parameters.AddWithValue("@Skill_Level", poco.SkillLevel);
                    comm.Parameters.AddWithValue("@Importance", poco.Importance);
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
