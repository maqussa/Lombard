
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        string clientsFile = PathCombine("clients.txt");
        string contractsFile = PathCombine("contracts.txt");

        public Form5()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            if (File.Exists(clientsFile))
            {
                var lines = File.ReadAllLines(clientsFile);
                var results = lines.Where(l => l.Contains(txtSearch.Text)).ToList();
                foreach (var r in results) lstResults.Items.Add(r);

                if (results.Count == 0) lstResults.Items.Add("Ничего не найдено.");
            }
            else
            {
                lstResults.Items.Add("Файл клиентов отсутствует.");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            if (File.Exists(contractsFile))
            {
                var lines = File.ReadAllLines(contractsFile);
                lstResults.Items.Add("Всего договоров: " + lines.Length);
                decimal total = 0;
                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length >= 3 && decimal.TryParse(parts[2], out decimal sum))
                        total += sum;
                }
                lstResults.Items.Add("Общая сумма займов: " + total + " руб.");
            }
            else
            {
                lstResults.Items.Add("Договоров нет.");
            }
        }

        private static string PathCombine(string filename)
        {
            return System.IO.Path.Combine(Application.StartupPath, filename);
        }
    }
}
