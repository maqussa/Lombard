using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        private string filePath = Path.Combine(Application.StartupPath, "data", "contracts.txt");
        private DataTable table = new DataTable();

        public Form8()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            table.Columns.Clear();
            table.Columns.Add("Клиент");
            table.Columns.Add("Предмет");
            table.Columns.Add("Сумма");
            table.Columns.Add("Дата");

            table.Rows.Clear();

            if (File.Exists(filePath))
            {
                foreach (var line in File.ReadAllLines(filePath))
                {
                    var parts = line.Split(';');
                    if (parts.Length == 4)
                        table.Rows.Add(parts[0], parts[1], parts[2], parts[3]);
                }
            }

            dataGridView1.DataSource = table;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = txtSearch.Text.ToLower();
            var filtered = table.AsEnumerable()
                .Where(r => r.ItemArray.Any(f => f.ToString().ToLower().Contains(filter)));

            dataGridView1.DataSource = filtered.Any()
                ? filtered.CopyToDataTable()
                : table.Clone();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string column = comboSort.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(column)) return;
            table.DefaultView.Sort = $"{column} ASC";
            dataGridView1.DataSource = table;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var lines = table.AsEnumerable()
                .Select(r => string.Join(";", r.ItemArray));
            File.WriteAllLines(filePath, lines);
            MessageBox.Show("Изменения сохранены!", "Успех");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                dataGridView1.Rows.Remove(row);
        }
    }
}
