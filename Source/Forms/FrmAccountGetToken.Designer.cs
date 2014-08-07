namespace EbayMaster
{
    partial class FrmAccountGetToken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccountGetToken));
            this.buttonGetTokenStep1 = new System.Windows.Forms.Button();
            this.buttonGetTokenStep2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetTokenStep1
            // 
            resources.ApplyResources(this.buttonGetTokenStep1, "buttonGetTokenStep1");
            this.buttonGetTokenStep1.Name = "buttonGetTokenStep1";
            this.buttonGetTokenStep1.UseVisualStyleBackColor = true;
            this.buttonGetTokenStep1.Click += new System.EventHandler(this.buttonGetTokenStep1_Click);
            // 
            // buttonGetTokenStep2
            // 
            resources.ApplyResources(this.buttonGetTokenStep2, "buttonGetTokenStep2");
            this.buttonGetTokenStep2.Name = "buttonGetTokenStep2";
            this.buttonGetTokenStep2.UseVisualStyleBackColor = true;
            this.buttonGetTokenStep2.Click += new System.EventHandler(this.buttonGetTokenStep2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EbayMaster.Properties.Resources.downarrow;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EbayMaster.Properties.Resources.downarrow;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxToken);
            this.groupBox1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textBoxToken
            // 
            resources.ApplyResources(this.textBoxToken, "textBoxToken");
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // buttonFinish
            // 
            resources.ApplyResources(this.buttonFinish, "buttonFinish");
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // FrmAccountGetToken
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGetTokenStep2);
            this.Controls.Add(this.buttonGetTokenStep1);
            this.Name = "FrmAccountGetToken";
            this.Load += new System.EventHandler(this.FrmAccountGetToken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetTokenStep1;
        private System.Windows.Forms.Button buttonGetTokenStep2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFinish;
    }
}