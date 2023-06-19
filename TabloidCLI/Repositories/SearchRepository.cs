using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using TabloidCLI.Models;
using System.Threading.Tasks;
using TabloidCLI.Repositories;

namespace TabloidCLI
{
    public class SearchRepository : DatabaseConnector, IRepository<Search>
    {
        public SearchRepository(string connectionString) : base(connectionString) { }

        public List<Search> GetAll()
        {

            using (SqlConnection conn = Connection)
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT id",
                                        
                }
            }
        }