
namespace WindowsFormsApp1
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Label lblPhone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassport = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Labels
            this.lblName.Text = "ФИО:";
            this.lblName.Location = new System.Drawing.Point(30, 10);
            this.lblName.Size = new System.Drawing.Size(60, 20);

            this.lblPassport.Text = "Паспорт:";
            this.lblPassport.Location = new System.Drawing.Point(30, 50);
            this.lblPassport.Size = new System.Drawing.Size(60, 20);

            this.lblPhone.Text = "Телефон:";
            this.lblPhone.Location = new System.Drawing.Point(30, 90);
            this.lblPhone.Size = new System.Drawing.Size(60, 20);

            // TextBoxes
            this.txtName.Location = new System.Drawing.Point(100, 10);
            this.txtName.Size = new System.Drawing.Size(150, 25);

            this.txtPassport.Location = new System.Drawing.Point(100, 50);
            this.txtPassport.Size = new System.Drawing.Size(150, 25);

            this.txtPhone.Location = new System.Drawing.Point(100, 90);
            this.txtPhone.Size = new System.Drawing.Size(150, 25);

            // Button
            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(30, 130);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Form2
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPassport);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnSave);
            this.Text = "Добавление клиента";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
