using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyJobRepository:IDataRepository<CompanyJobPoco>
    {
        private string _connStr;
        public CompanyJobRepository()
        {
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            _connStr = root.GetSection("ConnectionStrings").GetSection("DataConnection").Value;
        }

        public void Add(params CompanyJobPoco[] items)
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                foreach (CompanyJobPoco poco in items)
                {
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = connection;
                    comm.CommandText = @"INSERT INTO [dbo].[Company_Jobs]
                                                       ([Id]
                                                       ,[Company]
                                                       ,[Profile_Created]
                                                       ,[Is_Inactive]
                                                       ,[Is_Company_Hidden])
                                                 VALUES
                                                       (@Id
                                                       ,@Company
                                                       ,@Profile_Created
                                                       ,@Is_Inactive
                                                       ,@Is_Company_Hidden)";
                    comm.Parameters.AddWithValue("@Id", poco.Id);
                    comm.Parameters.AddWithValue("@Company", poco.Company);
                    comm.Parameters.AddWithValue("@Profile_Created", poco.ProfileCreated);
                    comm.Parameters.AddWithValue("@Is_Inactive", poco.IsInactive);
                    comm.Parameters.AddWithValue("@Is_Company_Hidden", poco.IsCompanyHidden);
                   
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

        public IList<CompanyJobPoco> GetAll(params System.Linq.Expressions.Expression<Func<CompanyJobPoco, object>>[] navigationProperties)
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = connection;
                comm.CommandText = @"SELECT [Id]
                                                  ,[Company]
                                                  ,[Profile_Created]
                                                  ,[Is_Inactive]
                                                  ,[Is_Company_Hidden]
                                                  ,[Time_Stamp]
                                              FROM [dbo].[Company_Jobs]";
                connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                CompanyJobPoco[] pocos = new CompanyJobPoco[1500];
                int index = 0;
                while (reader.Read())
                {
                    CompanyJobPoco poco = new CompanyJobPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Company = reader.GetGuid(1);
                    poco.ProfileCreated = reader.GetDateTime(2);
                    poco.IsInactive = reader.GetBoolean(3);
                    poco.IsCompanyHidden = reader.GetBoolean(4);
                    poco.TimeStamp =reader.IsDBNull(5)?(byte[])null:(byte[])reader[5];
                    pocos[index] = poco;
                    index++;
                }
                connection.Close();
                return pocos.Where(a => a != null).ToList();
            }
        }

        public IList<CompanyJobPoco> GetList(System.Linq.Expressions.Expression<Func<CompanyJobPoco, bool>> where, params System.Linq.Expressions.Expression<Func<CompanyJobPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobPoco GetSingle(System.Linq.Expressions.Expression<Func<CompanyJobPoco, bool>> where, params System.Linq.Expressions.Expression<Func<CompanyJobPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyJobPoco[] items)
        {
            using (SqlConnection connection = new SqlConnection(_connStr))
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = connection;
                foreach (CompanyJobPoco poco in items)
                {
                    comm.CommandText = @"DELETE FROM [dbo].[Company_Jobs] WHERE Id=@Id";
                    comm.Parameters.AddWithValue("@Id", poco.Id);
                    connection.Open();
                    comm.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void Update(params CompanyJobPoco[] items)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                foreach (var poco in items)
                {
                    comm.CommandText = @"UPDATE [dbo].[Company_Jobs]
                                               SET [Id] = @Id
                                                  ,[Company] = @Company
                                                  ,[Profile_Created] = @Profile_Created
                                                  ,[Is_Inactive] = @Is_Inactive
                                                  ,[Is_Company_Hidden] = @Is_Company_Hidden
                                                         WHERE [Id]=@Id";
                    comm.Parameters.AddWithValue("@Id", poco.Id);
                    comm.Parameters.AddWithValue("@Company", poco.Company);
                    comm.Parameters.AddWithValue("@Profile_Created", poco.ProfileCreated);
                    comm.Parameters.AddWithValue("@Is_Inactive", poco.IsInactive);
                    comm.Parameters.AddWithValue("@Is_Company_Hidden", poco.IsCompanyHidden);
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
