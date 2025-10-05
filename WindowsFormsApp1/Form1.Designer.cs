namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.btnViewClients = new System.Windows.Forms.Button();
            this.btnViewItems = new System.Windows.Forms.Button();
            this.btnViewContracts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(40, 30);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(180, 40);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(40, 80);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(180, 40);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Добавить предмет";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(40, 130);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(180, 40);
            this.btnAddContract.TabIndex = 2;
            this.btnAddContract.Text = "Добавить договор";
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // btnReports
            this.btnReports = new System.Windows.Forms.Button();
            this.btnReports.Location = new System.Drawing.Point(250, 180); // под другими кнопками
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(180, 40);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Поиск и отчёты";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnViewClients
            // 
            this.btnViewClients.Location = new System.Drawing.Point(250, 30);
            this.btnViewClients.Name = "btnViewClients";
            this.btnViewClients.Size = new System.Drawing.Size(180, 40);
            this.btnViewClients.TabIndex = 3;
            this.btnViewClients.Text = "Просмотр клиентов";
            this.btnViewClients.UseVisualStyleBackColor = true;
            this.btnViewClients.Click += new System.EventHandler(this.btnViewClients_Click);
            // 
            // btnViewItems
            // 
            this.btnViewItems.Location = new System.Drawing.Point(250, 80);
            this.btnViewItems.Name = "btnViewItems";
            this.btnViewItems.Size = new System.Drawing.Size(180, 40);
            this.btnViewItems.TabIndex = 4;
            this.btnViewItems.Text = "Просмотр предметов";
            this.btnViewItems.UseVisualStyleBackColor = true;
            this.btnViewItems.Click += new System.EventHandler(this.btnViewItems_Click);
            // 
            // btnViewContracts
            // 
            this.btnViewContracts.Location = new System.Drawing.Point(250, 130);
            this.btnViewContracts.Name = "btnViewContracts";
            this.btnViewContracts.Size = new System.Drawing.Size(180, 40);
            this.btnViewContracts.TabIndex = 5;
            this.btnViewContracts.Text = "Просмотр договоров";
            this.btnViewContracts.UseVisualStyleBackColor = true;
            this.btnViewContracts.Click += new System.EventHandler(this.btnViewContracts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnViewContracts);
            this.Controls.Add(this.btnViewItems);
            this.Controls.Add(this.btnViewClients);
            this.Controls.Add(this.btnAddContract);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnReports);
            this.Name = "Form1";
            this.Text = "ИС Ломбард — Главная";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.Button btnViewClients;
        private System.Windows.Forms.Button btnViewItems;
        private System.Windows.Forms.Button btnViewContracts;
        private System.Windows.Forms.Button btnReports;
    }
}
