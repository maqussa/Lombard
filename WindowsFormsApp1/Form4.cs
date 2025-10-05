
using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        string path = PathCombine("contracts.txt");

        public Form4()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string contractData = $"{txtClientID.Text};{txtItemID.Text};{txtSum.Text};{dtpDate.Value.ToShortDateString()}";
            File.AppendAllText(path, contractData + Environment.NewLine);
            MessageBox.Show("Договор сохранён!");
            txtClientID.Text = "";
            txtItemID.Text = "";
            txtSum.Text = "";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                lstContracts.Items.Clear();
                string[] lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    lstContracts.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Файл договоров пуст или отсутствует.");
            }
        }

        private static string PathCombine(string filename)
        {
            return System.IO.Path.Combine(Application.StartupPath, filename);
        }
    }
}
