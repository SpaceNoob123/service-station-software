using Service_station_software.Controll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_station_software.Views
{
    public partial class MainForm : Form
    {

        private Button AddClientForm;
        private Button AddMasterForm;
        private Button AddOrderForm;
        private ListBox clientListBox;
        private ListBox masterListBox;
        private ListBox orderListBox;


        private readonly ClientController clientController;
        private readonly MasterController masterController;
        private readonly OrderController orderController;

        public MainForm(ClientController clientCtrl, MasterController masterCtrl, OrderController orderCtrl)
        {
            InitializeComponent();
            clientController = clientCtrl;
            masterController = masterCtrl;
            orderController = orderCtrl;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadMasters();
            LoadOrders();
        }

        private void LoadClients()
        {
            // Логика загрузки клиентов из базы данных
            var clients = clientController.GetAllClients();

            // Очищаем список клиентов и добавляем загруженные клиенты
            clientListBox.Items.Clear();
            clientListBox.Items.AddRange(clients.ToArray());
        }

        private void LoadMasters()
        {
            // Логика загрузки мастеров из базы данных
            var masters = masterController.GetAllMasters();

            // Очищаем список мастеров и добавляем загруженных мастеров
            masterListBox.Items.Clear();
            masterListBox.Items.AddRange(masters.ToArray());
        }

        private void LoadOrders()
        {
            // Логика загрузки заказов из базы данных
            var orders = orderController.GetAllOrders();

            // Очищаем список заказов и добавляем загруженные заказы
            orderListBox.Items.Clear();
            orderListBox.Items.AddRange(orders.ToArray());
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            // Открыть форму для добавления клиента
            var addClientForm = new AddClientForm(clientController);
            addClientForm.ShowDialog();

            // После закрытия формы обновляем список клиентов
            LoadClients();
        }

        private void addMasterButton_Click(object sender, EventArgs e)
        {
            // Открыть форму для добавления мастера
            var addMasterForm = new AddMasterForm(masterController);
            addMasterForm.ShowDialog();

            // После закрытия формы обновляем список мастеров
            LoadMasters();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            // Открыть форму для добавления заказа
            var addOrderForm = new AddOrderForm(clientController, masterController, orderController);
            addOrderForm.ShowDialog();

            // После закрытия формы обновляем список заказов
            LoadOrders();
        }

        private void InitializeComponent()
        {
            this.AddClientForm = new System.Windows.Forms.Button();
            this.AddMasterForm = new System.Windows.Forms.Button();
            this.AddOrderForm = new System.Windows.Forms.Button();
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.masterListBox = new System.Windows.Forms.ListBox();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddClientForm
            // 
            this.AddClientForm.Location = new System.Drawing.Point(47, 28);
            this.AddClientForm.Name = "AddClientForm";
            this.AddClientForm.Size = new System.Drawing.Size(75, 23);
            this.AddClientForm.TabIndex = 0;
            this.AddClientForm.Text = "AddClient";
            this.AddClientForm.UseVisualStyleBackColor = true;
            this.AddClientForm.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // AddMasterForm
            // 
            this.AddMasterForm.Location = new System.Drawing.Point(252, 28);
            this.AddMasterForm.Name = "AddMasterForm";
            this.AddMasterForm.Size = new System.Drawing.Size(75, 23);
            this.AddMasterForm.TabIndex = 1;
            this.AddMasterForm.Text = "AddMaster";
            this.AddMasterForm.UseVisualStyleBackColor = true;
            this.AddMasterForm.Click += new System.EventHandler(this.addMasterButton_Click);
            // 
            // AddOrderForm
            // 
            this.AddOrderForm.Location = new System.Drawing.Point(470, 28);
            this.AddOrderForm.Name = "AddOrderForm";
            this.AddOrderForm.Size = new System.Drawing.Size(75, 23);
            this.AddOrderForm.TabIndex = 2;
            this.AddOrderForm.Text = "AddOrder";
            this.AddOrderForm.UseVisualStyleBackColor = true;
            this.AddOrderForm.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // clientListBox
            // 
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.Location = new System.Drawing.Point(12, 95);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.Size = new System.Drawing.Size(191, 134);
            this.clientListBox.TabIndex = 3;
            // 
            // masterListBox
            // 
            this.masterListBox.FormattingEnabled = true;
            this.masterListBox.Location = new System.Drawing.Point(209, 95);
            this.masterListBox.Name = "masterListBox";
            this.masterListBox.Size = new System.Drawing.Size(186, 134);
            this.masterListBox.TabIndex = 4;
            // 
            // orderListBox
            // 
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.Location = new System.Drawing.Point(401, 95);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(234, 134);
            this.orderListBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(658, 459);
            this.Controls.Add(this.orderListBox);
            this.Controls.Add(this.masterListBox);
            this.Controls.Add(this.clientListBox);
            this.Controls.Add(this.AddOrderForm);
            this.Controls.Add(this.AddMasterForm);
            this.Controls.Add(this.AddClientForm);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }
    }
}
