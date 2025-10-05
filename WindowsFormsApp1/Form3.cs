
using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        string path = PathCombine("items.txt");

        public Form3()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string itemData = $"{txtName.Text};{txtCategory.Text};{txtValue.Text}";
            File.AppendAllText(path, itemData + Environment.NewLine);
            MessageBox.Show("Предмет сохранён!");
            txtName.Text = "";
            txtCategory.Text = "";
            txtValue.Text = "";
        }

        private static string PathCombine(string filename)
        {
            return System.IO.Path.Combine(Application.StartupPath, filename);
        }
    }
}
