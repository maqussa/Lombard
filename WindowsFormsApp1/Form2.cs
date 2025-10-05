using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private string path = Path.Combine(Application.StartupPath, "data", "clients.txt");

        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка");
                return;
            }

            // Создание строки для сохранения
            string clientData = $"{txtName.Text};{txtPhone.Text};{txtAddress.Text}";

            // Создание папки data, если не существует
            Directory.CreateDirectory(Path.Combine(Application.StartupPath, "data"));

            // Добавление новой строки в файл
            File.AppendAllText(path, clientData + Environment.NewLine);

            MessageBox.Show("Клиент сохранён!", "Успех");

            // Очистка полей
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }
    }
}
