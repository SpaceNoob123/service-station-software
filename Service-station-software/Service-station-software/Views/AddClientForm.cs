using Service_station_software.Controll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_station_software.Views
{
    public partial class AddClientForm : Form
    {
        private Label label1;
        private TextBox firstNameTextBox;
        private Label label2;
        private TextBox lastNameTextBox;
        private Label label3;
        private TextBox phoneNumberTextBox;
        private Button button1;
        private readonly ClientController clientController;

        public AddClientForm(ClientController controller)
        {
            InitializeComponent();
            clientController = controller;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var client = new Client
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text
            };

            clientController.AddClient(client);
            MessageBox.Show("Клиент успешно добавлен в базу данных.");
            Close();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(39, 35);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(39, 74);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер телефона";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(39, 113);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddClientForm
            // 
            this.ClientSize = new System.Drawing.Size(181, 176);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
