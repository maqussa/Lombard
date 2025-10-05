namespace WindowsFormsApp1
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCondition;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Labels
            this.lblName.Text = "Название:";
            this.lblName.Location = new System.Drawing.Point(30, 10);
            this.lblName.Size = new System.Drawing.Size(80, 20);

            this.lblCategory.Text = "Категория:";
            this.lblCategory.Location = new System.Drawing.Point(30, 50);
            this.lblCategory.Size = new System.Drawing.Size(80, 20);

            this.lblCondition.Text = "Состояние:";
            this.lblCondition.Location = new System.Drawing.Point(30, 90);
            this.lblCondition.Size = new System.Drawing.Size(80, 20);

            // TextBoxes
            this.txtName.Location = new System.Drawing.Point(120, 10);
            this.txtName.Size = new System.Drawing.Size(150, 25);

            this.txtCategory.Location = new System.Drawing.Point(120, 50);
            this.txtCategory.Size = new System.Drawing.Size(150, 25);

            this.txtCondition.Location = new System.Drawing.Point(120, 90);
            this.txtCondition.Size = new System.Drawing.Size(150, 25);

            // Button
            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(30, 130);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Form3
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.btnSave);
            this.Text = "Добавление предмета";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
