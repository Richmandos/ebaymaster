namespace EbayMaster
{
    partial class FrmItemStockInNoteList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemStockInNoteList));
            this.contextMenuStripItemStockInNote = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDelItemStockInNote = new System.Windows.Forms.ToolStripMenuItem();
            this.pagedDgvItem = new EbayMaster.PagedDataGridView();
            this.contextMenuStripItemStockInNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripItemStockInNote
            // 
            this.contextMenuStripItemStockInNote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDelItemStockInNote});
            this.contextMenuStripItemStockInNote.Name = "contextMenuStripDeliveryNote";
            resources.ApplyResources(this.contextMenuStripItemStockInNote, "contextMenuStripItemStockInNote");
            // 
            // ToolStripMenuItemDelItemStockInNote
            // 
            this.ToolStripMenuItemDelItemStockInNote.Name = "ToolStripMenuItemDelItemStockInNote";
            resources.ApplyResources(this.ToolStripMenuItemDelItemStockInNote, "ToolStripMenuItemDelItemStockInNote");
            this.ToolStripMenuItemDelItemStockInNote.Click += new System.EventHandler(this.ToolStripMenuItemDelItemStockInNote_Click);
            // 
            // pagedDgvItem
            // 
            resources.ApplyResources(this.pagedDgvItem, "pagedDgvItem");
            this.pagedDgvItem.Name = "pagedDgvItem";
            // 
            // FrmItemStockInNoteList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pagedDgvItem);
            this.Name = "FrmItemStockInNoteList";
            this.Load += new System.EventHandler(this.FrmItemStockInNoteList_Load);
            this.contextMenuStripItemStockInNote.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripItemStockInNote;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelItemStockInNote;
        private PagedDataGridView pagedDgvItem;
    }
}