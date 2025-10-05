
using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string path = PathCombine("clients.txt");

        public Form2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string clientData = $"{txtName.Text};{txtPassport.Text};{txtPhone.Text}";
            File.AppendAllText(path, clientData + Environment.NewLine);
            MessageBox.Show("Клиент сохранён!");
            txtName.Text = "";
            txtPassport.Text = "";
            txtPhone.Text = "";
        }

        private static string PathCombine(string filename)
        {
            return System.IO.Path.Combine(Application.StartupPath, filename);
        }
    }
}
