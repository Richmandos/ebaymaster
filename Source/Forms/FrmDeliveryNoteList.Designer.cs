﻿namespace EbayMaster
{
    partial class FrmDeliveryNoteList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeliveryNoteList));
            this.contextMenuStripDeliveryNote = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDelDeliveryNote = new System.Windows.Forms.ToolStripMenuItem();
            this.pagedDgvDeliveryNote = new EbayMaster.PagedDataGridView();
            this.contextMenuStripDeliveryNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripDeliveryNote
            // 
            this.contextMenuStripDeliveryNote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDelDeliveryNote});
            this.contextMenuStripDeliveryNote.Name = "contextMenuStripDeliveryNote";
            resources.ApplyResources(this.contextMenuStripDeliveryNote, "contextMenuStripDeliveryNote");
            // 
            // ToolStripMenuItemDelDeliveryNote
            // 
            this.ToolStripMenuItemDelDeliveryNote.Name = "ToolStripMenuItemDelDeliveryNote";
            resources.ApplyResources(this.ToolStripMenuItemDelDeliveryNote, "ToolStripMenuItemDelDeliveryNote");
            this.ToolStripMenuItemDelDeliveryNote.Click += new System.EventHandler(this.ToolStripMenuItemDelDeliveryNote_Click);
            // 
            // pagedDgvDeliveryNote
            // 
            resources.ApplyResources(this.pagedDgvDeliveryNote, "pagedDgvDeliveryNote");
            this.pagedDgvDeliveryNote.Name = "pagedDgvDeliveryNote";
            this.pagedDgvDeliveryNote.Load += new System.EventHandler(this.pagedDgvDeliveryNote_Load);
            // 
            // FrmDeliveryNoteList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pagedDgvDeliveryNote);
            this.Name = "FrmDeliveryNoteList";
            this.Load += new System.EventHandler(this.FrmDeliveryNoteList_Load);
            this.contextMenuStripDeliveryNote.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripDeliveryNote;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelDeliveryNote;
        private PagedDataGridView pagedDgvDeliveryNote;
    }
}