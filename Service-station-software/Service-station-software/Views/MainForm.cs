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
            var clients = clientController.GetAllClients();
            clientListBox.Items.Clear();
            clientListBox.Items.AddRange(clients.ToArray());
        }

        private void LoadMasters()
        {
            var masters = masterController.GetAllMasters();
            masterListBox.Items.Clear();
            masterListBox.Items.AddRange(masters.ToArray());
        }

        private void LoadOrders()
        {
            var orders = orderController.GetAllOrders();
            orderListBox.Items.Clear();
            orderListBox.Items.AddRange(orders.ToArray());
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            var addClientForm = new AddClientForm(clientController);
            addClientForm.ShowDialog();
            LoadClients();
        }

        private void addMasterButton_Click(object sender, EventArgs e)
        {
            var addMasterForm = new AddMasterForm(masterController);
            addMasterForm.ShowDialog();
            LoadMasters();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            var addOrderForm = new AddOrderForm(clientController, masterController, orderController);
            addOrderForm.ShowDialog();
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
            this.AddClientForm.Location = new System.Drawing.Point(96, 40);
            this.AddClientForm.Name = "AddClientForm";
            this.AddClientForm.Size = new System.Drawing.Size(75, 23);
            this.AddClientForm.TabIndex = 0;
            this.AddClientForm.Text = "AddClient";
            this.AddClientForm.UseVisualStyleBackColor = true;
            this.AddClientForm.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // AddMasterForm
            // 
            this.AddMasterForm.Location = new System.Drawing.Point(383, 28);
            this.AddMasterForm.Name = "AddMasterForm";
            this.AddMasterForm.Size = new System.Drawing.Size(75, 23);
            this.AddMasterForm.TabIndex = 1;
            this.AddMasterForm.Text = "AddMaster";
            this.AddMasterForm.UseVisualStyleBackColor = true;
            this.AddMasterForm.Click += new System.EventHandler(this.addMasterButton_Click);
            // 
            // AddOrderForm
            // 
            this.AddOrderForm.Location = new System.Drawing.Point(659, 28);
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
            this.clientListBox.Size = new System.Drawing.Size(306, 303);
            this.clientListBox.TabIndex = 3;
            // 
            // masterListBox
            // 
            this.masterListBox.FormattingEnabled = true;
            this.masterListBox.Location = new System.Drawing.Point(324, 95);
            this.masterListBox.Name = "masterListBox";
            this.masterListBox.Size = new System.Drawing.Size(263, 290);
            this.masterListBox.TabIndex = 4;
            // 
            // orderListBox
            // 
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.Location = new System.Drawing.Point(593, 95);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(292, 329);
            this.orderListBox.TabIndex = 5;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(952, 555);
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
