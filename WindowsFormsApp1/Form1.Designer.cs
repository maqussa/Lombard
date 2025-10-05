
namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnViewClients;
        private System.Windows.Forms.Button btnViewItems;
        private System.Windows.Forms.Button btnViewContracts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnClients = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnViewClients = new System.Windows.Forms.Button();
            this.btnViewItems = new System.Windows.Forms.Button();
            this.btnViewContracts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(20, 30);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(150, 30);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Добавить клиента";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(20, 70);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(150, 30);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "Добавить предмет";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.Location = new System.Drawing.Point(20, 110);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(150, 30);
            this.btnContracts.TabIndex = 2;
            this.btnContracts.Text = "Создать договор";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(20, 150);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(150, 30);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Отчёты";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnViewClients
            // 
            this.btnViewClients.Location = new System.Drawing.Point(200, 30);
            this.btnViewClients.Name = "btnViewClients";
            this.btnViewClients.Size = new System.Drawing.Size(150, 30);
            this.btnViewClients.TabIndex = 4;
            this.btnViewClients.Text = "Просмотр клиентов";
            this.btnViewClients.UseVisualStyleBackColor = true;
            this.btnViewClients.Click += new System.EventHandler(this.btnViewClients_Click);
            // 
            // btnViewItems
            // 
            this.btnViewItems.Location = new System.Drawing.Point(200, 70);
            this.btnViewItems.Name = "btnViewItems";
            this.btnViewItems.Size = new System.Drawing.Size(150, 30);
            this.btnViewItems.TabIndex = 5;
            this.btnViewItems.Text = "Просмотр предметов";
            this.btnViewItems.UseVisualStyleBackColor = true;
            this.btnViewItems.Click += new System.EventHandler(this.btnViewItems_Click);
            // 
            // btnViewContracts
            // 
            this.btnViewContracts.Location = new System.Drawing.Point(200, 110);
            this.btnViewContracts.Name = "btnViewContracts";
            this.btnViewContracts.Size = new System.Drawing.Size(150, 30);
            this.btnViewContracts.TabIndex = 6;
            this.btnViewContracts.Text = "Просмотр договоров";
            this.btnViewContracts.UseVisualStyleBackColor = true;
            this.btnViewContracts.Click += new System.EventHandler(this.btnViewContracts_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(380, 220);
            this.Controls.Add(this.btnViewContracts);
            this.Controls.Add(this.btnViewItems);
            this.Controls.Add(this.btnViewClients);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnContracts);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnClients);
            this.Name = "Form1";
            this.Text = "ИС Ломбард";
            this.ResumeLayout(false);
        }
    }
}
