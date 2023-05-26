using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Service_station_software.Controll
{
    public class MasterController
    {
        private readonly string connectionString;

        public MasterController(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void AddMaster(Master master)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Masters (FirstName, LastName, PhoneNumber, Level) VALUES (@FirstName, @LastName, @PhoneNumber, @Level)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", master.FirstName);
                command.Parameters.AddWithValue("@LastName", master.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", master.PhoneNumber);
                command.Parameters.AddWithValue("@Level", master.Level);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public List<Master> GetAllMasters()
        {
            var masters = new List<Master>();

            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Masters";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var master = new Master
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Level = reader["Level"].ToString()
                        };

                        masters.Add(master);
                    }
                }
            }

            return masters;
        }
    }
}
