namespace EbayMaster
{
    partial class FrmItemCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemCategory));
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.textBoxParentCategory = new System.Windows.Forms.TextBox();
            this.labelParentCategoryName = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddNewCategory = new System.Windows.Forms.Button();
            this.treeViewAllCategories = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // buttonDeleteCategory
            // 
            resources.ApplyResources(this.buttonDeleteCategory, "buttonDeleteCategory");
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // textBoxParentCategory
            // 
            resources.ApplyResources(this.textBoxParentCategory, "textBoxParentCategory");
            this.textBoxParentCategory.Name = "textBoxParentCategory";
            // 
            // labelParentCategoryName
            // 
            resources.ApplyResources(this.labelParentCategoryName, "labelParentCategoryName");
            this.labelParentCategoryName.Name = "labelParentCategoryName";
            // 
            // textBoxCategoryName
            // 
            resources.ApplyResources(this.textBoxCategoryName, "textBoxCategoryName");
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // buttonAddNewCategory
            // 
            resources.ApplyResources(this.buttonAddNewCategory, "buttonAddNewCategory");
            this.buttonAddNewCategory.Name = "buttonAddNewCategory";
            this.buttonAddNewCategory.UseVisualStyleBackColor = true;
            this.buttonAddNewCategory.Click += new System.EventHandler(this.buttonAddNewCategory_Click);
            // 
            // treeViewAllCategories
            // 
            resources.ApplyResources(this.treeViewAllCategories, "treeViewAllCategories");
            this.treeViewAllCategories.Name = "treeViewAllCategories";
            this.treeViewAllCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewAllCategories_AfterSelect);
            // 
            // FrmItemCategory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.textBoxParentCategory);
            this.Controls.Add(this.labelParentCategoryName);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddNewCategory);
            this.Controls.Add(this.treeViewAllCategories);
            this.Name = "FrmItemCategory";
            this.Load += new System.EventHandler(this.FrmItemCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.TextBox textBoxParentCategory;
        private System.Windows.Forms.Label labelParentCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddNewCategory;
        private System.Windows.Forms.TreeView treeViewAllCategories;
    }
}