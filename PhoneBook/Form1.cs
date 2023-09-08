
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public LoginForm loginForm;
        DataTable contacts = new DataTable("Contacts");
        bool editing = false;
        string currentUserRole;

        public Form1(string userRole)
        {
            InitializeComponent();
            currentUserRole = userRole;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            this.Load += new EventHandler(Form1_DataLoad);


            //currentUserLogin = loginForm.CurrentUserLogin;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Открываем файл для записи
            using (StreamWriter writer = new StreamWriter("contacts.txt")){
                foreach (DataRow row in contacts.Rows){
                    // Записываем каждую строку в формате: Фамилия|Имя|Отчество|НомерТелефона
                    writer.WriteLine($"{row["Фамилия"]}|{row["Имя"]}|{row["Отчество"]}|{row["Номер телефона"]}");
                }
            }
            Application.Exit();
            System.Environment.Exit(0);
        }

        private void Form1_DataLoad(object sender, EventArgs e)
        {
            // Пытаемся загрузить данные из текстового файла
            if (File.Exists("contacts.txt"))
            {
                contacts.Clear(); // Очищаем существующие данные

                // Открываем файл для чтения
                using (StreamReader reader = new StreamReader("contacts.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Разделяем строку на части по символу "|"
                        string[] parts = line.Split('|');
                        if (parts.Length == 4)
                        {
                            // Добавляем строку в таблицу контактов
                            contacts.Rows.Add(parts[0], parts[1], parts[2], parts[3]);
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void contactsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Загружаем данные контакта для редактирования по двойному клику
            int rowIndex = contactsGridView.CurrentCell.RowIndex;
            SurnameBox.Text = contacts.Rows[rowIndex].ItemArray[0].ToString();
            NameBox.Text = contacts.Rows[rowIndex].ItemArray[1].ToString();
            FatherBox.Text = contacts.Rows[rowIndex].ItemArray[2].ToString();
            NumberBox.Text = contacts.Rows[rowIndex].ItemArray[3].ToString();
            editing = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            // Добавляем столбцы в таблицу контактов
            contacts.Columns.Add("Фамилия");
            contacts.Columns.Add("Имя");
            contacts.Columns.Add("Отчество");
            contacts.Columns.Add("Номер телефона");

            // Устанавливаем источник данных для DataGridView
            contactsGridView.DataSource = contacts;

            if (currentUserRole == "Оператор")
            {
                New.Visible = false; // Замените NewButton на имя фактической кнопки
                Save.Visible = false; // Замените AddButton на имя фактической кнопки
                Change.Visible = false; // Замените ChangeButton на имя фактической кнопки
                Delete.Visible = false; // Замените DeleteButton на имя фактической кнопки
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            // Очищаем текстовые поля для ввода
            SurnameBox.Text = "";
            NameBox.Text = "";
            FatherBox.Text = "";
            NumberBox.Text = "";
        }

        private void Load_Click(object sender, EventArgs e)
        {
            // Загружаем данные контакта для редактирования
            int rowIndex = contactsGridView.CurrentCell.RowIndex;
            SurnameBox.Text = contacts.Rows[rowIndex].ItemArray[0].ToString();
            NameBox.Text = contacts.Rows[rowIndex].ItemArray[1].ToString();
            FatherBox.Text = contacts.Rows[rowIndex].ItemArray[2].ToString();
            NumberBox.Text = contacts.Rows[rowIndex].ItemArray[3].ToString();
            editing = true;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SurnameBox.Text) ||
                string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(FatherBox.Text) ||
                string.IsNullOrWhiteSpace(NumberBox.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прекратить выполнение метода, чтобы не добавлять пустую запись
            }
            // Сохраняем данные контакта
            if (editing)
            {
                int rowIndex = contactsGridView.CurrentCell.RowIndex;
                contacts.Rows[rowIndex]["Фамилия"] = SurnameBox.Text;
                contacts.Rows[rowIndex]["Имя"] = NameBox.Text;
                contacts.Rows[rowIndex]["Отчество"] = FatherBox.Text;
                contacts.Rows[rowIndex]["Номер Телефона"] = NumberBox.Text;
            }
            else
            {
                contacts.Rows.Add(SurnameBox.Text, NameBox.Text, FatherBox.Text, NumberBox.Text);
            }

            // Очищаем текстовые поля и сбрасываем режим редактирования
            SurnameBox.Text = "";
            NameBox.Text = "";
            FatherBox.Text = "";
            NumberBox.Text = "";
            editing = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Удаляем выбранный контакт
            try
            {
                int rowIndex = contactsGridView.CurrentCell.RowIndex;
                contacts.Rows[rowIndex].Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Недопустимая строка");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
