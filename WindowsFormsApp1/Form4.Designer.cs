
namespace WindowsFormsApp1
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ListBox lstContracts;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lstContracts = new System.Windows.Forms.ListBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Labels
            this.lblClientID.Text = "ID клиента:";
            this.lblClientID.Location = new System.Drawing.Point(30, 10);
            this.lblClientID.Size = new System.Drawing.Size(80, 20);

            this.lblItemID.Text = "ID предмета:";
            this.lblItemID.Location = new System.Drawing.Point(30, 50);
            this.lblItemID.Size = new System.Drawing.Size(80, 20);

            this.lblSum.Text = "Сумма займа:";
            this.lblSum.Location = new System.Drawing.Point(30, 90);
            this.lblSum.Size = new System.Drawing.Size(80, 20);

            this.lblDate.Text = "Дата:";
            this.lblDate.Location = new System.Drawing.Point(30, 130);
            this.lblDate.Size = new System.Drawing.Size(80, 20);

            // TextBoxes
            this.txtClientID.Location = new System.Drawing.Point(120, 10);
            this.txtClientID.Size = new System.Drawing.Size(150, 25);

            this.txtItemID.Location = new System.Drawing.Point(120, 50);
            this.txtItemID.Size = new System.Drawing.Size(150, 25);

            this.txtSum.Location = new System.Drawing.Point(120, 90);
            this.txtSum.Size = new System.Drawing.Size(150, 25);

            // DateTimePicker
            this.dtpDate.Location = new System.Drawing.Point(120, 130);
            this.dtpDate.Size = new System.Drawing.Size(200, 25);

            // Buttons
            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(30, 170);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnView.Text = "Показать договоры";
            this.btnView.Location = new System.Drawing.Point(150, 170);
            this.btnView.Click += new System.EventHandler(this.btnView_Click);

            // ListBox
            this.lstContracts.Location = new System.Drawing.Point(30, 210);
            this.lstContracts.Size = new System.Drawing.Size(320, 150);

            // Form4
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lstContracts);
            this.Text = "Управление договорами";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
