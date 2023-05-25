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
            string connectionString = "your_connection_string_here";
            var databaseHelper = new DatabaseHelper(connectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Создание экземпляров контроллеров
            ClientController clientController = new ClientController();
            MasterController masterController = new MasterController();
            OrderController orderController = new OrderController();

            // Создание экземпляра формы MainForm и запуск приложения
            MainForm mainForm = new MainForm(clientController, masterController, orderController);
            Application.Run(mainForm);
        }
    }
}
