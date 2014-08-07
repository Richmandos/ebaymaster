namespace EbayMaster
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExportEbayCVS = new System.Windows.Forms.Button();
            this.buttonExportSelectedToExcel = new System.Windows.Forms.Button();
            this.buttonSyncEbayData = new System.Windows.Forms.Button();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.tabControlEbayMaster = new System.Windows.Forms.TabControl();
            this.tabPageOrder = new System.Windows.Forms.TabPage();
            this.radioButtonDeliveredOrders = new System.Windows.Forms.RadioButton();
            this.radioButtonPendingOrders = new System.Windows.Forms.RadioButton();
            this.buttonOrderLastPage = new System.Windows.Forms.Button();
            this.buttonOrderFirstPage = new System.Windows.Forms.Button();
            this.labelOrderPage = new System.Windows.Forms.Label();
            this.buttonOrderPrevPage = new System.Windows.Forms.Button();
            this.buttonOrderNextPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewAllOrders = new System.Windows.Forms.DataGridView();
            this.tabPageSelling = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonListingLastPage = new System.Windows.Forms.Button();
            this.buttonListingFirstPage = new System.Windows.Forms.Button();
            this.labelListingPage = new System.Windows.Forms.Label();
            this.buttonListingPrevPage = new System.Windows.Forms.Button();
            this.buttonListingNextPage = new System.Windows.Forms.Button();
            this.dataGridViewActiveListing = new System.Windows.Forms.DataGridView();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.pagedDgvMessages = new EbayMaster.PagedDataGridView();
            this.tabControlMessage = new System.Windows.Forms.TabControl();
            this.tabPageAllMessage = new System.Windows.Forms.TabPage();
            this.tabPagePostSale = new System.Windows.Forms.TabPage();
            this.buttonPostSaleLastPage = new System.Windows.Forms.Button();
            this.buttonPostSaleFirstPage = new System.Windows.Forms.Button();
            this.labelPostSalePage = new System.Windows.Forms.Label();
            this.buttonPostSalePrevPage = new System.Windows.Forms.Button();
            this.buttonPostSaleNextPage = new System.Windows.Forms.Button();
            this.dataGridViewPostSale = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.contextMenuStripPostSale = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemViewMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSendMessageToBuyer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEbayMaster = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGroupItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewItemStat = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCreateSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCreateSourcingNote = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewSourcingNote = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSourcingAndDispatching = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCreateItemStockInNote = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewItemStockInNote = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCreateDeliveryNote = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewDeliveryNote = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSystemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDBConnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMessageTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEbayFees = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMessage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemReplyMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTransaction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemViewTransactionDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewTransactionMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSendMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAddRelationToItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemViewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSelectShippingService = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMarkAsShipped = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUploadTrackingNum = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLeaveFeedback = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSetShippingCost = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCreateDeliveryNoteFromOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMergeOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tabControlEbayMaster.SuspendLayout();
            this.tabPageOrder.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllOrders)).BeginInit();
            this.tabPageSelling.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveListing)).BeginInit();
            this.tabPageMessages.SuspendLayout();
            this.tabControlMessage.SuspendLayout();
            this.tabPagePostSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostSale)).BeginInit();
            this.panel3.SuspendLayout();
            this.contextMenuStripPostSale.SuspendLayout();
            this.menuStripEbayMaster.SuspendLayout();
            this.contextMenuStripMessage.SuspendLayout();
            this.contextMenuStripTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonExportEbayCVS);
            this.panel1.Controls.Add(this.buttonExportSelectedToExcel);
            this.panel1.Controls.Add(this.buttonSyncEbayData);
            this.panel1.Controls.Add(this.dateTimePickerEndTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerStartTime);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // buttonExportEbayCVS
            // 
            resources.ApplyResources(this.buttonExportEbayCVS, "buttonExportEbayCVS");
            this.buttonExportEbayCVS.Name = "buttonExportEbayCVS";
            this.buttonExportEbayCVS.UseVisualStyleBackColor = true;
            this.buttonExportEbayCVS.Click += new System.EventHandler(this.buttonExportEbayCVS_Click);
            // 
            // buttonExportSelectedToExcel
            // 
            resources.ApplyResources(this.buttonExportSelectedToExcel, "buttonExportSelectedToExcel");
            this.buttonExportSelectedToExcel.Name = "buttonExportSelectedToExcel";
            this.buttonExportSelectedToExcel.UseVisualStyleBackColor = true;
            this.buttonExportSelectedToExcel.Click += new System.EventHandler(this.buttonExportSelectedToExcel_Click);
            // 
            // buttonSyncEbayData
            // 
            this.buttonSyncEbayData.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.buttonSyncEbayData, "buttonSyncEbayData");
            this.buttonSyncEbayData.Name = "buttonSyncEbayData";
            this.buttonSyncEbayData.UseVisualStyleBackColor = false;
            this.buttonSyncEbayData.Click += new System.EventHandler(this.buttonSyncEbayData_Click);
            // 
            // dateTimePickerEndTime
            // 
            resources.ApplyResources(this.dateTimePickerEndTime, "dateTimePickerEndTime");
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dateTimePickerStartTime
            // 
            resources.ApplyResources(this.dateTimePickerStartTime, "dateTimePickerStartTime");
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            // 
            // tabControlEbayMaster
            // 
            this.tabControlEbayMaster.Controls.Add(this.tabPageOrder);
            this.tabControlEbayMaster.Controls.Add(this.tabPageSelling);
            this.tabControlEbayMaster.Controls.Add(this.tabPageMessages);
            this.tabControlEbayMaster.Controls.Add(this.tabPagePostSale);
            resources.ApplyResources(this.tabControlEbayMaster, "tabControlEbayMaster");
            this.tabControlEbayMaster.Name = "tabControlEbayMaster";
            this.tabControlEbayMaster.SelectedIndex = 0;
            this.tabControlEbayMaster.SelectedIndexChanged += new System.EventHandler(this.tabControlEbayMaster_SelectedIndexChanged);
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.Controls.Add(this.radioButtonDeliveredOrders);
            this.tabPageOrder.Controls.Add(this.radioButtonPendingOrders);
            this.tabPageOrder.Controls.Add(this.buttonOrderLastPage);
            this.tabPageOrder.Controls.Add(this.buttonOrderFirstPage);
            this.tabPageOrder.Controls.Add(this.labelOrderPage);
            this.tabPageOrder.Controls.Add(this.buttonOrderPrevPage);
            this.tabPageOrder.Controls.Add(this.buttonOrderNextPage);
            this.tabPageOrder.Controls.Add(this.panel2);
            this.tabPageOrder.Controls.Add(this.dataGridViewAllOrders);
            resources.ApplyResources(this.tabPageOrder, "tabPageOrder");
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // radioButtonDeliveredOrders
            // 
            resources.ApplyResources(this.radioButtonDeliveredOrders, "radioButtonDeliveredOrders");
            this.radioButtonDeliveredOrders.Name = "radioButtonDeliveredOrders";
            this.radioButtonDeliveredOrders.UseVisualStyleBackColor = true;
            this.radioButtonDeliveredOrders.CheckedChanged += new System.EventHandler(this.radioButtonOrders_CheckedChanged);
            // 
            // radioButtonPendingOrders
            // 
            resources.ApplyResources(this.radioButtonPendingOrders, "radioButtonPendingOrders");
            this.radioButtonPendingOrders.Checked = true;
            this.radioButtonPendingOrders.Name = "radioButtonPendingOrders";
            this.radioButtonPendingOrders.TabStop = true;
            this.radioButtonPendingOrders.UseVisualStyleBackColor = true;
            this.radioButtonPendingOrders.CheckedChanged += new System.EventHandler(this.radioButtonOrders_CheckedChanged);
            // 
            // buttonOrderLastPage
            // 
            resources.ApplyResources(this.buttonOrderLastPage, "buttonOrderLastPage");
            this.buttonOrderLastPage.Name = "buttonOrderLastPage";
            this.buttonOrderLastPage.UseVisualStyleBackColor = true;
            this.buttonOrderLastPage.Click += new System.EventHandler(this.buttonOrderLastPage_Click);
            // 
            // buttonOrderFirstPage
            // 
            resources.ApplyResources(this.buttonOrderFirstPage, "buttonOrderFirstPage");
            this.buttonOrderFirstPage.Name = "buttonOrderFirstPage";
            this.buttonOrderFirstPage.UseVisualStyleBackColor = true;
            this.buttonOrderFirstPage.Click += new System.EventHandler(this.buttonOrderFirstPage_Click);
            // 
            // labelOrderPage
            // 
            resources.ApplyResources(this.labelOrderPage, "labelOrderPage");
            this.labelOrderPage.Name = "labelOrderPage";
            // 
            // buttonOrderPrevPage
            // 
            resources.ApplyResources(this.buttonOrderPrevPage, "buttonOrderPrevPage");
            this.buttonOrderPrevPage.Name = "buttonOrderPrevPage";
            this.buttonOrderPrevPage.UseVisualStyleBackColor = true;
            this.buttonOrderPrevPage.Click += new System.EventHandler(this.buttonOrderPrevPage_Click);
            // 
            // buttonOrderNextPage
            // 
            resources.ApplyResources(this.buttonOrderNextPage, "buttonOrderNextPage");
            this.buttonOrderNextPage.Name = "buttonOrderNextPage";
            this.buttonOrderNextPage.UseVisualStyleBackColor = true;
            this.buttonOrderNextPage.Click += new System.EventHandler(this.buttonOrderNextPage_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightGreen;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // dataGridViewAllOrders
            // 
            this.dataGridViewAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewAllOrders, "dataGridViewAllOrders");
            this.dataGridViewAllOrders.Name = "dataGridViewAllOrders";
            this.dataGridViewAllOrders.RowTemplate.Height = 23;
            this.dataGridViewAllOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllOrders_CellClick);
            this.dataGridViewAllOrders.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewAllOrders_DataBindingComplete);
            this.dataGridViewAllOrders.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridViewAllOrders_MouseUp);
            // 
            // tabPageSelling
            // 
            this.tabPageSelling.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPageSelling, "tabPageSelling");
            this.tabPageSelling.Name = "tabPageSelling";
            this.tabPageSelling.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonListingLastPage);
            this.groupBox1.Controls.Add(this.buttonListingFirstPage);
            this.groupBox1.Controls.Add(this.labelListingPage);
            this.groupBox1.Controls.Add(this.buttonListingPrevPage);
            this.groupBox1.Controls.Add(this.buttonListingNextPage);
            this.groupBox1.Controls.Add(this.dataGridViewActiveListing);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // buttonListingLastPage
            // 
            resources.ApplyResources(this.buttonListingLastPage, "buttonListingLastPage");
            this.buttonListingLastPage.Name = "buttonListingLastPage";
            this.buttonListingLastPage.UseVisualStyleBackColor = true;
            this.buttonListingLastPage.Click += new System.EventHandler(this.buttonListingLastPage_Click);
            // 
            // buttonListingFirstPage
            // 
            resources.ApplyResources(this.buttonListingFirstPage, "buttonListingFirstPage");
            this.buttonListingFirstPage.Name = "buttonListingFirstPage";
            this.buttonListingFirstPage.UseVisualStyleBackColor = true;
            this.buttonListingFirstPage.Click += new System.EventHandler(this.buttonListingFirstPage_Click);
            // 
            // labelListingPage
            // 
            resources.ApplyResources(this.labelListingPage, "labelListingPage");
            this.labelListingPage.Name = "labelListingPage";
            // 
            // buttonListingPrevPage
            // 
            resources.ApplyResources(this.buttonListingPrevPage, "buttonListingPrevPage");
            this.buttonListingPrevPage.Name = "buttonListingPrevPage";
            this.buttonListingPrevPage.UseVisualStyleBackColor = true;
            this.buttonListingPrevPage.Click += new System.EventHandler(this.buttonListingPrevPage_Click);
            // 
            // buttonListingNextPage
            // 
            resources.ApplyResources(this.buttonListingNextPage, "buttonListingNextPage");
            this.buttonListingNextPage.Name = "buttonListingNextPage";
            this.buttonListingNextPage.UseVisualStyleBackColor = true;
            this.buttonListingNextPage.Click += new System.EventHandler(this.buttonListingNextPage_Click);
            // 
            // dataGridViewActiveListing
            // 
            this.dataGridViewActiveListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewActiveListing, "dataGridViewActiveListing");
            this.dataGridViewActiveListing.Name = "dataGridViewActiveListing";
            this.dataGridViewActiveListing.RowTemplate.Height = 23;
            this.dataGridViewActiveListing.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewActiveListing_DataBindingComplete);
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.pagedDgvMessages);
            this.tabPageMessages.Controls.Add(this.tabControlMessage);
            resources.ApplyResources(this.tabPageMessages, "tabPageMessages");
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // pagedDgvMessages
            // 
            resources.ApplyResources(this.pagedDgvMessages, "pagedDgvMessages");
            this.pagedDgvMessages.Name = "pagedDgvMessages";
            // 
            // tabControlMessage
            // 
            this.tabControlMessage.Controls.Add(this.tabPageAllMessage);
            resources.ApplyResources(this.tabControlMessage, "tabControlMessage");
            this.tabControlMessage.Name = "tabControlMessage";
            this.tabControlMessage.SelectedIndex = 0;
            // 
            // tabPageAllMessage
            // 
            resources.ApplyResources(this.tabPageAllMessage, "tabPageAllMessage");
            this.tabPageAllMessage.Name = "tabPageAllMessage";
            this.tabPageAllMessage.UseVisualStyleBackColor = true;
            // 
            // tabPagePostSale
            // 
            this.tabPagePostSale.Controls.Add(this.buttonPostSaleLastPage);
            this.tabPagePostSale.Controls.Add(this.buttonPostSaleFirstPage);
            this.tabPagePostSale.Controls.Add(this.labelPostSalePage);
            this.tabPagePostSale.Controls.Add(this.buttonPostSalePrevPage);
            this.tabPagePostSale.Controls.Add(this.buttonPostSaleNextPage);
            this.tabPagePostSale.Controls.Add(this.dataGridViewPostSale);
            this.tabPagePostSale.Controls.Add(this.panel3);
            resources.ApplyResources(this.tabPagePostSale, "tabPagePostSale");
            this.tabPagePostSale.Name = "tabPagePostSale";
            this.tabPagePostSale.UseVisualStyleBackColor = true;
            // 
            // buttonPostSaleLastPage
            // 
            resources.ApplyResources(this.buttonPostSaleLastPage, "buttonPostSaleLastPage");
            this.buttonPostSaleLastPage.Name = "buttonPostSaleLastPage";
            this.buttonPostSaleLastPage.UseVisualStyleBackColor = true;
            this.buttonPostSaleLastPage.Click += new System.EventHandler(this.buttonPostSaleLastPage_Click);
            // 
            // buttonPostSaleFirstPage
            // 
            resources.ApplyResources(this.buttonPostSaleFirstPage, "buttonPostSaleFirstPage");
            this.buttonPostSaleFirstPage.Name = "buttonPostSaleFirstPage";
            this.buttonPostSaleFirstPage.UseVisualStyleBackColor = true;
            this.buttonPostSaleFirstPage.Click += new System.EventHandler(this.buttonPostSaleFirstPage_Click);
            // 
            // labelPostSalePage
            // 
            resources.ApplyResources(this.labelPostSalePage, "labelPostSalePage");
            this.labelPostSalePage.Name = "labelPostSalePage";
            // 
            // buttonPostSalePrevPage
            // 
            resources.ApplyResources(this.buttonPostSalePrevPage, "buttonPostSalePrevPage");
            this.buttonPostSalePrevPage.Name = "buttonPostSalePrevPage";
            this.buttonPostSalePrevPage.UseVisualStyleBackColor = true;
            this.buttonPostSalePrevPage.Click += new System.EventHandler(this.buttonPostSalePrevPage_Click);
            // 
            // buttonPostSaleNextPage
            // 
            resources.ApplyResources(this.buttonPostSaleNextPage, "buttonPostSaleNextPage");
            this.buttonPostSaleNextPage.Name = "buttonPostSaleNextPage";
            this.buttonPostSaleNextPage.UseVisualStyleBackColor = true;
            this.buttonPostSaleNextPage.Click += new System.EventHandler(this.buttonPostSaleNextPage_Click);
            // 
            // dataGridViewPostSale
            // 
            this.dataGridViewPostSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewPostSale, "dataGridViewPostSale");
            this.dataGridViewPostSale.Name = "dataGridViewPostSale";
            this.dataGridViewPostSale.RowTemplate.Height = 23;
            this.dataGridViewPostSale.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPostSale_CellMouseDoubleClick);
            this.dataGridViewPostSale.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewPostSale_DataBindingComplete);
            this.dataGridViewPostSale.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPostSale_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label21);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Goldenrod;
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.LightGreen;
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // contextMenuStripPostSale
            // 
            this.contextMenuStripPostSale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemViewMessage,
            this.ToolStripMenuItemSendMessageToBuyer});
            this.contextMenuStripPostSale.Name = "contextMenuStripPostSale";
            resources.ApplyResources(this.contextMenuStripPostSale, "contextMenuStripPostSale");
            this.contextMenuStripPostSale.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripPostSale_Opening);
            // 
            // ToolStripMenuItemViewMessage
            // 
            this.ToolStripMenuItemViewMessage.Name = "ToolStripMenuItemViewMessage";
            resources.ApplyResources(this.ToolStripMenuItemViewMessage, "ToolStripMenuItemViewMessage");
            this.ToolStripMenuItemViewMessage.Click += new System.EventHandler(this.ToolStripMenuItemViewMessage_Click);
            // 
            // ToolStripMenuItemSendMessageToBuyer
            // 
            this.ToolStripMenuItemSendMessageToBuyer.Name = "ToolStripMenuItemSendMessageToBuyer";
            resources.ApplyResources(this.ToolStripMenuItemSendMessageToBuyer, "ToolStripMenuItemSendMessageToBuyer");
            this.ToolStripMenuItemSendMessageToBuyer.Click += new System.EventHandler(this.ToolStripMenuItemSendMessageToBuyer_Click);
            // 
            // menuStripEbayMaster
            // 
            this.menuStripEbayMaster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSourcingAndDispatching,
            this.ToolStripMenuItemItemMenu,
            this.ToolStripMenuItemSystemSettings,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            resources.ApplyResources(this.menuStripEbayMaster, "menuStripEbayMaster");
            this.menuStripEbayMaster.Name = "menuStripEbayMaster";
            // 
            // ToolStripMenuItemItemMenu
            // 
            this.ToolStripMenuItemItemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCategory,
            this.ToolStripMenuItemItem,
            this.ToolStripMenuItemGroupItem,
            this.ToolStripMenuItemViewItemStat,
            this.ToolStripMenuItemCreateSupplier,
            this.ToolStripMenuItemViewSupplier,
            this.ToolStripMenuItemCreateSourcingNote,
            this.ToolStripMenuItemViewSourcingNote});
            this.ToolStripMenuItemItemMenu.Name = "ToolStripMenuItemItemMenu";
            resources.ApplyResources(this.ToolStripMenuItemItemMenu, "ToolStripMenuItemItemMenu");
            // 
            // ToolStripMenuItemCategory
            // 
            this.ToolStripMenuItemCategory.Name = "ToolStripMenuItemCategory";
            resources.ApplyResources(this.ToolStripMenuItemCategory, "ToolStripMenuItemCategory");
            this.ToolStripMenuItemCategory.Click += new System.EventHandler(this.ToolStripMenuItemCategory_Click);
            // 
            // ToolStripMenuItemItem
            // 
            this.ToolStripMenuItemItem.Name = "ToolStripMenuItemItem";
            resources.ApplyResources(this.ToolStripMenuItemItem, "ToolStripMenuItemItem");
            this.ToolStripMenuItemItem.Click += new System.EventHandler(this.ToolStripMenuItemItem_Click);
            // 
            // ToolStripMenuItemGroupItem
            // 
            this.ToolStripMenuItemGroupItem.Name = "ToolStripMenuItemGroupItem";
            resources.ApplyResources(this.ToolStripMenuItemGroupItem, "ToolStripMenuItemGroupItem");
            // 
            // ToolStripMenuItemViewItemStat
            // 
            this.ToolStripMenuItemViewItemStat.Name = "ToolStripMenuItemViewItemStat";
            resources.ApplyResources(this.ToolStripMenuItemViewItemStat, "ToolStripMenuItemViewItemStat");
            this.ToolStripMenuItemViewItemStat.Click += new System.EventHandler(this.ToolStripMenuItemViewItemStat_Click);
            // 
            // ToolStripMenuItemCreateSupplier
            // 
            this.ToolStripMenuItemCreateSupplier.Name = "ToolStripMenuItemCreateSupplier";
            resources.ApplyResources(this.ToolStripMenuItemCreateSupplier, "ToolStripMenuItemCreateSupplier");
            this.ToolStripMenuItemCreateSupplier.Click += new System.EventHandler(this.ToolStripMenuItemCreateSupplier_Click);
            // 
            // ToolStripMenuItemViewSupplier
            // 
            this.ToolStripMenuItemViewSupplier.Name = "ToolStripMenuItemViewSupplier";
            resources.ApplyResources(this.ToolStripMenuItemViewSupplier, "ToolStripMenuItemViewSupplier");
            this.ToolStripMenuItemViewSupplier.Click += new System.EventHandler(this.ToolStripMenuItemViewSupplier_Click);
            // 
            // ToolStripMenuItemCreateSourcingNote
            // 
            this.ToolStripMenuItemCreateSourcingNote.Name = "ToolStripMenuItemCreateSourcingNote";
            resources.ApplyResources(this.ToolStripMenuItemCreateSourcingNote, "ToolStripMenuItemCreateSourcingNote");
            this.ToolStripMenuItemCreateSourcingNote.Click += new System.EventHandler(this.ToolStripMenuItemCreateSourcingNote_Click);
            // 
            // ToolStripMenuItemViewSourcingNote
            // 
            this.ToolStripMenuItemViewSourcingNote.Name = "ToolStripMenuItemViewSourcingNote";
            resources.ApplyResources(this.ToolStripMenuItemViewSourcingNote, "ToolStripMenuItemViewSourcingNote");
            this.ToolStripMenuItemViewSourcingNote.Click += new System.EventHandler(this.ToolStripMenuItemViewSourcingNote_Click);
            // 
            // ToolStripMenuItemSourcingAndDispatching
            // 
            this.ToolStripMenuItemSourcingAndDispatching.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCreateItemStockInNote,
            this.ToolStripMenuItemViewItemStockInNote,
            this.ToolStripMenuItemCreateDeliveryNote,
            this.ToolStripMenuItemViewDeliveryNote});
            this.ToolStripMenuItemSourcingAndDispatching.Name = "ToolStripMenuItemSourcingAndDispatching";
            resources.ApplyResources(this.ToolStripMenuItemSourcingAndDispatching, "ToolStripMenuItemSourcingAndDispatching");
            // 
            // ToolStripMenuItemCreateItemStockInNote
            // 
            this.ToolStripMenuItemCreateItemStockInNote.Name = "ToolStripMenuItemCreateItemStockInNote";
            resources.ApplyResources(this.ToolStripMenuItemCreateItemStockInNote, "ToolStripMenuItemCreateItemStockInNote");
            this.ToolStripMenuItemCreateItemStockInNote.Click += new System.EventHandler(this.ToolStripMenuItemCreateItemStockInNote_Click);
            // 
            // ToolStripMenuItemViewItemStockInNote
            // 
            this.ToolStripMenuItemViewItemStockInNote.Name = "ToolStripMenuItemViewItemStockInNote";
            resources.ApplyResources(this.ToolStripMenuItemViewItemStockInNote, "ToolStripMenuItemViewItemStockInNote");
            this.ToolStripMenuItemViewItemStockInNote.Click += new System.EventHandler(this.ToolStripMenuItemViewItemStockInNote_Click);
            // 
            // ToolStripMenuItemCreateDeliveryNote
            // 
            this.ToolStripMenuItemCreateDeliveryNote.Name = "ToolStripMenuItemCreateDeliveryNote";
            resources.ApplyResources(this.ToolStripMenuItemCreateDeliveryNote, "ToolStripMenuItemCreateDeliveryNote");
            this.ToolStripMenuItemCreateDeliveryNote.Click += new System.EventHandler(this.ToolStripMenuItemDeliveryNote_Click);
            // 
            // ToolStripMenuItemViewDeliveryNote
            // 
            this.ToolStripMenuItemViewDeliveryNote.Name = "ToolStripMenuItemViewDeliveryNote";
            resources.ApplyResources(this.ToolStripMenuItemViewDeliveryNote, "ToolStripMenuItemViewDeliveryNote");
            this.ToolStripMenuItemViewDeliveryNote.Click += new System.EventHandler(this.ToolStripMenuItemViewDeliveryNote_Click);
            // 
            // ToolStripMenuItemSystemSettings
            // 
            this.ToolStripMenuItemSystemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDBConnSettings,
            this.ToolStripMenuItemAccountSettings,
            this.ToolStripMenuItemMessageTemplate});
            this.ToolStripMenuItemSystemSettings.Name = "ToolStripMenuItemSystemSettings";
            resources.ApplyResources(this.ToolStripMenuItemSystemSettings, "ToolStripMenuItemSystemSettings");
            // 
            // ToolStripMenuItemDBConnSettings
            // 
            this.ToolStripMenuItemDBConnSettings.Name = "ToolStripMenuItemDBConnSettings";
            resources.ApplyResources(this.ToolStripMenuItemDBConnSettings, "ToolStripMenuItemDBConnSettings");
            this.ToolStripMenuItemDBConnSettings.Click += new System.EventHandler(this.ToolStripMenuItemDBConnSettings_Click);
            // 
            // ToolStripMenuItemAccountSettings
            // 
            this.ToolStripMenuItemAccountSettings.Name = "ToolStripMenuItemAccountSettings";
            resources.ApplyResources(this.ToolStripMenuItemAccountSettings, "ToolStripMenuItemAccountSettings");
            this.ToolStripMenuItemAccountSettings.Click += new System.EventHandler(this.ToolStripMenuItemAccountSettings_Click);
            // 
            // ToolStripMenuItemMessageTemplate
            // 
            this.ToolStripMenuItemMessageTemplate.Name = "ToolStripMenuItemMessageTemplate";
            resources.ApplyResources(this.ToolStripMenuItemMessageTemplate, "ToolStripMenuItemMessageTemplate");
            this.ToolStripMenuItemMessageTemplate.Click += new System.EventHandler(this.ToolStripMenuItemMessageTemplate_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemEbayFees});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            resources.ApplyResources(this.工具ToolStripMenuItem, "工具ToolStripMenuItem");
            // 
            // ToolStripMenuItemEbayFees
            // 
            this.ToolStripMenuItemEbayFees.Name = "ToolStripMenuItemEbayFees";
            resources.ApplyResources(this.ToolStripMenuItemEbayFees, "ToolStripMenuItemEbayFees");
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAbout});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            resources.ApplyResources(this.帮助ToolStripMenuItem, "帮助ToolStripMenuItem");
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            resources.ApplyResources(this.ToolStripMenuItemAbout, "ToolStripMenuItemAbout");
            this.ToolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAbout_Click);
            // 
            // contextMenuStripMessage
            // 
            this.contextMenuStripMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemReplyMessage});
            this.contextMenuStripMessage.Name = "contextMenuStripPostSale";
            resources.ApplyResources(this.contextMenuStripMessage, "contextMenuStripMessage");
            // 
            // toolStripMenuItemReplyMessage
            // 
            this.toolStripMenuItemReplyMessage.Name = "toolStripMenuItemReplyMessage";
            resources.ApplyResources(this.toolStripMenuItemReplyMessage, "toolStripMenuItemReplyMessage");
            // 
            // contextMenuStripTransaction
            // 
            this.contextMenuStripTransaction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemViewTransactionDetail,
            this.ToolStripMenuItemViewTransactionMessage,
            this.ToolStripMenuItemSendMessage,
            this.ToolStripMenuItemAddRelationToItem,
            this.ToolStripMenuItemViewItem,
            this.ToolStripMenuItemSelectShippingService,
            this.ToolStripMenuItemMarkAsShipped,
            this.ToolStripMenuItemUploadTrackingNum,
            this.ToolStripMenuItemLeaveFeedback,
            this.ToolStripMenuItemSetShippingCost,
            this.ToolStripMenuItemCreateDeliveryNoteFromOrders,
            this.ToolStripMenuItemMergeOrders});
            this.contextMenuStripTransaction.Name = "contextMenuStripTransaction";
            resources.ApplyResources(this.contextMenuStripTransaction, "contextMenuStripTransaction");
            this.contextMenuStripTransaction.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTransaction_Opening);
            // 
            // ToolStripMenuItemViewTransactionDetail
            // 
            this.ToolStripMenuItemViewTransactionDetail.Name = "ToolStripMenuItemViewTransactionDetail";
            resources.ApplyResources(this.ToolStripMenuItemViewTransactionDetail, "ToolStripMenuItemViewTransactionDetail");
            // 
            // ToolStripMenuItemViewTransactionMessage
            // 
            this.ToolStripMenuItemViewTransactionMessage.Name = "ToolStripMenuItemViewTransactionMessage";
            resources.ApplyResources(this.ToolStripMenuItemViewTransactionMessage, "ToolStripMenuItemViewTransactionMessage");
            // 
            // ToolStripMenuItemSendMessage
            // 
            this.ToolStripMenuItemSendMessage.Name = "ToolStripMenuItemSendMessage";
            resources.ApplyResources(this.ToolStripMenuItemSendMessage, "ToolStripMenuItemSendMessage");
            // 
            // ToolStripMenuItemAddRelationToItem
            // 
            this.ToolStripMenuItemAddRelationToItem.Name = "ToolStripMenuItemAddRelationToItem";
            resources.ApplyResources(this.ToolStripMenuItemAddRelationToItem, "ToolStripMenuItemAddRelationToItem");
            this.ToolStripMenuItemAddRelationToItem.Click += new System.EventHandler(this.ToolStripMenuItemAddRelationToItem_Click);
            // 
            // ToolStripMenuItemViewItem
            // 
            this.ToolStripMenuItemViewItem.Name = "ToolStripMenuItemViewItem";
            resources.ApplyResources(this.ToolStripMenuItemViewItem, "ToolStripMenuItemViewItem");
            // 
            // ToolStripMenuItemSelectShippingService
            // 
            this.ToolStripMenuItemSelectShippingService.Name = "ToolStripMenuItemSelectShippingService";
            resources.ApplyResources(this.ToolStripMenuItemSelectShippingService, "ToolStripMenuItemSelectShippingService");
            this.ToolStripMenuItemSelectShippingService.Click += new System.EventHandler(this.ToolStripMenuItemSelectShippingService_Click);
            // 
            // ToolStripMenuItemMarkAsShipped
            // 
            this.ToolStripMenuItemMarkAsShipped.Name = "ToolStripMenuItemMarkAsShipped";
            resources.ApplyResources(this.ToolStripMenuItemMarkAsShipped, "ToolStripMenuItemMarkAsShipped");
            this.ToolStripMenuItemMarkAsShipped.Click += new System.EventHandler(this.ToolStripMenuItemMarkAsShipped_Click);
            // 
            // ToolStripMenuItemUploadTrackingNum
            // 
            this.ToolStripMenuItemUploadTrackingNum.Name = "ToolStripMenuItemUploadTrackingNum";
            resources.ApplyResources(this.ToolStripMenuItemUploadTrackingNum, "ToolStripMenuItemUploadTrackingNum");
            this.ToolStripMenuItemUploadTrackingNum.Click += new System.EventHandler(this.ToolStripMenuItemUploadTrackingNum_Click);
            // 
            // ToolStripMenuItemLeaveFeedback
            // 
            this.ToolStripMenuItemLeaveFeedback.Name = "ToolStripMenuItemLeaveFeedback";
            resources.ApplyResources(this.ToolStripMenuItemLeaveFeedback, "ToolStripMenuItemLeaveFeedback");
            this.ToolStripMenuItemLeaveFeedback.Click += new System.EventHandler(this.ToolStripMenuItemLeaveFeedback_Click);
            // 
            // ToolStripMenuItemSetShippingCost
            // 
            this.ToolStripMenuItemSetShippingCost.Name = "ToolStripMenuItemSetShippingCost";
            resources.ApplyResources(this.ToolStripMenuItemSetShippingCost, "ToolStripMenuItemSetShippingCost");
            // 
            // ToolStripMenuItemCreateDeliveryNoteFromOrders
            // 
            this.ToolStripMenuItemCreateDeliveryNoteFromOrders.Name = "ToolStripMenuItemCreateDeliveryNoteFromOrders";
            resources.ApplyResources(this.ToolStripMenuItemCreateDeliveryNoteFromOrders, "ToolStripMenuItemCreateDeliveryNoteFromOrders");
            this.ToolStripMenuItemCreateDeliveryNoteFromOrders.Click += new System.EventHandler(this.ToolStripMenuItemCreateDeliveryNoteFromOrders_Click);
            // 
            // ToolStripMenuItemMergeOrders
            // 
            this.ToolStripMenuItemMergeOrders.Name = "ToolStripMenuItemMergeOrders";
            resources.ApplyResources(this.ToolStripMenuItemMergeOrders, "ToolStripMenuItemMergeOrders");
            this.ToolStripMenuItemMergeOrders.Click += new System.EventHandler(this.ToolStripMenuItemMergeOrders_Click);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStripEbayMaster);
            this.Controls.Add(this.tabControlEbayMaster);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlEbayMaster.ResumeLayout(false);
            this.tabPageOrder.ResumeLayout(false);
            this.tabPageOrder.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllOrders)).EndInit();
            this.tabPageSelling.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveListing)).EndInit();
            this.tabPageMessages.ResumeLayout(false);
            this.tabControlMessage.ResumeLayout(false);
            this.tabPagePostSale.ResumeLayout(false);
            this.tabPagePostSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostSale)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.contextMenuStripPostSale.ResumeLayout(false);
            this.menuStripEbayMaster.ResumeLayout(false);
            this.menuStripEbayMaster.PerformLayout();
            this.contextMenuStripMessage.ResumeLayout(false);
            this.contextMenuStripTransaction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSyncEbayData;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.TabControl tabControlEbayMaster;
        private System.Windows.Forms.TabPage tabPageSelling;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelListingPage;
        private System.Windows.Forms.Button buttonListingPrevPage;
        private System.Windows.Forms.Button buttonListingNextPage;
        private System.Windows.Forms.DataGridView dataGridViewActiveListing;
        private System.Windows.Forms.TabPage tabPageOrder;
        private System.Windows.Forms.Label labelOrderPage;
        private System.Windows.Forms.Button buttonOrderPrevPage;
        private System.Windows.Forms.Button buttonOrderNextPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewAllOrders;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.TabControl tabControlMessage;
        private System.Windows.Forms.TabPage tabPageAllMessage;
        private System.Windows.Forms.TabPage tabPagePostSale;
        private System.Windows.Forms.DataGridView dataGridViewPostSale;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonOrderLastPage;
        private System.Windows.Forms.Button buttonOrderFirstPage;
        private System.Windows.Forms.Button buttonPostSaleLastPage;
        private System.Windows.Forms.Button buttonPostSaleFirstPage;
        private System.Windows.Forms.Label labelPostSalePage;
        private System.Windows.Forms.Button buttonPostSalePrevPage;
        private System.Windows.Forms.Button buttonPostSaleNextPage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPostSale;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemViewMessage;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSendMessageToBuyer;
        private System.Windows.Forms.MenuStrip menuStripEbayMaster;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemItemMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCategory;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGroupItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemViewItemStat;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSourcingAndDispatching;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCreateItemStockInNote;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSystemSettings;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDBConnSettings;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEbayFees;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMessage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReplyMessage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTransaction;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemViewTransactionDetail;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemViewTransactionMessage;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSendMessage;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddRelationToItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemViewItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSelectShippingService;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMarkAsShipped;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUploadTrackingNum;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLeaveFeedback;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSetShippingCost;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMessageTemplate;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCreateDeliveryNote;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemViewDeliveryNote;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCreateDeliveryNoteFromOrders;
        private System.Windows.Forms.RadioButton radioButtonDeliveredOrders;
        private System.Windows.Forms.RadioButton radioButtonPendingOrders;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemViewItemStockInNote;
        private System.Windows.Forms.Button buttonExportSelectedToExcel;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
        private System.Windows.Forms.Button buttonListingLastPage;
        private System.Windows.Forms.Button buttonListingFirstPage;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCreateSupplier;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemViewSupplier;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCreateSourcingNote;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMergeOrders;
        private PagedDataGridView pagedDgvMessages;
        private System.Windows.Forms.Button buttonExportEbayCVS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemViewSourcingNote;
    }
}

