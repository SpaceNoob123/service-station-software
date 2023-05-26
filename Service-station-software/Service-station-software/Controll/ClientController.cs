using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Service_station_software.Controll
{
    public class ClientController
    {
        private readonly string connectionString;

        public ClientController(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddClient(Client client)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Clients (FirstName, LastName, PhoneNumber) VALUES (@FirstName, @LastName, @PhoneNumber)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", client.FirstName);
                command.Parameters.AddWithValue("@LastName", client.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", client.PhoneNumber);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Client> GetAllClients()
        {
            var clients = new List<Client>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = "SELECT * FROM Clients";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var client = new Client
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Cars = GetCarsByClientId(Convert.ToInt32(reader["Id"]))
                            };

                            clients.Add(client);
                        }
                    }
                }
            }

            return clients;
        }

        private void AddCar(Car car, int clientId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = "INSERT INTO Cars (ClientId, Name, Year) VALUES (@ClientId, @Name, @Year); SELECT SCOPE_IDENTITY();";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientId", clientId);
                    command.Parameters.AddWithValue("@Name", car.Name);
                    command.Parameters.AddWithValue("@Year", car.Year);

                    car.Id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private List<Car> GetCarsByClientId(int clientId)
        {
            var cars = new List<Car>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = "SELECT * FROM Cars WHERE ClientId = @ClientId";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientId", clientId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var car = new Car
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                ClientId = Convert.ToInt32(reader["ClientId"]),
                                Name = reader["Name"].ToString(),
                                Year = Convert.ToInt32(reader["Year"])
                            };

                            cars.Add(car);
                        }
                    }
                }
            }

            return cars;
        }
    }
}
