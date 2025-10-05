
namespace WindowsFormsApp1
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Label
            this.lblSearch.Text = "ФИО:";
            this.lblSearch.Location = new System.Drawing.Point(30, 10);
            this.lblSearch.Size = new System.Drawing.Size(40, 20);

            // TextBox
            this.txtSearch.Location = new System.Drawing.Point(80, 10);
            this.txtSearch.Size = new System.Drawing.Size(200, 25);

            // Buttons
            this.btnSearch.Text = "Поиск клиента";
            this.btnSearch.Location = new System.Drawing.Point(30, 50);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnReport.Text = "Сформировать отчет";
            this.btnReport.Location = new System.Drawing.Point(150, 50);
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);

            // ListBox
            this.lstResults.Location = new System.Drawing.Point(30, 90);
            this.lstResults.Size = new System.Drawing.Size(340, 200);

            // Form5
            this.ClientSize = new System.Drawing.Size(420, 320);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lstResults);
            this.Text = "Поиск и отчёты";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
