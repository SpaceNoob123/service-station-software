using Service_station_software.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_station_software
{
    public class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertClient(Client client)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Логика вставки клиента в таблицу Clients
            }
        }

        public void InsertMaster(Master master)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Логика вставки мастера в таблицу Masters
            }
        }

        public void InsertOrder(Order order)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Логика вставки заказа в таблицу Orders
            }
        }
    }
}
