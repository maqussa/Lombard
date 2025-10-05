using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        private string clientsFile = Path.Combine(Application.StartupPath, "data", "clients.txt");
        private string contractsFile = Path.Combine(Application.StartupPath, "data", "contracts.txt");

        private DataTable contractsTable = new DataTable();
        private DataTable currentViewTable = new DataTable(); // таблица для отображения в DataGridView

        public Form5()
        {
            InitializeComponent();
            LoadContracts();
            InitReportCombo();
        }

        private void LoadContracts()
        {
            contractsTable.Clear();
            contractsTable.Columns.Clear();
            contractsTable.Columns.Add("Клиент");
            contractsTable.Columns.Add("Предмет");
            contractsTable.Columns.Add("Сумма");

            if (File.Exists(contractsFile))
            {
                foreach (var line in File.ReadAllLines(contractsFile))
                {
                    var parts = line.Split(';');
                    if (parts.Length >= 3)
                        contractsTable.Rows.Add(parts[0], parts[1], parts[2]);
                }
            }

            currentViewTable.Clear();
        }

        private void InitReportCombo()
        {
            comboReport.Items.Clear();
            comboReport.Items.Add("Все договоры");
            comboReport.Items.Add("Сумма по клиенту");
            comboReport.Items.Add("Сумма по предмету");
            comboReport.SelectedIndex = 0;
        }

        // Сформировать отчёт
        private void btnReport_Click(object sender, EventArgs e)
        {
            string reportType = comboReport.SelectedItem.ToString();

            if (contractsTable.Rows.Count == 0)
            {
                MessageBox.Show("Договоров нет.");
                return;
            }

            switch (reportType)
            {
                case "Все договоры":
                    currentViewTable = contractsTable.Copy();
                    break;

                case "Сумма по клиенту":
                    currentViewTable = new DataTable();
                    currentViewTable.Columns.Add("Клиент");
                    currentViewTable.Columns.Add("Сумма");

                    var byClient = contractsTable.AsEnumerable()
                        .GroupBy(r => r["Клиент"])
                        .Select(g => new
                        {
                            Клиент = g.Key,
                            Сумма = g.Sum(r => decimal.TryParse(r["Сумма"].ToString(), out var val) ? val : 0)
                        });

                    foreach (var row in byClient)
                        currentViewTable.Rows.Add(row.Клиент, row.Сумма);
                    break;

                case "Сумма по предмету":
                    currentViewTable = new DataTable();
                    currentViewTable.Columns.Add("Предмет");
                    currentViewTable.Columns.Add("Сумма");

                    var byItem = contractsTable.AsEnumerable()
                        .GroupBy(r => r["Предмет"])
                        .Select(g => new
                        {
                            Предмет = g.Key,
                            Сумма = g.Sum(r => decimal.TryParse(r["Сумма"].ToString(), out var val) ? val : 0)
                        });

                    foreach (var row in byItem)
                        currentViewTable.Rows.Add(row.Предмет, row.Сумма);
                    break;
            }

            // Показать таблицу в DataGridView
            dataGridView1.DataSource = currentViewTable;
        }

        // Поиск по текущему виду
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (currentViewTable == null || currentViewTable.Rows.Count == 0)
                return;

            string filter = txtSearch.Text.ToLower();
            var filtered = currentViewTable.AsEnumerable()
                .Where(r => r.ItemArray.Any(f => f.ToString().ToLower().Contains(filter)));

            dataGridView1.DataSource = filtered.Any() ? filtered.CopyToDataTable() : currentViewTable.Clone();
        }
    }
}
