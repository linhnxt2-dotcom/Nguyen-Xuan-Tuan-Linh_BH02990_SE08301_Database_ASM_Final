namespace Nguyen_Xuan_Tuan_Linh_BH02990_SE08301_Database_ASM_Final
{
    partial class Warehouse
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
            btnImportHistory = new Button();
            btnManageWarehouse = new Button();
            pnManageWarehouse = new Panel();
            btnImport = new Button();
            tbPriceImport = new TextBox();
            lbImportPrice = new Label();
            tbImportQuantity = new TextBox();
            lbImportQuantity = new Label();
            cbbChooseProductImport = new ComboBox();
            lbImportProduct = new Label();
            lbSupplierImport = new Label();
            cbbChooseSupplier = new ComboBox();
            pnImportHistory = new Panel();
            btnSearchImportHistory = new Button();
            lbSearchImportHistory = new Label();
            tbSearchImportHistory = new TextBox();
            dtgImportHistory = new DataGridView();
            panel1 = new Panel();
            pnMenu.SuspendLayout();
            pnManageWarehouse.SuspendLayout();
            pnImportHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgImportHistory).BeginInit();
            SuspendLayout();
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.FromArgb(25, 25, 35);
            pnMenu.Controls.Add(btnImportHistory);
            pnMenu.Controls.Add(btnManageWarehouse);
            pnMenu.Dock = DockStyle.Left;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(200, 450);
            pnMenu.TabIndex = 1;
            // 
            // btnImportHistory
            // 
            btnImportHistory.Dock = DockStyle.Top;
            btnImportHistory.FlatStyle = FlatStyle.Flat;
            btnImportHistory.ForeColor = SystemColors.ButtonFace;
            btnImportHistory.Location = new Point(0, 23);
            btnImportHistory.Name = "btnImportHistory";
            btnImportHistory.Size = new Size(200, 23);
            btnImportHistory.TabIndex = 6;
            btnImportHistory.Text = "Import History";
            btnImportHistory.UseVisualStyleBackColor = true;
            btnImportHistory.Click += btnImportHistory_Click;
            // 
            // btnManageWarehouse
            // 
            btnManageWarehouse.Dock = DockStyle.Top;
            btnManageWarehouse.FlatStyle = FlatStyle.Flat;
            btnManageWarehouse.ForeColor = SystemColors.ButtonFace;
            btnManageWarehouse.Location = new Point(0, 0);
            btnManageWarehouse.Name = "btnManageWarehouse";
            btnManageWarehouse.Size = new Size(200, 23);
            btnManageWarehouse.TabIndex = 3;
            btnManageWarehouse.Text = "Manage Warehouse";
            btnManageWarehouse.UseVisualStyleBackColor = true;
            btnManageWarehouse.Click += btnManageWarehouse_Click;
            // 
            // pnManageWarehouse
            // 
            pnManageWarehouse.BackColor = Color.FromArgb(34, 36, 49);
            pnManageWarehouse.Controls.Add(btnImport);
            pnManageWarehouse.Controls.Add(tbPriceImport);
            pnManageWarehouse.Controls.Add(lbImportPrice);
            pnManageWarehouse.Controls.Add(tbImportQuantity);
            pnManageWarehouse.Controls.Add(lbImportQuantity);
            pnManageWarehouse.Controls.Add(cbbChooseProductImport);
            pnManageWarehouse.Controls.Add(lbImportProduct);
            pnManageWarehouse.Controls.Add(lbSupplierImport);
            pnManageWarehouse.Controls.Add(cbbChooseSupplier);
            pnManageWarehouse.Dock = DockStyle.Fill;
            pnManageWarehouse.Location = new Point(200, 0);
            pnManageWarehouse.Name = "pnManageWarehouse";
            pnManageWarehouse.Size = new Size(600, 450);
            pnManageWarehouse.TabIndex = 2;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(272, 30);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(75, 23);
            btnImport.TabIndex = 17;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // tbPriceImport
            // 
            tbPriceImport.Location = new Point(107, 134);
            tbPriceImport.Name = "tbPriceImport";
            tbPriceImport.Size = new Size(149, 23);
            tbPriceImport.TabIndex = 16;
            // 
            // lbImportPrice
            // 
            lbImportPrice.AutoSize = true;
            lbImportPrice.ForeColor = SystemColors.ButtonFace;
            lbImportPrice.Location = new Point(42, 134);
            lbImportPrice.Name = "lbImportPrice";
            lbImportPrice.Size = new Size(39, 15);
            lbImportPrice.TabIndex = 15;
            lbImportPrice.Text = "Price: ";
            // 
            // tbImportQuantity
            // 
            tbImportQuantity.Location = new Point(107, 96);
            tbImportQuantity.Name = "tbImportQuantity";
            tbImportQuantity.Size = new Size(149, 23);
            tbImportQuantity.TabIndex = 14;
            // 
            // lbImportQuantity
            // 
            lbImportQuantity.AutoSize = true;
            lbImportQuantity.ForeColor = SystemColors.ButtonFace;
            lbImportQuantity.Location = new Point(42, 97);
            lbImportQuantity.Name = "lbImportQuantity";
            lbImportQuantity.Size = new Size(59, 15);
            lbImportQuantity.TabIndex = 13;
            lbImportQuantity.Text = "Quantity: ";
            // 
            // cbbChooseProductImport
            // 
            cbbChooseProductImport.FormattingEnabled = true;
            cbbChooseProductImport.Location = new Point(135, 58);
            cbbChooseProductImport.Name = "cbbChooseProductImport";
            cbbChooseProductImport.Size = new Size(121, 23);
            cbbChooseProductImport.TabIndex = 12;
            // 
            // lbImportProduct
            // 
            lbImportProduct.AutoSize = true;
            lbImportProduct.ForeColor = SystemColors.ButtonFace;
            lbImportProduct.Location = new Point(42, 65);
            lbImportProduct.Name = "lbImportProduct";
            lbImportProduct.Size = new Size(94, 15);
            lbImportProduct.TabIndex = 11;
            lbImportProduct.Text = "Import Product: ";
            // 
            // lbSupplierImport
            // 
            lbSupplierImport.AutoSize = true;
            lbSupplierImport.ForeColor = SystemColors.ButtonFace;
            lbSupplierImport.Location = new Point(42, 33);
            lbSupplierImport.Name = "lbSupplierImport";
            lbSupplierImport.Size = new Size(56, 15);
            lbSupplierImport.TabIndex = 10;
            lbSupplierImport.Text = "Supplier: ";
            // 
            // cbbChooseSupplier
            // 
            cbbChooseSupplier.FormattingEnabled = true;
            cbbChooseSupplier.Location = new Point(135, 29);
            cbbChooseSupplier.Name = "cbbChooseSupplier";
            cbbChooseSupplier.Size = new Size(121, 23);
            cbbChooseSupplier.TabIndex = 9;
            // 
            // pnImportHistory
            // 
            pnImportHistory.Controls.Add(btnSearchImportHistory);
            pnImportHistory.Controls.Add(lbSearchImportHistory);
            pnImportHistory.Controls.Add(tbSearchImportHistory);
            pnImportHistory.Controls.Add(dtgImportHistory);
            pnImportHistory.Controls.Add(panel1);
            pnImportHistory.Dock = DockStyle.Fill;
            pnImportHistory.Location = new Point(200, 0);
            pnImportHistory.Name = "pnImportHistory";
            pnImportHistory.Size = new Size(600, 450);
            pnImportHistory.TabIndex = 18;
            // 
            // btnSearchImportHistory
            // 
            btnSearchImportHistory.Location = new Point(280, 103);
            btnSearchImportHistory.Name = "btnSearchImportHistory";
            btnSearchImportHistory.Size = new Size(75, 23);
            btnSearchImportHistory.TabIndex = 7;
            btnSearchImportHistory.Text = "Search";
            btnSearchImportHistory.UseVisualStyleBackColor = true;
            btnSearchImportHistory.Click += btnSearchImportHistory_Click;
            // 
            // lbSearchImportHistory
            // 
            lbSearchImportHistory.AutoSize = true;
            lbSearchImportHistory.BackColor = Color.FromArgb(34, 36, 49);
            lbSearchImportHistory.ForeColor = SystemColors.ButtonFace;
            lbSearchImportHistory.Location = new Point(27, 107);
            lbSearchImportHistory.Name = "lbSearchImportHistory";
            lbSearchImportHistory.Size = new Size(122, 15);
            lbSearchImportHistory.TabIndex = 6;
            lbSearchImportHistory.Text = "Search Import History";
            // 
            // tbSearchImportHistory
            // 
            tbSearchImportHistory.Location = new Point(162, 104);
            tbSearchImportHistory.Name = "tbSearchImportHistory";
            tbSearchImportHistory.Size = new Size(100, 23);
            tbSearchImportHistory.TabIndex = 5;
            // 
            // dtgImportHistory
            // 
            dtgImportHistory.AllowUserToAddRows = false;
            dtgImportHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgImportHistory.Location = new Point(27, 163);
            dtgImportHistory.Name = "dtgImportHistory";
            dtgImportHistory.Size = new Size(546, 193);
            dtgImportHistory.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 49);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 450);
            panel1.TabIndex = 8;
            // 
            // Warehouse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnManageWarehouse);
            Controls.Add(pnImportHistory);
            Controls.Add(pnMenu);
            Name = "Warehouse";
            Text = "Warehouse";
            pnMenu.ResumeLayout(false);
            pnManageWarehouse.ResumeLayout(false);
            pnManageWarehouse.PerformLayout();
            pnImportHistory.ResumeLayout(false);
            pnImportHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgImportHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMenu;
        private Button btnImportHistory;
        private Button btnManageWarehouse;
        private Panel pnManageWarehouse;
        private Button btnImport;
        private TextBox tbPriceImport;
        private Label lbImportPrice;
        private TextBox tbImportQuantity;
        private Label lbImportQuantity;
        private ComboBox cbbChooseProductImport;
        private Label lbImportProduct;
        private Label lbSupplierImport;
        private ComboBox cbbChooseSupplier;
        private Panel pnImportHistory;
        private Button btnSearchImportHistory;
        private Label lbSearchImportHistory;
        private TextBox tbSearchImportHistory;
        private DataGridView dtgImportHistory;
        private Panel panel1;
    }
}