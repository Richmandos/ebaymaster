namespace EbayMaster
{
    partial class FrmItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItem));
            this.treeViewCategories = new System.Windows.Forms.TreeView();
            this.contextMenuStripItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemDelItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDelItem = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxItemImagePath = new System.Windows.Forms.TextBox();
            this.textBoxItemCustomValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxItemCustomWeight = new System.Windows.Forms.TextBox();
            this.buttonAddOrModifyItem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCustomName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxItemWeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxItemStock = new System.Windows.Forms.TextBox();
            this.labelCurrentStock = new System.Windows.Forms.Label();
            this.textBoxItemStockShreshold = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonNavigateItemImage = new System.Windows.Forms.Button();
            this.pictureBoxItemPic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxItemSKU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDelSupplier = new System.Windows.Forms.Button();
            this.buttonSaveItemSupplier = new System.Windows.Forms.Button();
            this.dgvItemSuppliers = new System.Windows.Forms.DataGridView();
            this.buttonDupItem = new System.Windows.Forms.Button();
            this.buttonNewItem = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.contextMenuStripItem.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemPic)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewCategories
            // 
            this.treeViewCategories.AllowDrop = true;
            resources.ApplyResources(this.treeViewCategories, "treeViewCategories");
            this.treeViewCategories.Name = "treeViewCategories";
            this.treeViewCategories.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewCategories_ItemDrag);
            this.treeViewCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCategories_AfterSelect);
            this.treeViewCategories.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewCategories_NodeMouseClick);
            this.treeViewCategories.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewCategories_DragDrop);
            this.treeViewCategories.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewCategories_DragEnter);
            // 
            // contextMenuStripItem
            // 
            this.contextMenuStripItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDelItem});
            this.contextMenuStripItem.Name = "contextMenuStripItem";
            resources.ApplyResources(this.contextMenuStripItem, "contextMenuStripItem");
            // 
            // ToolStripMenuItemDelItem
            // 
            this.ToolStripMenuItemDelItem.Name = "ToolStripMenuItemDelItem";
            resources.ApplyResources(this.ToolStripMenuItemDelItem, "ToolStripMenuItemDelItem");
            this.ToolStripMenuItemDelItem.Click += new System.EventHandler(this.ToolStripMenuItemDelItem_Click);
            // 
            // buttonDelItem
            // 
            resources.ApplyResources(this.buttonDelItem, "buttonDelItem");
            this.buttonDelItem.Name = "buttonDelItem";
            this.buttonDelItem.UseVisualStyleBackColor = true;
            this.buttonDelItem.Click += new System.EventHandler(this.buttonDelItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCancel);
            this.tabPage1.Controls.Add(this.textBoxItemImagePath);
            this.tabPage1.Controls.Add(this.textBoxItemCustomValue);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.textBoxItemCustomWeight);
            this.tabPage1.Controls.Add(this.buttonAddOrModifyItem);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.textBoxCustomName);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBoxItemWeight);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBoxItemStock);
            this.tabPage1.Controls.Add(this.labelCurrentStock);
            this.tabPage1.Controls.Add(this.textBoxItemStockShreshold);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.buttonNavigateItemImage);
            this.tabPage1.Controls.Add(this.pictureBoxItemPic);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxItemSKU);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxItemName);
            this.tabPage1.Controls.Add(this.label2);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxItemImagePath
            // 
            resources.ApplyResources(this.textBoxItemImagePath, "textBoxItemImagePath");
            this.textBoxItemImagePath.Name = "textBoxItemImagePath";
            // 
            // textBoxItemCustomValue
            // 
            resources.ApplyResources(this.textBoxItemCustomValue, "textBoxItemCustomValue");
            this.textBoxItemCustomValue.Name = "textBoxItemCustomValue";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // textBoxItemCustomWeight
            // 
            resources.ApplyResources(this.textBoxItemCustomWeight, "textBoxItemCustomWeight");
            this.textBoxItemCustomWeight.Name = "textBoxItemCustomWeight";
            // 
            // buttonAddOrModifyItem
            // 
            this.buttonAddOrModifyItem.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.buttonAddOrModifyItem, "buttonAddOrModifyItem");
            this.buttonAddOrModifyItem.Name = "buttonAddOrModifyItem";
            this.buttonAddOrModifyItem.UseVisualStyleBackColor = false;
            this.buttonAddOrModifyItem.Click += new System.EventHandler(this.buttonAddOrModifyItem_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // textBoxCustomName
            // 
            resources.ApplyResources(this.textBoxCustomName, "textBoxCustomName");
            this.textBoxCustomName.Name = "textBoxCustomName";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // textBoxItemWeight
            // 
            resources.ApplyResources(this.textBoxItemWeight, "textBoxItemWeight");
            this.textBoxItemWeight.Name = "textBoxItemWeight";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // textBoxItemStock
            // 
            resources.ApplyResources(this.textBoxItemStock, "textBoxItemStock");
            this.textBoxItemStock.Name = "textBoxItemStock";
            this.textBoxItemStock.ReadOnly = true;
            // 
            // labelCurrentStock
            // 
            resources.ApplyResources(this.labelCurrentStock, "labelCurrentStock");
            this.labelCurrentStock.Name = "labelCurrentStock";
            // 
            // textBoxItemStockShreshold
            // 
            resources.ApplyResources(this.textBoxItemStockShreshold, "textBoxItemStockShreshold");
            this.textBoxItemStockShreshold.Name = "textBoxItemStockShreshold";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // buttonNavigateItemImage
            // 
            resources.ApplyResources(this.buttonNavigateItemImage, "buttonNavigateItemImage");
            this.buttonNavigateItemImage.Name = "buttonNavigateItemImage";
            this.buttonNavigateItemImage.UseVisualStyleBackColor = true;
            this.buttonNavigateItemImage.Click += new System.EventHandler(this.buttonNavigateItemImage_Click);
            // 
            // pictureBoxItemPic
            // 
            resources.ApplyResources(this.pictureBoxItemPic, "pictureBoxItemPic");
            this.pictureBoxItemPic.Name = "pictureBoxItemPic";
            this.pictureBoxItemPic.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxItemSKU
            // 
            resources.ApplyResources(this.textBoxItemSKU, "textBoxItemSKU");
            this.textBoxItemSKU.Name = "textBoxItemSKU";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxItemName
            // 
            resources.ApplyResources(this.textBoxItemName, "textBoxItemName");
            this.textBoxItemName.Name = "textBoxItemName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDelSupplier);
            this.tabPage2.Controls.Add(this.buttonSaveItemSupplier);
            this.tabPage2.Controls.Add(this.dgvItemSuppliers);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDelSupplier
            // 
            resources.ApplyResources(this.buttonDelSupplier, "buttonDelSupplier");
            this.buttonDelSupplier.Name = "buttonDelSupplier";
            this.buttonDelSupplier.UseVisualStyleBackColor = true;
            this.buttonDelSupplier.Click += new System.EventHandler(this.buttonDelSupplier_Click);
            // 
            // buttonSaveItemSupplier
            // 
            resources.ApplyResources(this.buttonSaveItemSupplier, "buttonSaveItemSupplier");
            this.buttonSaveItemSupplier.Name = "buttonSaveItemSupplier";
            this.buttonSaveItemSupplier.UseVisualStyleBackColor = true;
            this.buttonSaveItemSupplier.Click += new System.EventHandler(this.buttonSaveItemSupplier_Click);
            // 
            // dgvItemSuppliers
            // 
            this.dgvItemSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvItemSuppliers, "dgvItemSuppliers");
            this.dgvItemSuppliers.Name = "dgvItemSuppliers";
            this.dgvItemSuppliers.RowTemplate.Height = 23;
            this.dgvItemSuppliers.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvItemSuppliers_CellBeginEdit);
            this.dgvItemSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemSuppliers_CellContentDoubleClick);
            this.dgvItemSuppliers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItemSuppliers_RowHeaderMouseClick);
            this.dgvItemSuppliers.SelectionChanged += new System.EventHandler(this.dgvItemSuppliers_SelectionChanged);
            // 
            // buttonDupItem
            // 
            this.buttonDupItem.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.buttonDupItem, "buttonDupItem");
            this.buttonDupItem.Name = "buttonDupItem";
            this.buttonDupItem.UseVisualStyleBackColor = false;
            this.buttonDupItem.Click += new System.EventHandler(this.buttonDupItem_Click);
            // 
            // buttonNewItem
            // 
            this.buttonNewItem.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.buttonNewItem, "buttonNewItem");
            this.buttonNewItem.Name = "buttonNewItem";
            this.buttonNewItem.UseVisualStyleBackColor = false;
            this.buttonNewItem.Click += new System.EventHandler(this.buttonNewItem_Click);
            // 
            // labelStatus
            // 
            resources.ApplyResources(this.labelStatus, "labelStatus");
            this.labelStatus.ForeColor = System.Drawing.Color.Green;
            this.labelStatus.Name = "labelStatus";
            // 
            // FrmItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonNewItem);
            this.Controls.Add(this.buttonDupItem);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeViewCategories);
            this.Controls.Add(this.buttonDelItem);
            this.Name = "FrmItem";
            this.Load += new System.EventHandler(this.FrmItem_Load);
            this.contextMenuStripItem.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItemPic)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewCategories;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDelItem;
        private System.Windows.Forms.Button buttonDelItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxItemImagePath;
        private System.Windows.Forms.Button buttonAddOrModifyItem;
        private System.Windows.Forms.TextBox textBoxItemCustomValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxItemCustomWeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCustomName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxItemWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxItemStock;
        private System.Windows.Forms.Label labelCurrentStock;
        private System.Windows.Forms.TextBox textBoxItemStockShreshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonNavigateItemImage;
        private System.Windows.Forms.PictureBox pictureBoxItemPic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxItemSKU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonDupItem;
        private System.Windows.Forms.Button buttonNewItem;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSaveItemSupplier;
        private System.Windows.Forms.DataGridView dgvItemSuppliers;
        private System.Windows.Forms.Button buttonDelSupplier;
    }
}