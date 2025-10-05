using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        private string path = Path.Combine(Application.StartupPath, "data", "contracts.txt");

        public Form4()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientName.Text) ||
                string.IsNullOrWhiteSpace(txtItemName.Text) ||
                string.IsNullOrWhiteSpace(txtSum.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка");
                return;
            }

            Directory.CreateDirectory(Path.Combine(Application.StartupPath, "data"));

            string contractData = $"{txtClientName.Text};{txtItemName.Text};{txtSum.Text};{dtpDate.Value.ToShortDateString()}";
            File.AppendAllText(path, contractData + Environment.NewLine);

            MessageBox.Show("Договор сохранён!", "Успех");

            txtClientName.Clear();
            txtItemName.Clear();
            txtSum.Clear();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                lstContracts.Items.Clear();
                foreach (var line in File.ReadAllLines(path))
                    lstContracts.Items.Add(line);
            }
            else
            {
                MessageBox.Show("Файл договоров пуст или отсутствует.");
            }
        }
    }
}
