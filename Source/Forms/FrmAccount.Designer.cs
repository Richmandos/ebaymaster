namespace EbayMaster
{
    partial class FrmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccount));
            this.listBoxAllAccounts = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPayPalPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPayPalUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPayPalSignature = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPayPalAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEbayToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEbayAccount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddOrUpdateAccount = new System.Windows.Forms.Button();
            this.buttonDelAccount = new System.Windows.Forms.Button();
            this.buttonGetToken = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAllAccounts
            // 
            resources.ApplyResources(this.listBoxAllAccounts, "listBoxAllAccounts");
            this.listBoxAllAccounts.FormattingEnabled = true;
            this.listBoxAllAccounts.Name = "listBoxAllAccounts";
            this.listBoxAllAccounts.SelectedIndexChanged += new System.EventHandler(this.listBoxAllAccounts_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.textBoxPayPalPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxPayPalUsername);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxPayPalSignature);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxPayPalAccount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxEbayToken);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxEbayAccount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textBoxPayPalPassword
            // 
            resources.ApplyResources(this.textBoxPayPalPassword, "textBoxPayPalPassword");
            this.textBoxPayPalPassword.Name = "textBoxPayPalPassword";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textBoxPayPalUsername
            // 
            resources.ApplyResources(this.textBoxPayPalUsername, "textBoxPayPalUsername");
            this.textBoxPayPalUsername.Name = "textBoxPayPalUsername";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBoxPayPalSignature
            // 
            resources.ApplyResources(this.textBoxPayPalSignature, "textBoxPayPalSignature");
            this.textBoxPayPalSignature.Name = "textBoxPayPalSignature";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxPayPalAccount
            // 
            resources.ApplyResources(this.textBoxPayPalAccount, "textBoxPayPalAccount");
            this.textBoxPayPalAccount.Name = "textBoxPayPalAccount";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxEbayToken
            // 
            resources.ApplyResources(this.textBoxEbayToken, "textBoxEbayToken");
            this.textBoxEbayToken.Name = "textBoxEbayToken";
            this.textBoxEbayToken.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBoxEbayAccount
            // 
            resources.ApplyResources(this.textBoxEbayAccount, "textBoxEbayAccount");
            this.textBoxEbayAccount.Name = "textBoxEbayAccount";
            this.textBoxEbayAccount.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnAddOrUpdateAccount
            // 
            resources.ApplyResources(this.btnAddOrUpdateAccount, "btnAddOrUpdateAccount");
            this.btnAddOrUpdateAccount.Name = "btnAddOrUpdateAccount";
            this.btnAddOrUpdateAccount.UseVisualStyleBackColor = true;
            this.btnAddOrUpdateAccount.Click += new System.EventHandler(this.btnAddOrUpdateAccount_Click);
            // 
            // buttonDelAccount
            // 
            resources.ApplyResources(this.buttonDelAccount, "buttonDelAccount");
            this.buttonDelAccount.Name = "buttonDelAccount";
            this.buttonDelAccount.UseVisualStyleBackColor = true;
            this.buttonDelAccount.Click += new System.EventHandler(this.buttonDelAccount_Click);
            // 
            // buttonGetToken
            // 
            resources.ApplyResources(this.buttonGetToken, "buttonGetToken");
            this.buttonGetToken.Name = "buttonGetToken";
            this.buttonGetToken.UseVisualStyleBackColor = true;
            this.buttonGetToken.Click += new System.EventHandler(this.buttonGetToken_Click);
            // 
            // FrmAccount
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonGetToken);
            this.Controls.Add(this.buttonDelAccount);
            this.Controls.Add(this.btnAddOrUpdateAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxAllAccounts);
            this.Name = "FrmAccount";
            this.Load += new System.EventHandler(this.FrmAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAllAccounts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPayPalPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPayPalUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPayPalSignature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPayPalAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEbayToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEbayAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddOrUpdateAccount;
        private System.Windows.Forms.Button buttonDelAccount;
        private System.Windows.Forms.Button buttonGetToken;
    }
}