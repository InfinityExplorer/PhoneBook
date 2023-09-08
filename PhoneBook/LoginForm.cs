using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhoneBook
{
    public partial class LoginForm : Form
    {
        public Form1 mainForm;
        private AdminForm adminForm;
        public string CurrentUserRole { get; private set; } // поле для хранения уровня доступа

        public LoginForm()
        {
            InitializeComponent();
            mainForm = new Form1(CurrentUserRole);
            adminForm = new AdminForm(); 
        }

        private void Entrance_Click(object sender, EventArgs e)
        {
            string Login = LogBox.Text;
            string Pass = PasBox.Text;

            // Проверьте введенные данные (например, сравните с жестко закодированным логином и паролем)
            if (IsValidUser(Login, Pass) || (Login == "Ivan" && Pass == "1234"))
            {
               
                this.Hide();
                mainForm = new Form1(CurrentUserRole); // Создаем экземпляр Form1 и передаем текущий экземпляр LoginForm
                mainForm.Show();

            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void PasBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAdminButtonVisibility(); 
        }

        private void LogBox_TextChanged(object sender, EventArgs e)
        {
            UpdateAdminButtonVisibility();
        }
        private void UpdateAdminButtonVisibility()
        {
            string Login = LogBox.Text; 
            string Pass = PasBox.Text;
            string[] lines = File.ReadAllLines("users.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3 && parts[0] == Login && parts[1] == Pass)
                {
                    CurrentUserRole = parts[2];
                }
            }
            if ((Login == "Ivan" && Pass == "1234") || (CurrentUserRole=="Менеджер"))
            {
                btn_admin.Visible = true;
            }
            else
            {
                btn_admin.Visible = false;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UpdateAdminButtonVisibility();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm.Show();
        }
        private void LoginForm_Closing(object sender, FormClosingEventArgs e)
        { 
            Application.Exit();
            System.Environment.Exit(0);
        }
        private bool IsValidUser(string login, string password)
        {
            string[] lines = File.ReadAllLines("users.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3 && parts[0] == login && parts[1] == password )
                {
                    CurrentUserRole = parts[2];
                    return true; // Пользователь найден
                }
            }

            return false; // Пользователь не найден
        }
    }
}
