using Service_station_software.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_station_software.Controll
{
    public class OrderController
    {
        private readonly string connectionString;

        public OrderController(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void AddOrder(Order order)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Orders (Date, ClientId, CarId, MasterId, ServiceName, ServiceDescription, ServicePrice, PartName, PartYear, PartPrice) " +
                    "VALUES (@Date, @ClientId, @CarId, @MasterId, @ServiceName, @ServiceDescription, @ServicePrice, @PartName, @PartYear, @PartPrice)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Date", order.Date);
                command.Parameters.AddWithValue("@ClientId", order.Client.Id);
                command.Parameters.AddWithValue("@CarId", order.Car); 
                command.Parameters.AddWithValue("@MasterId", order.Master.Id);
                command.Parameters.AddWithValue("@ServiceName", order.Service.Name);
                command.Parameters.AddWithValue("@ServiceDescription", order.Service.Description);
                command.Parameters.AddWithValue("@ServicePrice", order.Service.Price);
                command.Parameters.AddWithValue("@PartName", order.Part.Name);
                command.Parameters.AddWithValue("@PartYear", order.Part.Year);
                command.Parameters.AddWithValue("@PartPrice", order.Part.Price);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public List<Order> GetAllOrders()
        {
            var orders = new List<Order>();

            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Orders";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var order = new Order
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Date = Convert.ToDateTime(reader["Date"]),
                            Client = new Client { Id = Convert.ToInt32(reader["ClientId"]) },
                            Car = new Car
                            {
                                Name = reader["CarName"].ToString(),
                                Year = Convert.ToInt32(reader["CarYear"])
                            },
                            Master = new Master { Id = Convert.ToInt32(reader["MasterId"]) },
                            Service = new Service
                            {
                                Name = reader["ServiceName"].ToString(),
                                Description = reader["ServiceDescription"].ToString(),
                                Price = Convert.ToDecimal(reader["ServicePrice"])
                            },
                            Part = new Part
                            {
                                Name = reader["PartName"].ToString(),
                                Year = Convert.ToInt32(reader["PartYear"]),
                                Price = Convert.ToDecimal(reader["PartPrice"])
                            }
                        };

                        orders.Add(order);
                    }
                }
            }

            return orders;
        }
    }
}
