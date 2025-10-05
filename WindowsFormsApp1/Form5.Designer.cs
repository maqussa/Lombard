namespace WindowsFormsApp1
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.comboReport = new System.Windows.Forms.ComboBox();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.Location = new System.Drawing.Point(20, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(80, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(20, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 22);
            this.lblSearch.Text = "Поиск:";
            // 
            // lblReport
            // 
            this.lblReport.Location = new System.Drawing.Point(300, 20);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(100, 22);
            this.lblReport.Text = "Сформировать:";
            // 
            // comboReport
            // 
            this.comboReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboReport.FormattingEnabled = true;
            this.comboReport.Location = new System.Drawing.Point(400, 18);
            this.comboReport.Name = "comboReport";
            this.comboReport.Size = new System.Drawing.Size(150, 24);
            this.comboReport.TabIndex = 2;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(560, 15);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 30);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Сформировать";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form5
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.comboReport);
            this.Controls.Add(this.btnReport);
            this.Name = "Form5";
            this.Text = "Поиск и отчёты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.ComboBox comboReport;
        private System.Windows.Forms.Button btnReport;
    }
}
