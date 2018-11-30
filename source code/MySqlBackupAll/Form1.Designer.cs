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
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConnStr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbExportTableStructure = new System.Windows.Forms.CheckBox();
            this.cbExportRows = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btSetFolder
            // 
            this.btSetFolder.Location = new System.Drawing.Point(20, 33);
            this.btSetFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btSetFolder.Name = "btSetFolder";
            this.btSetFolder.Size = new System.Drawing.Size(109, 36);
            this.btSetFolder.TabIndex = 0;
            this.btSetFolder.Text = "Select Folder";
            this.btSetFolder.UseVisualStyleBackColor = true;
            this.btSetFolder.Click += new System.EventHandler(this.btSetFolder_Click);
            // 
            // lbFolder
            // 
            this.lbFolder.AutoSize = true;
            this.lbFolder.Location = new System.Drawing.Point(136, 41);
            this.lbFolder.Name = "lbFolder";
            this.lbFolder.Size = new System.Drawing.Size(127, 20);
            this.lbFolder.TabIndex = 1;
            this.lbFolder.Text = "No Folder Selected";
            // 
            // btBackup
            // 
            this.btBackup.Location = new System.Drawing.Point(20, 109);
            this.btBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(188, 36);
            this.btBackup.TabIndex = 2;
            this.btBackup.Text = "Start Backup All Databases";
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // btRestore
            // 
            this.btRestore.Location = new System.Drawing.Point(216, 109);
            this.btRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(189, 36);
            this.btRestore.TabIndex = 3;
            this.btRestore.Text = "Start Restore Databases";
            this.btRestore.UseVisualStyleBackColor = true;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // txtProgress
            // 
            this.txtProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProgress.Location = new System.Drawing.Point(20, 152);
            this.txtProgress.Multiline = true;
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.ReadOnly = true;
            this.txtProgress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtProgress.Size = new System.Drawing.Size(707, 342);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "MySQL Connection String:";
            // 
            // txtConnStr
            // 
            this.txtConnStr.Location = new System.Drawing.Point(188, 73);
            this.txtConnStr.Name = "txtConnStr";
            this.txtConnStr.Size = new System.Drawing.Size(538, 26);
            this.txtConnStr.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "*Restore: Make the folder have SQL dump files.";
            // 
            // cbExportTableStructure
            // 
            this.cbExportTableStructure.AutoSize = true;
            this.cbExportTableStructure.Checked = true;
            this.cbExportTableStructure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExportTableStructure.Location = new System.Drawing.Point(388, 8);
            this.cbExportTableStructure.Name = "cbExportTableStructure";
            this.cbExportTableStructure.Size = new System.Drawing.Size(170, 24);
            this.cbExportTableStructure.TabIndex = 13;
            this.cbExportTableStructure.Text = "Export Table\'s Structure";
            this.cbExportTableStructure.UseVisualStyleBackColor = true;
            // 
            // cbExportRows
            // 
            this.cbExportRows.AutoSize = true;
            this.cbExportRows.Checked = true;
            this.cbExportRows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExportRows.Location = new System.Drawing.Point(564, 8);
            this.cbExportRows.Name = "cbExportRows";
            this.cbExportRows.Size = new System.Drawing.Size(104, 24);
            this.cbExportRows.TabIndex = 14;
            this.cbExportRows.Text = "Export Rows";
            this.cbExportRows.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 507);
            this.Controls.Add(this.cbExportRows);
            this.Controls.Add(this.cbExportTableStructure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConnStr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.btRestore);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.lbFolder);
            this.Controls.Add(this.btSetFolder);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConnStr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbExportTableStructure;
        private System.Windows.Forms.CheckBox cbExportRows;
    }
}

