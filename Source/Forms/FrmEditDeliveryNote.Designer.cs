namespace EbayMaster
{
    partial class FrmEditDeliveryNote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditDeliveryNote));
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTransactionId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddDeliveryNote = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.contextMenuStripTransaction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.textBoxExtraFee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.contextMenuStripTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewTransactions, "dataGridViewTransactions");
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.ReadOnly = true;
            this.dataGridViewTransactions.RowTemplate.Height = 23;
            this.dataGridViewTransactions.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridViewTransactions_MouseUp);
            // 
            // buttonAddTransaction
            // 
            resources.ApplyResources(this.buttonAddTransaction, "buttonAddTransaction");
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.UseVisualStyleBackColor = true;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBoxTransactionId
            // 
            resources.ApplyResources(this.textBoxTransactionId, "textBoxTransactionId");
            this.textBoxTransactionId.Name = "textBoxTransactionId";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Name = "label2";
            // 
            // buttonAddDeliveryNote
            // 
            resources.ApplyResources(this.buttonAddDeliveryNote, "buttonAddDeliveryNote");
            this.buttonAddDeliveryNote.Name = "buttonAddDeliveryNote";
            this.buttonAddDeliveryNote.UseVisualStyleBackColor = true;
            this.buttonAddDeliveryNote.Click += new System.EventHandler(this.buttonAddDeliveryNote_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // contextMenuStripTransaction
            // 
            this.contextMenuStripTransaction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDel});
            this.contextMenuStripTransaction.Name = "contextMenuStripTransaction";
            resources.ApplyResources(this.contextMenuStripTransaction, "contextMenuStripTransaction");
            this.contextMenuStripTransaction.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTransaction_Opening);
            // 
            // ToolStripMenuItemDel
            // 
            this.ToolStripMenuItemDel.Name = "ToolStripMenuItemDel";
            resources.ApplyResources(this.ToolStripMenuItemDel, "ToolStripMenuItemDel");
            this.ToolStripMenuItemDel.Click += new System.EventHandler(this.ToolStripMenuItemDel_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxFee
            // 
            resources.ApplyResources(this.textBoxFee, "textBoxFee");
            this.textBoxFee.Name = "textBoxFee";
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxComment
            // 
            resources.ApplyResources(this.textBoxComment, "textBoxComment");
            this.textBoxComment.Name = "textBoxComment";
            // 
            // FrmEditDeliveryNote
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxExtraFee);
            this.Controls.Add(this.textBoxFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddDeliveryNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTransactionId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddTransaction);
            this.Controls.Add(this.dataGridViewTransactions);
            this.Name = "FrmEditDeliveryNote";
            this.Load += new System.EventHandler(this.FrmDeliveryNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.contextMenuStripTransaction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.Button buttonAddTransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTransactionId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddDeliveryNote;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTransaction;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.TextBox textBoxExtraFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxComment;
    }
}