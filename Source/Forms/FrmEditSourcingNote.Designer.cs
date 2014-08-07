namespace EbayMaster
{
    partial class FrmEditSourcingNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditSourcingNote));
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSelectSupplier = new System.Windows.Forms.Button();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelErrMsg = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTotalFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxShippingFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxExtraFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCalTotalFee = new System.Windows.Forms.Button();
            this.buttonFinishEditing = new System.Windows.Forms.Button();
            this.dgvItems = new EbayMaster.CustomGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // dateTimePickerDate
            // 
            resources.ApplyResources(this.dateTimePickerDate, "dateTimePickerDate");
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            // 
            // buttonSelectSupplier
            // 
            resources.ApplyResources(this.buttonSelectSupplier, "buttonSelectSupplier");
            this.buttonSelectSupplier.Name = "buttonSelectSupplier";
            this.buttonSelectSupplier.UseVisualStyleBackColor = true;
            this.buttonSelectSupplier.Click += new System.EventHandler(this.buttonSelectSupplier_Click);
            // 
            // textBoxSupplier
            // 
            resources.ApplyResources(this.textBoxSupplier, "textBoxSupplier");
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // labelErrMsg
            // 
            resources.ApplyResources(this.labelErrMsg, "labelErrMsg");
            this.labelErrMsg.ForeColor = System.Drawing.Color.Red;
            this.labelErrMsg.Name = "labelErrMsg";
            // 
            // textBoxComment
            // 
            resources.ApplyResources(this.textBoxComment, "textBoxComment");
            this.textBoxComment.Name = "textBoxComment";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // textBoxTotalFee
            // 
            resources.ApplyResources(this.textBoxTotalFee, "textBoxTotalFee");
            this.textBoxTotalFee.Name = "textBoxTotalFee";
            this.textBoxTotalFee.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // textBoxShippingFee
            // 
            resources.ApplyResources(this.textBoxShippingFee, "textBoxShippingFee");
            this.textBoxShippingFee.Name = "textBoxShippingFee";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // textBoxExtraFee
            // 
            resources.ApplyResources(this.textBoxExtraFee, "textBoxExtraFee");
            this.textBoxExtraFee.Name = "textBoxExtraFee";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // buttonCalTotalFee
            // 
            resources.ApplyResources(this.buttonCalTotalFee, "buttonCalTotalFee");
            this.buttonCalTotalFee.Name = "buttonCalTotalFee";
            this.buttonCalTotalFee.UseVisualStyleBackColor = true;
            this.buttonCalTotalFee.Click += new System.EventHandler(this.buttonCalTotalFee_Click);
            // 
            // buttonFinishEditing
            // 
            resources.ApplyResources(this.buttonFinishEditing, "buttonFinishEditing");
            this.buttonFinishEditing.Name = "buttonFinishEditing";
            this.buttonFinishEditing.UseVisualStyleBackColor = true;
            this.buttonFinishEditing.Click += new System.EventHandler(this.buttonFinishEditing_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvItems, "dgvItems");
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowTemplate.Height = 23;
            this.dgvItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellClick);
            this.dgvItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItems_KeyDown);
            this.dgvItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvItems_KeyPress);
            // 
            // FrmEditSourcingNote
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCalTotalFee);
            this.Controls.Add(this.buttonFinishEditing);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTotalFee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxShippingFee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxExtraFee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelErrMsg);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.buttonSelectSupplier);
            this.Controls.Add(this.textBoxSupplier);
            this.Controls.Add(this.label4);
            this.Name = "FrmEditSourcingNote";
            this.Load += new System.EventHandler(this.FrmEditSourcingNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonSelectSupplier;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelErrMsg;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTotalFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxShippingFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxExtraFee;
        private System.Windows.Forms.Label label5;
        private CustomGrid dgvItems;
        private System.Windows.Forms.Button buttonCalTotalFee;
        private System.Windows.Forms.Button buttonFinishEditing;
    }
}