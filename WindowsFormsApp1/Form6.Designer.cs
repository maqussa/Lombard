namespace WindowsFormsApp1
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.comboSort = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(20, 60);
            this.dataGridView1.Size = new System.Drawing.Size(540, 280);
            this.dataGridView1.AllowUserToAddRows = true;
            this.dataGridView1.AllowUserToDeleteRows = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Size = new System.Drawing.Size(160, 22);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // comboSort
            // 
            this.comboSort.Items.AddRange(new object[] { "ФИО", "Телефон", "Адрес" });
            this.comboSort.Location = new System.Drawing.Point(200, 20);
            this.comboSort.Size = new System.Drawing.Size(120, 22);
            // 
            // btnSort
            // 
            this.btnSort.Text = "Сортировать";
            this.btnSort.Location = new System.Drawing.Point(330, 18);
            this.btnSort.Size = new System.Drawing.Size(100, 25);
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSave
            // 
            this.btnSave.Text = "Сохранить";
            this.btnSave.Location = new System.Drawing.Point(440, 18);
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Location = new System.Drawing.Point(20, 350);
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form6
            // 
            this.ClientSize = new System.Drawing.Size(580, 390);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.comboSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Text = "Просмотр клиентов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ComboBox comboSort;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}
