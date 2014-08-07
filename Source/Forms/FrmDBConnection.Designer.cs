namespace EbayMaster
{
    partial class FrmDBConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDBConnection));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelSQLServer = new System.Windows.Forms.Panel();
            this.textBoxSQLServerPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSQLServerUserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSQLServerDBName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSQLServerDBAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAccess = new System.Windows.Forms.Panel();
            this.buttonNavigateItemImage = new System.Windows.Forms.Button();
            this.textBoxAccessFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSqlServer = new System.Windows.Forms.RadioButton();
            this.rbAccess = new System.Windows.Forms.RadioButton();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelSQLServer.SuspendLayout();
            this.panelAccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelSQLServer);
            this.groupBox1.Controls.Add(this.panelAccess);
            this.groupBox1.Controls.Add(this.rbSqlServer);
            this.groupBox1.Controls.Add(this.rbAccess);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // panelSQLServer
            // 
            this.panelSQLServer.Controls.Add(this.textBoxSQLServerPassword);
            this.panelSQLServer.Controls.Add(this.label6);
            this.panelSQLServer.Controls.Add(this.textBoxSQLServerUserId);
            this.panelSQLServer.Controls.Add(this.label5);
            this.panelSQLServer.Controls.Add(this.textBoxSQLServerDBName);
            this.panelSQLServer.Controls.Add(this.label4);
            this.panelSQLServer.Controls.Add(this.textBoxSQLServerDBAddr);
            this.panelSQLServer.Controls.Add(this.label3);
            resources.ApplyResources(this.panelSQLServer, "panelSQLServer");
            this.panelSQLServer.Name = "panelSQLServer";
            // 
            // textBoxSQLServerPassword
            // 
            resources.ApplyResources(this.textBoxSQLServerPassword, "textBoxSQLServerPassword");
            this.textBoxSQLServerPassword.Name = "textBoxSQLServerPassword";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textBoxSQLServerUserId
            // 
            resources.ApplyResources(this.textBoxSQLServerUserId, "textBoxSQLServerUserId");
            this.textBoxSQLServerUserId.Name = "textBoxSQLServerUserId";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBoxSQLServerDBName
            // 
            resources.ApplyResources(this.textBoxSQLServerDBName, "textBoxSQLServerDBName");
            this.textBoxSQLServerDBName.Name = "textBoxSQLServerDBName";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxSQLServerDBAddr
            // 
            resources.ApplyResources(this.textBoxSQLServerDBAddr, "textBoxSQLServerDBAddr");
            this.textBoxSQLServerDBAddr.Name = "textBoxSQLServerDBAddr";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panelAccess
            // 
            this.panelAccess.Controls.Add(this.buttonNavigateItemImage);
            this.panelAccess.Controls.Add(this.textBoxAccessFilePath);
            this.panelAccess.Controls.Add(this.label2);
            resources.ApplyResources(this.panelAccess, "panelAccess");
            this.panelAccess.Name = "panelAccess";
            // 
            // buttonNavigateItemImage
            // 
            resources.ApplyResources(this.buttonNavigateItemImage, "buttonNavigateItemImage");
            this.buttonNavigateItemImage.Name = "buttonNavigateItemImage";
            this.buttonNavigateItemImage.UseVisualStyleBackColor = true;
            this.buttonNavigateItemImage.Click += new System.EventHandler(this.buttonNavigateItemImage_Click);
            // 
            // textBoxAccessFilePath
            // 
            resources.ApplyResources(this.textBoxAccessFilePath, "textBoxAccessFilePath");
            this.textBoxAccessFilePath.Name = "textBoxAccessFilePath";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // rbSqlServer
            // 
            resources.ApplyResources(this.rbSqlServer, "rbSqlServer");
            this.rbSqlServer.Name = "rbSqlServer";
            this.rbSqlServer.UseVisualStyleBackColor = true;
            this.rbSqlServer.CheckedChanged += new System.EventHandler(this.rbSqlServer_CheckedChanged);
            // 
            // rbAccess
            // 
            resources.ApplyResources(this.rbAccess, "rbAccess");
            this.rbAccess.Checked = true;
            this.rbAccess.Name = "rbAccess";
            this.rbAccess.TabStop = true;
            this.rbAccess.UseVisualStyleBackColor = true;
            this.rbAccess.CheckedChanged += new System.EventHandler(this.rbAccess_CheckedChanged);
            // 
            // buttonSaveConfig
            // 
            resources.ApplyResources(this.buttonSaveConfig, "buttonSaveConfig");
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // FrmDBConnection
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSaveConfig);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDBConnection";
            this.Load += new System.EventHandler(this.FrmDBConnection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelSQLServer.ResumeLayout(false);
            this.panelSQLServer.PerformLayout();
            this.panelAccess.ResumeLayout(false);
            this.panelAccess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSqlServer;
        private System.Windows.Forms.RadioButton rbAccess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNavigateItemImage;
        private System.Windows.Forms.Panel panelSQLServer;
        private System.Windows.Forms.Panel panelAccess;
        private System.Windows.Forms.TextBox textBoxAccessFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSQLServerPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSQLServerUserId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSQLServerDBName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSQLServerDBAddr;
        private System.Windows.Forms.Button buttonSaveConfig;
    }
}