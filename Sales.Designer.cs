namespace Nguyen_Xuan_Tuan_Linh_BH02990_SE08301_Database_ASM_Final
{
    partial class Sales
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
            pnMenu = new Panel();
            btnInvoiceHistory = new Button();
            btnManageCustomers = new Button();
            btnSale = new Button();
            pnContentImportHistory = new Panel();
            panel1 = new Panel();
            lbSearchImportHistory = new Label();
            pnSalesContent = new Panel();
            btnCheckOutSales = new Button();
            btnRefreshSale = new Button();
            lbChooseCustomer = new Label();
            cbbChooseCustomer = new ComboBox();
            lbTotalMoney = new Label();
            lbStaffName = new Label();
            dtgCart = new DataGridView();
            btnAddToCart = new Button();
            txtQuantityProductSale = new Label();
            tbProductQuantitySale = new TextBox();
            dtgSaleProduct = new DataGridView();
            pnSalerManageCustomers = new Panel();
            txtSearch = new Label();
            txtGender = new Label();
            txtCustomerMail = new Label();
            txtCustomerAddress = new Label();
            txtCustomerPhoneNumber = new Label();
            txtCustomerName = new Label();
            btnRefreshCustomerInfo = new Button();
            btnDeleteCustomer = new Button();
            btnClearCustomer = new Button();
            btnAddCustomer = new Button();
            btnEditCustomer = new Button();
            btnOkToSearchInfoCustomer = new Button();
            tbSearchInfoCustomer = new TextBox();
            dtgInfoCustomer = new DataGridView();
            cbbCustomerGender = new ComboBox();
            tbCustomerAddress = new TextBox();
            tbCustomerMail = new TextBox();
            tbCustomerPhoneNumber = new TextBox();
            tbCustomerName = new TextBox();
            panel2 = new Panel();
            pnSalesInvoiceHistory = new Panel();
            btnSearchInvoiceHistory = new Button();
            tbSearchInvoiceHistory = new TextBox();
            dtgInvoiceHistory = new DataGridView();
            pnInvoiceHistory = new Panel();
            lbInvoiceHistory = new Label();
            pnMenu.SuspendLayout();
            pnContentImportHistory.SuspendLayout();
            pnSalesContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgSaleProduct).BeginInit();
            pnSalerManageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgInfoCustomer).BeginInit();
            pnSalesInvoiceHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgInvoiceHistory).BeginInit();
            pnInvoiceHistory.SuspendLayout();
            SuspendLayout();
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.FromArgb(25, 25, 35);
            pnMenu.Controls.Add(btnInvoiceHistory);
            pnMenu.Controls.Add(btnManageCustomers);
            pnMenu.Controls.Add(btnSale);
            pnMenu.Dock = DockStyle.Left;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(200, 450);
            pnMenu.TabIndex = 1;
            // 
            // btnInvoiceHistory
            // 
            btnInvoiceHistory.Dock = DockStyle.Top;
            btnInvoiceHistory.FlatStyle = FlatStyle.Flat;
            btnInvoiceHistory.ForeColor = SystemColors.ButtonFace;
            btnInvoiceHistory.Location = new Point(0, 46);
            btnInvoiceHistory.Name = "btnInvoiceHistory";
            btnInvoiceHistory.Size = new Size(200, 23);
            btnInvoiceHistory.TabIndex = 5;
            btnInvoiceHistory.Text = "Invoice History";
            btnInvoiceHistory.UseVisualStyleBackColor = true;
            btnInvoiceHistory.Click += btnInvoiceHistory_Click;
            // 
            // btnManageCustomers
            // 
            btnManageCustomers.Dock = DockStyle.Top;
            btnManageCustomers.FlatStyle = FlatStyle.Flat;
            btnManageCustomers.ForeColor = SystemColors.ButtonFace;
            btnManageCustomers.Location = new Point(0, 23);
            btnManageCustomers.Name = "btnManageCustomers";
            btnManageCustomers.Size = new Size(200, 23);
            btnManageCustomers.TabIndex = 2;
            btnManageCustomers.Text = "Manage Customers";
            btnManageCustomers.UseVisualStyleBackColor = true;
            btnManageCustomers.Click += btnManageCustomers_Click;
            // 
            // btnSale
            // 
            btnSale.Dock = DockStyle.Top;
            btnSale.FlatStyle = FlatStyle.Flat;
            btnSale.ForeColor = SystemColors.ButtonFace;
            btnSale.Location = new Point(0, 0);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(200, 23);
            btnSale.TabIndex = 1;
            btnSale.Text = "Sales";
            btnSale.UseVisualStyleBackColor = true;
            btnSale.Click += btnSale_Click;
            // 
            // pnContentImportHistory
            // 
            pnContentImportHistory.Controls.Add(panel1);
            pnContentImportHistory.Controls.Add(lbSearchImportHistory);
            pnContentImportHistory.Dock = DockStyle.Fill;
            pnContentImportHistory.Location = new Point(200, 0);
            pnContentImportHistory.Name = "pnContentImportHistory";
            pnContentImportHistory.Size = new Size(600, 450);
            pnContentImportHistory.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 450);
            panel1.TabIndex = 10;
            // 
            // lbSearchImportHistory
            // 
            lbSearchImportHistory.AutoSize = true;
            lbSearchImportHistory.ForeColor = SystemColors.ButtonFace;
            lbSearchImportHistory.Location = new Point(90, 165);
            lbSearchImportHistory.Name = "lbSearchImportHistory";
            lbSearchImportHistory.Size = new Size(122, 15);
            lbSearchImportHistory.TabIndex = 2;
            lbSearchImportHistory.Text = "Search Import History";
            // 
            // pnSalesContent
            // 
            pnSalesContent.BackColor = Color.FromArgb(34, 36, 49);
            pnSalesContent.Controls.Add(btnCheckOutSales);
            pnSalesContent.Controls.Add(btnRefreshSale);
            pnSalesContent.Controls.Add(lbChooseCustomer);
            pnSalesContent.Controls.Add(cbbChooseCustomer);
            pnSalesContent.Controls.Add(lbTotalMoney);
            pnSalesContent.Controls.Add(lbStaffName);
            pnSalesContent.Controls.Add(dtgCart);
            pnSalesContent.Controls.Add(btnAddToCart);
            pnSalesContent.Controls.Add(txtQuantityProductSale);
            pnSalesContent.Controls.Add(tbProductQuantitySale);
            pnSalesContent.Controls.Add(dtgSaleProduct);
            pnSalesContent.Dock = DockStyle.Fill;
            pnSalesContent.Location = new Point(200, 0);
            pnSalesContent.Name = "pnSalesContent";
            pnSalesContent.Size = new Size(600, 450);
            pnSalesContent.TabIndex = 5;
            // 
            // btnCheckOutSales
            // 
            btnCheckOutSales.Location = new Point(136, 272);
            btnCheckOutSales.Name = "btnCheckOutSales";
            btnCheckOutSales.Size = new Size(75, 23);
            btnCheckOutSales.TabIndex = 21;
            btnCheckOutSales.Text = "Check Out";
            btnCheckOutSales.UseVisualStyleBackColor = true;
            btnCheckOutSales.Click += btnCheckOutSales_Click_1;
            // 
            // btnRefreshSale
            // 
            btnRefreshSale.Location = new Point(72, 272);
            btnRefreshSale.Name = "btnRefreshSale";
            btnRefreshSale.Size = new Size(54, 23);
            btnRefreshSale.TabIndex = 20;
            btnRefreshSale.Text = "Refresh";
            btnRefreshSale.UseVisualStyleBackColor = true;
            btnRefreshSale.Click += btnRefreshSale_Click_1;
            // 
            // lbChooseCustomer
            // 
            lbChooseCustomer.AutoSize = true;
            lbChooseCustomer.ForeColor = SystemColors.ButtonFace;
            lbChooseCustomer.Location = new Point(21, 240);
            lbChooseCustomer.Name = "lbChooseCustomer";
            lbChooseCustomer.Size = new Size(65, 15);
            lbChooseCustomer.TabIndex = 19;
            lbChooseCustomer.Text = "Customer: ";
            // 
            // cbbChooseCustomer
            // 
            cbbChooseCustomer.FormattingEnabled = true;
            cbbChooseCustomer.Location = new Point(90, 237);
            cbbChooseCustomer.Name = "cbbChooseCustomer";
            cbbChooseCustomer.Size = new Size(121, 23);
            cbbChooseCustomer.TabIndex = 18;
            // 
            // lbTotalMoney
            // 
            lbTotalMoney.AutoSize = true;
            lbTotalMoney.ForeColor = SystemColors.ButtonFace;
            lbTotalMoney.Location = new Point(550, 356);
            lbTotalMoney.Name = "lbTotalMoney";
            lbTotalMoney.Size = new Size(38, 15);
            lbTotalMoney.TabIndex = 17;
            lbTotalMoney.Text = "label2";
            // 
            // lbStaffName
            // 
            lbStaffName.AutoSize = true;
            lbStaffName.ForeColor = SystemColors.ButtonFace;
            lbStaffName.Location = new Point(21, 5);
            lbStaffName.Name = "lbStaffName";
            lbStaffName.Size = new Size(38, 15);
            lbStaffName.TabIndex = 16;
            lbStaffName.Text = "label1";
            // 
            // dtgCart
            // 
            dtgCart.AllowUserToAddRows = false;
            dtgCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCart.Location = new Point(348, 200);
            dtgCart.Name = "dtgCart";
            dtgCart.Size = new Size(240, 150);
            dtgCart.TabIndex = 15;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(21, 272);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(41, 23);
            btnAddToCart.TabIndex = 14;
            btnAddToCart.Text = "Add";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click_1;
            // 
            // txtQuantityProductSale
            // 
            txtQuantityProductSale.AutoSize = true;
            txtQuantityProductSale.ForeColor = SystemColors.ButtonFace;
            txtQuantityProductSale.Location = new Point(21, 208);
            txtQuantityProductSale.Name = "txtQuantityProductSale";
            txtQuantityProductSale.Size = new Size(59, 15);
            txtQuantityProductSale.TabIndex = 13;
            txtQuantityProductSale.Text = "Quantity: ";
            // 
            // tbProductQuantitySale
            // 
            tbProductQuantitySale.Location = new Point(90, 205);
            tbProductQuantitySale.Name = "tbProductQuantitySale";
            tbProductQuantitySale.Size = new Size(121, 23);
            tbProductQuantitySale.TabIndex = 12;
            // 
            // dtgSaleProduct
            // 
            dtgSaleProduct.AllowUserToAddRows = false;
            dtgSaleProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSaleProduct.Location = new Point(21, 23);
            dtgSaleProduct.Name = "dtgSaleProduct";
            dtgSaleProduct.Size = new Size(567, 171);
            dtgSaleProduct.TabIndex = 11;
            // 
            // pnSalerManageCustomers
            // 
            pnSalerManageCustomers.Controls.Add(txtSearch);
            pnSalerManageCustomers.Controls.Add(txtGender);
            pnSalerManageCustomers.Controls.Add(txtCustomerMail);
            pnSalerManageCustomers.Controls.Add(txtCustomerAddress);
            pnSalerManageCustomers.Controls.Add(txtCustomerPhoneNumber);
            pnSalerManageCustomers.Controls.Add(txtCustomerName);
            pnSalerManageCustomers.Controls.Add(btnRefreshCustomerInfo);
            pnSalerManageCustomers.Controls.Add(btnDeleteCustomer);
            pnSalerManageCustomers.Controls.Add(btnClearCustomer);
            pnSalerManageCustomers.Controls.Add(btnAddCustomer);
            pnSalerManageCustomers.Controls.Add(btnEditCustomer);
            pnSalerManageCustomers.Controls.Add(btnOkToSearchInfoCustomer);
            pnSalerManageCustomers.Controls.Add(tbSearchInfoCustomer);
            pnSalerManageCustomers.Controls.Add(dtgInfoCustomer);
            pnSalerManageCustomers.Controls.Add(cbbCustomerGender);
            pnSalerManageCustomers.Controls.Add(tbCustomerAddress);
            pnSalerManageCustomers.Controls.Add(tbCustomerMail);
            pnSalerManageCustomers.Controls.Add(tbCustomerPhoneNumber);
            pnSalerManageCustomers.Controls.Add(tbCustomerName);
            pnSalerManageCustomers.Controls.Add(panel2);
            pnSalerManageCustomers.Dock = DockStyle.Fill;
            pnSalerManageCustomers.Location = new Point(200, 0);
            pnSalerManageCustomers.Name = "pnSalerManageCustomers";
            pnSalerManageCustomers.Size = new Size(600, 450);
            pnSalerManageCustomers.TabIndex = 22;
            // 
            // txtSearch
            // 
            txtSearch.AutoSize = true;
            txtSearch.BackColor = Color.FromArgb(34, 36, 49);
            txtSearch.ForeColor = SystemColors.ButtonFace;
            txtSearch.Location = new Point(21, 232);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(48, 15);
            txtSearch.TabIndex = 30;
            txtSearch.Text = "Search: ";
            // 
            // txtGender
            // 
            txtGender.AutoSize = true;
            txtGender.BackColor = Color.FromArgb(34, 36, 49);
            txtGender.ForeColor = SystemColors.ButtonFace;
            txtGender.Location = new Point(13, 150);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(51, 15);
            txtGender.TabIndex = 27;
            txtGender.Text = "Gender: ";
            // 
            // txtCustomerMail
            // 
            txtCustomerMail.AutoSize = true;
            txtCustomerMail.BackColor = Color.FromArgb(34, 36, 49);
            txtCustomerMail.ForeColor = SystemColors.ButtonFace;
            txtCustomerMail.Location = new Point(13, 121);
            txtCustomerMail.Name = "txtCustomerMail";
            txtCustomerMail.Size = new Size(36, 15);
            txtCustomerMail.TabIndex = 20;
            txtCustomerMail.Text = "Mail: ";
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.AutoSize = true;
            txtCustomerAddress.BackColor = Color.FromArgb(34, 36, 49);
            txtCustomerAddress.ForeColor = SystemColors.ButtonFace;
            txtCustomerAddress.Location = new Point(13, 88);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(110, 15);
            txtCustomerAddress.TabIndex = 21;
            txtCustomerAddress.Text = "Customer Address: ";
            // 
            // txtCustomerPhoneNumber
            // 
            txtCustomerPhoneNumber.AutoSize = true;
            txtCustomerPhoneNumber.BackColor = Color.FromArgb(34, 36, 49);
            txtCustomerPhoneNumber.ForeColor = SystemColors.ButtonFace;
            txtCustomerPhoneNumber.Location = new Point(13, 56);
            txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            txtCustomerPhoneNumber.Size = new Size(149, 15);
            txtCustomerPhoneNumber.TabIndex = 22;
            txtCustomerPhoneNumber.Text = "Customer Phone Number: ";
            // 
            // txtCustomerName
            // 
            txtCustomerName.AutoSize = true;
            txtCustomerName.BackColor = Color.FromArgb(34, 36, 49);
            txtCustomerName.ForeColor = SystemColors.ButtonFace;
            txtCustomerName.Location = new Point(13, 26);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(100, 15);
            txtCustomerName.TabIndex = 19;
            txtCustomerName.Text = "Customer Name: ";
            // 
            // btnRefreshCustomerInfo
            // 
            btnRefreshCustomerInfo.Location = new Point(315, 228);
            btnRefreshCustomerInfo.Name = "btnRefreshCustomerInfo";
            btnRefreshCustomerInfo.Size = new Size(75, 23);
            btnRefreshCustomerInfo.TabIndex = 37;
            btnRefreshCustomerInfo.Text = "Refresh";
            btnRefreshCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(104, 175);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(56, 23);
            btnDeleteCustomer.TabIndex = 36;
            btnDeleteCustomer.Text = "Delete";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnClearCustomer
            // 
            btnClearCustomer.Location = new Point(166, 175);
            btnClearCustomer.Name = "btnClearCustomer";
            btnClearCustomer.Size = new Size(43, 23);
            btnClearCustomer.TabIndex = 35;
            btnClearCustomer.Text = "Clear";
            btnClearCustomer.UseVisualStyleBackColor = true;
            btnClearCustomer.Click += btnClearCustomer_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(13, 175);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(43, 23);
            btnAddCustomer.TabIndex = 34;
            btnAddCustomer.Text = "ADD";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Location = new Point(62, 175);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(36, 23);
            btnEditCustomer.TabIndex = 33;
            btnEditCustomer.Text = "Edit";
            btnEditCustomer.UseVisualStyleBackColor = true;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // btnOkToSearchInfoCustomer
            // 
            btnOkToSearchInfoCustomer.Location = new Point(278, 229);
            btnOkToSearchInfoCustomer.Name = "btnOkToSearchInfoCustomer";
            btnOkToSearchInfoCustomer.Size = new Size(31, 23);
            btnOkToSearchInfoCustomer.TabIndex = 32;
            btnOkToSearchInfoCustomer.Text = "Ok";
            btnOkToSearchInfoCustomer.UseVisualStyleBackColor = true;
            btnOkToSearchInfoCustomer.Click += btnOkToSearchInfoCustomer_Click;
            // 
            // tbSearchInfoCustomer
            // 
            tbSearchInfoCustomer.Location = new Point(70, 229);
            tbSearchInfoCustomer.Name = "tbSearchInfoCustomer";
            tbSearchInfoCustomer.Size = new Size(198, 23);
            tbSearchInfoCustomer.TabIndex = 31;
            // 
            // dtgInfoCustomer
            // 
            dtgInfoCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfoCustomer.Location = new Point(21, 258);
            dtgInfoCustomer.Name = "dtgInfoCustomer";
            dtgInfoCustomer.Size = new Size(440, 150);
            dtgInfoCustomer.TabIndex = 29;
            dtgInfoCustomer.CellClick += dtgInfoCustomer_CellClick;
            // 
            // cbbCustomerGender
            // 
            cbbCustomerGender.FormattingEnabled = true;
            cbbCustomerGender.Location = new Point(70, 142);
            cbbCustomerGender.Name = "cbbCustomerGender";
            cbbCustomerGender.Size = new Size(198, 23);
            cbbCustomerGender.TabIndex = 28;
            // 
            // tbCustomerAddress
            // 
            tbCustomerAddress.Location = new Point(128, 82);
            tbCustomerAddress.Name = "tbCustomerAddress";
            tbCustomerAddress.Size = new Size(140, 23);
            tbCustomerAddress.TabIndex = 26;
            // 
            // tbCustomerMail
            // 
            tbCustomerMail.Location = new Point(55, 113);
            tbCustomerMail.Name = "tbCustomerMail";
            tbCustomerMail.Size = new Size(213, 23);
            tbCustomerMail.TabIndex = 25;
            // 
            // tbCustomerPhoneNumber
            // 
            tbCustomerPhoneNumber.Location = new Point(168, 53);
            tbCustomerPhoneNumber.Name = "tbCustomerPhoneNumber";
            tbCustomerPhoneNumber.Size = new Size(100, 23);
            tbCustomerPhoneNumber.TabIndex = 24;
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(119, 23);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(149, 23);
            tbCustomerName.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 36, 49);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 450);
            panel2.TabIndex = 38;
            // 
            // pnSalesInvoiceHistory
            // 
            pnSalesInvoiceHistory.Controls.Add(btnSearchInvoiceHistory);
            pnSalesInvoiceHistory.Controls.Add(tbSearchInvoiceHistory);
            pnSalesInvoiceHistory.Controls.Add(dtgInvoiceHistory);
            pnSalesInvoiceHistory.Controls.Add(pnInvoiceHistory);
            pnSalesInvoiceHistory.Dock = DockStyle.Fill;
            pnSalesInvoiceHistory.Location = new Point(200, 0);
            pnSalesInvoiceHistory.Name = "pnSalesInvoiceHistory";
            pnSalesInvoiceHistory.Size = new Size(600, 450);
            pnSalesInvoiceHistory.TabIndex = 38;
            // 
            // btnSearchInvoiceHistory
            // 
            btnSearchInvoiceHistory.Location = new Point(149, 113);
            btnSearchInvoiceHistory.Name = "btnSearchInvoiceHistory";
            btnSearchInvoiceHistory.Size = new Size(53, 23);
            btnSearchInvoiceHistory.TabIndex = 7;
            btnSearchInvoiceHistory.Text = "Search";
            btnSearchInvoiceHistory.UseVisualStyleBackColor = true;
            btnSearchInvoiceHistory.Click += btnSearchInvoiceHistory_Click;
            // 
            // tbSearchInvoiceHistory
            // 
            tbSearchInvoiceHistory.Location = new Point(29, 111);
            tbSearchInvoiceHistory.Name = "tbSearchInvoiceHistory";
            tbSearchInvoiceHistory.Size = new Size(100, 23);
            tbSearchInvoiceHistory.TabIndex = 6;
            // 
            // dtgInvoiceHistory
            // 
            dtgInvoiceHistory.AllowUserToAddRows = false;
            dtgInvoiceHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInvoiceHistory.Location = new Point(25, 145);
            dtgInvoiceHistory.Name = "dtgInvoiceHistory";
            dtgInvoiceHistory.Size = new Size(550, 245);
            dtgInvoiceHistory.TabIndex = 4;
            // 
            // pnInvoiceHistory
            // 
            pnInvoiceHistory.BackColor = Color.FromArgb(34, 36, 49);
            pnInvoiceHistory.Controls.Add(lbInvoiceHistory);
            pnInvoiceHistory.Dock = DockStyle.Fill;
            pnInvoiceHistory.Location = new Point(0, 0);
            pnInvoiceHistory.Name = "pnInvoiceHistory";
            pnInvoiceHistory.Size = new Size(600, 450);
            pnInvoiceHistory.TabIndex = 8;
            // 
            // lbInvoiceHistory
            // 
            lbInvoiceHistory.AutoSize = true;
            lbInvoiceHistory.Font = new Font("Segoe UI", 20F);
            lbInvoiceHistory.ForeColor = SystemColors.ButtonFace;
            lbInvoiceHistory.Location = new Point(198, 56);
            lbInvoiceHistory.Name = "lbInvoiceHistory";
            lbInvoiceHistory.Size = new Size(192, 37);
            lbInvoiceHistory.TabIndex = 5;
            lbInvoiceHistory.Text = "Invoice History";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnSalesContent);
            Controls.Add(pnSalerManageCustomers);
            Controls.Add(pnSalesInvoiceHistory);
            Controls.Add(pnContentImportHistory);
            Controls.Add(pnMenu);
            Name = "Sales";
            Text = "Sales";
            pnMenu.ResumeLayout(false);
            pnContentImportHistory.ResumeLayout(false);
            pnContentImportHistory.PerformLayout();
            pnSalesContent.ResumeLayout(false);
            pnSalesContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgSaleProduct).EndInit();
            pnSalerManageCustomers.ResumeLayout(false);
            pnSalerManageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgInfoCustomer).EndInit();
            pnSalesInvoiceHistory.ResumeLayout(false);
            pnSalesInvoiceHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgInvoiceHistory).EndInit();
            pnInvoiceHistory.ResumeLayout(false);
            pnInvoiceHistory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMenu;
        private Button btnInvoiceHistory;
        private Button btnManageCustomers;
        private Button btnSale;
        private Panel pnContentImportHistory;
        private Label lbSearchImportHistory;
        private Panel panel1;
        private Panel pnSalesContent;
        private Button btnCheckOutSales;
        private Button btnRefreshSale;
        private Label lbChooseCustomer;
        private ComboBox cbbChooseCustomer;
        private Label lbTotalMoney;
        private Label lbStaffName;
        private DataGridView dtgCart;
        private Button btnAddToCart;
        private Label txtQuantityProductSale;
        private TextBox tbProductQuantitySale;
        private DataGridView dtgSaleProduct;
        private Panel pnSalerManageCustomers;
        private Button btnRefreshCustomerInfo;
        private Button btnDeleteCustomer;
        private Button btnClearCustomer;
        private Button btnAddCustomer;
        private Button btnEditCustomer;
        private Button btnOkToSearchInfoCustomer;
        private TextBox tbSearchInfoCustomer;
        private Label txtSearch;
        private DataGridView dtgInfoCustomer;
        private ComboBox cbbCustomerGender;
        private Label txtGender;
        private TextBox tbCustomerAddress;
        private TextBox tbCustomerMail;
        private TextBox tbCustomerPhoneNumber;
        private TextBox tbCustomerName;
        private Label txtCustomerPhoneNumber;
        private Label txtCustomerAddress;
        private Label txtCustomerMail;
        private Label txtCustomerName;
        private Panel pnSalesInvoiceHistory;
        private Button btnSearchInvoiceHistory;
        private TextBox tbSearchInvoiceHistory;
        private Label lbInvoiceHistory;
        private DataGridView dtgInvoiceHistory;
        private Panel pnInvoiceHistory;
        private Panel panel2;
    }
}