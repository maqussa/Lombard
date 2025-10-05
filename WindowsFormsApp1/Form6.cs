
using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        private string filePath = PathCombine("clients.txt");

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("col1", "ФИО");
            dataGridView1.Columns.Add("col2", "Паспорт");
            dataGridView1.Columns.Add("col3", "Телефон");

            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 3)
                        dataGridView1.Rows.Add(parts[0], parts[1], parts[2]);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string v0 = row.Cells[0].Value?.ToString() ?? "";
                        string v1 = row.Cells[1].Value?.ToString() ?? "";
                        string v2 = row.Cells[2].Value?.ToString() ?? "";
                        string line = string.Join(";", v0, v1, v2);
                        sw.WriteLine(line);
                    }
                }
            }
            MessageBox.Show("Изменения сохранены.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления.");
                return;
            }

            if (MessageBox.Show("Удалить выбранные строки?", "Подтверждение", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                    dataGridView1.Rows.Remove(row);
            }
        }

        private static string PathCombine(string filename)
        {
            return System.IO.Path.Combine(Application.StartupPath, filename);
        }
    }
}
