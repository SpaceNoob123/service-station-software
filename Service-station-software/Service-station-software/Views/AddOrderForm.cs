using Service_station_software.Controll;
using Service_station_software.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_station_software.Views
{
    public partial class AddOrderForm : Form
    {
        private readonly ClientController clientController;
        private readonly MasterController masterController;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private Label label2;
        private ComboBox clientComboBox;
        private Label label3;
        private TextBox carNameTextBox;
        private TextBox carYearTextBox;
        private Label label4;
        private ComboBox masterComboBox;
        private Label label5;
        private TextBox serviceNameTextBox;
        private TextBox serviceDescTextBox;
        private TextBox servicePriceTextBox;
        private Label label6;
        private TextBox partNameTextBox;
        private TextBox partYearTextBox;
        private TextBox partPriceTextBox;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private readonly OrderController orderController;

        public AddOrderForm(ClientController clientCtrl, MasterController masterCtrl, OrderController orderCtrl)
        {
            InitializeComponent();
            clientController = clientCtrl;
            masterController = masterCtrl;
            orderController = orderCtrl;

            // Загрузка клиентов и мастеров в выпадающие списки
            LoadClients();
            LoadMasters();
        }

        private void LoadClients()
        {
            var clients = clientController.GetAllClients();

            clientComboBox.DataSource = clients;
            clientComboBox.DisplayMember = "FullName";
        }

        private void LoadMasters()
        {
            var masters = masterController.GetAllMasters();

            masterComboBox.DataSource = masters;
            masterComboBox.DisplayMember = "FullName";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                Date = dateTimePicker.Value,
                Client = (Client)clientComboBox.SelectedItem,
                Car = new Car { Name = carNameTextBox.Text, Year = int.Parse(carYearTextBox.Text) },
                Master = (Master)masterComboBox.SelectedItem,
                Service = new Service { Name = serviceNameTextBox.Text, Description = serviceDescTextBox.Text, Price = decimal.Parse(servicePriceTextBox.Text) },
                Part = new Part { Name = partNameTextBox.Text, Year = int.Parse(partYearTextBox.Text), Price = decimal.Parse(partPriceTextBox.Text) }
            };

            orderController.AddOrder(order);
            MessageBox.Show("Заказ успешно добавлен в базу данных.");
            Close();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carNameTextBox = new System.Windows.Forms.TextBox();
            this.carYearTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.masterComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.serviceNameTextBox = new System.Windows.Forms.TextBox();
            this.serviceDescTextBox = new System.Windows.Forms.TextBox();
            this.servicePriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.partNameTextBox = new System.Windows.Forms.TextBox();
            this.partYearTextBox = new System.Windows.Forms.TextBox();
            this.partPriceTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заказа";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(230, 74);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Клиент";
            // 
            // clientComboBox
            // 
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(249, 129);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(121, 21);
            this.clientComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Автомобиль";
            // 
            // carNameTextBox
            // 
            this.carNameTextBox.Location = new System.Drawing.Point(270, 173);
            this.carNameTextBox.Name = "carNameTextBox";
            this.carNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.carNameTextBox.TabIndex = 5;
            // 
            // carYearTextBox
            // 
            this.carYearTextBox.Location = new System.Drawing.Point(270, 199);
            this.carYearTextBox.Name = "carYearTextBox";
            this.carYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.carYearTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Мастер";
            // 
            // masterComboBox
            // 
            this.masterComboBox.FormattingEnabled = true;
            this.masterComboBox.Location = new System.Drawing.Point(249, 242);
            this.masterComboBox.Name = "masterComboBox";
            this.masterComboBox.Size = new System.Drawing.Size(121, 21);
            this.masterComboBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Услуга";
            // 
            // serviceNameTextBox
            // 
            this.serviceNameTextBox.Location = new System.Drawing.Point(270, 287);
            this.serviceNameTextBox.Name = "serviceNameTextBox";
            this.serviceNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.serviceNameTextBox.TabIndex = 10;
            // 
            // serviceDescTextBox
            // 
            this.serviceDescTextBox.Location = new System.Drawing.Point(270, 313);
            this.serviceDescTextBox.Name = "serviceDescTextBox";
            this.serviceDescTextBox.Size = new System.Drawing.Size(100, 20);
            this.serviceDescTextBox.TabIndex = 11;
            // 
            // servicePriceTextBox
            // 
            this.servicePriceTextBox.Location = new System.Drawing.Point(270, 339);
            this.servicePriceTextBox.Name = "servicePriceTextBox";
            this.servicePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.servicePriceTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Запчасть";
            // 
            // partNameTextBox
            // 
            this.partNameTextBox.Location = new System.Drawing.Point(270, 387);
            this.partNameTextBox.Name = "partNameTextBox";
            this.partNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.partNameTextBox.TabIndex = 14;
            // 
            // partYearTextBox
            // 
            this.partYearTextBox.Location = new System.Drawing.Point(270, 413);
            this.partYearTextBox.Name = "partYearTextBox";
            this.partYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.partYearTextBox.TabIndex = 15;
            // 
            // partPriceTextBox
            // 
            this.partPriceTextBox.Location = new System.Drawing.Point(270, 439);
            this.partPriceTextBox.Name = "partPriceTextBox";
            this.partPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.partPriceTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Названия автомобиля:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Год выпуска автомобиля:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Названия услуги:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Описания услуги:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Цена услуги:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 390);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Названия запчасти:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(135, 420);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Года выпуска запчасти:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(179, 446);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Цена запчасти:";
            // 
            // AddOrderForm
            // 
            this.ClientSize = new System.Drawing.Size(770, 569);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.partPriceTextBox);
            this.Controls.Add(this.partYearTextBox);
            this.Controls.Add(this.partNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.servicePriceTextBox);
            this.Controls.Add(this.serviceDescTextBox);
            this.Controls.Add(this.serviceNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.masterComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.carYearTextBox);
            this.Controls.Add(this.carNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Name = "AddOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
