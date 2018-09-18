namespace MySqlBackupAll
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSetFolder = new System.Windows.Forms.Button();
            this.lbFolder = new System.Windows.Forms.Label();
            this.btBackup = new System.Windows.Forms.Button();
            this.btRestore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSetFolder
            // 
            this.btSetFolder.Location = new System.Drawing.Point(20, 39);
            this.btSetFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSetFolder.Name = "btSetFolder";
            this.btSetFolder.Size = new System.Drawing.Size(109, 36);
            this.btSetFolder.TabIndex = 0;
            this.btSetFolder.Text = "Set Folder";
            this.btSetFolder.UseVisualStyleBackColor = true;
            this.btSetFolder.Click += new System.EventHandler(this.btSetFolder_Click);
            // 
            // lbFolder
            // 
            this.lbFolder.AutoSize = true;
            this.lbFolder.Location = new System.Drawing.Point(136, 47);
            this.lbFolder.Name = "lbFolder";
            this.lbFolder.Size = new System.Drawing.Size(45, 20);
            this.lbFolder.TabIndex = 1;
            this.lbFolder.Text = "label1";
            // 
            // btBackup
            // 
            this.btBackup.Location = new System.Drawing.Point(275, 90);
            this.btBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(109, 36);
            this.btBackup.TabIndex = 2;
            this.btBackup.Text = "Backup";
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // btRestore
            // 
            this.btRestore.Location = new System.Drawing.Point(275, 134);
            this.btRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(109, 36);
            this.btRestore.TabIndex = 3;
            this.btRestore.Text = "Restore";
            this.btRestore.UseVisualStyleBackColor = true;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 100);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server\r\n\r\nUsername\r\n\r\nPassword";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(96, 87);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(142, 26);
            this.txtServer.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(96, 128);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(142, 26);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 168);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(142, 26);
            this.txtPassword.TabIndex = 7;
            // 
            // txtProgress
            // 
            this.txtProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProgress.Location = new System.Drawing.Point(20, 210);
            this.txtProgress.Multiline = true;
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.ReadOnly = true;
            this.txtProgress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtProgress.Size = new System.Drawing.Size(707, 284);
            this.txtProgress.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "This program will backup and restore all databases.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btRestore);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.lbFolder);
            this.Controls.Add(this.btSetFolder);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "MySql Backup Restore All";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSetFolder;
        private System.Windows.Forms.Label lbFolder;
        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Button btRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.Label label1;
    }
}

