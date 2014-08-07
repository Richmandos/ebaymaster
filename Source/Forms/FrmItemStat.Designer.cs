namespace EbayMaster
{
    partial class FrmItemStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemStat));
            this.pagedDgvItem = new EbayMaster.PagedDataGridView();
            this.SuspendLayout();
            // 
            // pagedDgvItem
            // 
            resources.ApplyResources(this.pagedDgvItem, "pagedDgvItem");
            this.pagedDgvItem.Name = "pagedDgvItem";
            this.pagedDgvItem.Load += new System.EventHandler(this.pagedDgvItem_Load);
            // 
            // FrmItemStat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pagedDgvItem);
            this.Name = "FrmItemStat";
            this.Load += new System.EventHandler(this.FrmItemStat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PagedDataGridView pagedDgvItem;
    }
}