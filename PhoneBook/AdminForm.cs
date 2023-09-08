using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            string newLogin = box_userLog.Text;
            string newPassword = box_userPass.Text;
            string selectedRole = listBox_lvlAccess.SelectedItem?.ToString(); // Получаем выбранный элемент из listBox

            if (!string.IsNullOrWhiteSpace(newLogin) && !string.IsNullOrWhiteSpace(newPassword) && selectedRole != null)
            {
                if (IsValidLogin(newLogin))
                {
                    SaveUserToFile(newLogin, newPassword, selectedRole);
                    MessageBox.Show("Новый пользователь добавлен.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    box_userLog.Text = "";
                    box_userPass.Text = "";
                }
                else
                {
                    MessageBox.Show("Логин не должен содержать пробелы или быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AdminForm_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            System.Environment.Exit(0);
        }

        private void btn_userDelete_Click(object sender, EventArgs e)
        {
            string loginToDelete = box_userLog.Text;

            if (!string.IsNullOrWhiteSpace(loginToDelete))
            {
                string filePath = "users.txt";
                string[] lines = File.ReadAllLines(filePath);

                List<string> updatedLines = new List<string>();

                foreach (string line in lines)        // Проходим по каждой строке из файла users.txt
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3 && parts[0] != loginToDelete)
                    {
                        updatedLines.Add(line);
                    }
                }

                File.WriteAllLines(filePath, updatedLines);// Перезаписываем файл users.txt обновленными строками

                MessageBox.Show("Пользователь удален.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                box_userLog.Text = "";
                box_userPass.Text = "";
            }
            else
            {
                MessageBox.Show("Введен не правильный логин, такого пользователся нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveUserToFile(string login, string password, string role)
        {
            string filePath = "users.txt";

            if (!File.Exists(filePath))
            {
                // Создаем файл, если он не существует
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    
                }
            }

            using (StreamWriter writer = new StreamWriter(filePath, true)) // true для добавления в конец файла
            {
                writer.WriteLine($"{login}|{password}|{role}");
            }
        }
        private bool IsValidLogin(string login)
        {
            return !string.IsNullOrWhiteSpace(login) && !login.Contains(" ");
        }
    }
}
