﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabloidCLI.Repositories
{
    internal class JournalRepository
    {

<<<<<<< HEAD
=======
        public List<Journal> GetAll()
        {
            //return a list of all journals
            //list should include title, creation date, and text content
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT Id, Title, CreateDateTime, Content
                                        FROM Journal";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Journal> journals = new List<Journal>();
                        while (reader.Read())
                        {
                            int idColumnPosition = reader.GetOrdinal("id");
                            int idValue = reader.GetInt32(idColumnPosition);

                            int titleColumnPosition = reader.GetOrdinal("Title");
                            string titleValue = reader.GetString(titleColumnPosition);

                            int dateTimePosition = reader.GetOrdinal("CreateDateTime");
                            DateTime dateTimeValue = reader.GetDateTime(dateTimePosition);

                            int contentPosition = reader.GetOrdinal("Content");
                            string contentValue = reader.GetString(contentPosition);

                            Journal journal = new Journal
                            {
                                Id = idValue,
                                Title = titleValue,
                                CreateDateTime = dateTimeValue,
                                Content = contentValue
                            };

                            journals.Add(journal);


                        }
                        return journals;
                    }
                    
                }
            }
        }

        public Journal Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Journal> GetByAuthor(int authorId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Journal journal)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT into Journal (Title, Content, CreateDateTime)
                                        OUTPUT INSERTED.Id
                                        VALUES(@title, @content, @createDateTime)"; 
                        
                    cmd.Parameters.AddWithValue("@title", journal.Title);
                    cmd.Parameters.AddWithValue("@content", journal.Content);
                    cmd.Parameters.AddWithValue("@createDateTime", journal.CreateDateTime);
                    int id = (int)cmd.ExecuteScalar();

                    journal.Id = id;
                }
            }
        }

        public void Update(Journal journal)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Journal WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
>>>>>>> a9c5cf0bb14f16487e07a484501019ee338f889b
    }
}
