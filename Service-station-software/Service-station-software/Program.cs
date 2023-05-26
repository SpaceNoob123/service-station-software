using Service_station_software.Controll;
using Service_station_software.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_station_software
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;" +
                    "Database=CarServiceDB;" +
                    "Trusted_Connection=True;" +
                    "TrustServerCertificate=True;";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Создание экземпляров контроллеров
            ClientController clientController = new ClientController(connectionString);
            MasterController masterController = new MasterController(connectionString);
            OrderController orderController = new OrderController(connectionString);

            // Создание экземпляра формы MainForm и запуск приложения
            MainForm mainForm = new MainForm(clientController, masterController, orderController);
            Application.Run(mainForm);
        }
    }
}
