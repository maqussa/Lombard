using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private string path = Path.Combine(Application.StartupPath, "data", "items.txt");

        public Form3()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text) ||
                string.IsNullOrWhiteSpace(txtCondition.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка");
                return;
            }

            Directory.CreateDirectory(Path.Combine(Application.StartupPath, "data"));

            string itemData = $"{txtName.Text};{txtCategory.Text};{txtCondition.Text}";
            File.AppendAllText(path, itemData + Environment.NewLine);

            MessageBox.Show("Предмет сохранён!", "Успех");

            txtName.Clear();
            txtCategory.Clear();
            txtCondition.Clear();
        }
    }
}
