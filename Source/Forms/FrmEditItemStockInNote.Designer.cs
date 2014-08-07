namespace EbayMaster
{
    partial class FrmEditItemStockInNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditItemStockInNote));
            this.textBoxItemSKU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSourcingNoteId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStockInNum = new System.Windows.Forms.TextBox();
            this.dateTimePickerStockInTime = new System.Windows.Forms.DateTimePicker();
            this.buttonFinishEditingItemStockInNote = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxItemSKU
            // 
            resources.ApplyResources(this.textBoxItemSKU, "textBoxItemSKU");
            this.textBoxItemSKU.Name = "textBoxItemSKU";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBoxSourcingNoteId
            // 
            resources.ApplyResources(this.textBoxSourcingNoteId, "textBoxSourcingNoteId");
            this.textBoxSourcingNoteId.Name = "textBoxSourcingNoteId";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxStockInNum
            // 
            resources.ApplyResources(this.textBoxStockInNum, "textBoxStockInNum");
            this.textBoxStockInNum.Name = "textBoxStockInNum";
            // 
            // dateTimePickerStockInTime
            // 
            resources.ApplyResources(this.dateTimePickerStockInTime, "dateTimePickerStockInTime");
            this.dateTimePickerStockInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStockInTime.Name = "dateTimePickerStockInTime";
            // 
            // buttonFinishEditingItemStockInNote
            // 
            resources.ApplyResources(this.buttonFinishEditingItemStockInNote, "buttonFinishEditingItemStockInNote");
            this.buttonFinishEditingItemStockInNote.Name = "buttonFinishEditingItemStockInNote";
            this.buttonFinishEditingItemStockInNote.UseVisualStyleBackColor = true;
            this.buttonFinishEditingItemStockInNote.Click += new System.EventHandler(this.buttonFinishEditingItemStockInNote_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBoxComment
            // 
            resources.ApplyResources(this.textBoxComment, "textBoxComment");
            this.textBoxComment.Name = "textBoxComment";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // FrmEditItemStockInNote
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonFinishEditingItemStockInNote);
            this.Controls.Add(this.dateTimePickerStockInTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxStockInNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSourcingNoteId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxItemSKU);
            this.Name = "FrmEditItemStockInNote";
            this.Load += new System.EventHandler(this.FrmEditItemStockInNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxItemSKU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSourcingNoteId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStockInNum;
        private System.Windows.Forms.DateTimePicker dateTimePickerStockInTime;
        private System.Windows.Forms.Button buttonFinishEditingItemStockInNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label6;
    }
}