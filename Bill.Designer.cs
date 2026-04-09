namespace Nguyen_Xuan_Tuan_Linh_BH02990_SE08301_Database_ASM_Final
{
    partial class Bill
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
            txtInvoice = new Label();
            lbEmployeeInvoice = new Label();
            lbCustomerInvoice = new Label();
            lbDatetimeInvoice = new Label();
            lbTotalMoneyInvoice = new Label();
            dtgBillInvoice = new DataGridView();
            btnConfirmInvoice = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgBillInvoice).BeginInit();
            SuspendLayout();
            // 
            // txtInvoice
            // 
            txtInvoice.AutoSize = true;
            txtInvoice.Location = new Point(108, 33);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(45, 15);
            txtInvoice.TabIndex = 0;
            txtInvoice.Text = "Invoice";
            // 
            // lbEmployeeInvoice
            // 
            lbEmployeeInvoice.AutoSize = true;
            lbEmployeeInvoice.Location = new Point(30, 84);
            lbEmployeeInvoice.Name = "lbEmployeeInvoice";
            lbEmployeeInvoice.Size = new Size(65, 15);
            lbEmployeeInvoice.TabIndex = 1;
            lbEmployeeInvoice.Text = "Employee: ";
            // 
            // lbCustomerInvoice
            // 
            lbCustomerInvoice.AutoSize = true;
            lbCustomerInvoice.Location = new Point(30, 129);
            lbCustomerInvoice.Name = "lbCustomerInvoice";
            lbCustomerInvoice.Size = new Size(65, 15);
            lbCustomerInvoice.TabIndex = 2;
            lbCustomerInvoice.Text = "Customer: ";
            // 
            // lbDatetimeInvoice
            // 
            lbDatetimeInvoice.AutoSize = true;
            lbDatetimeInvoice.Location = new Point(30, 180);
            lbDatetimeInvoice.Name = "lbDatetimeInvoice";
            lbDatetimeInvoice.Size = new Size(67, 15);
            lbDatetimeInvoice.TabIndex = 4;
            lbDatetimeInvoice.Text = "Date Time: ";
            // 
            // lbTotalMoneyInvoice
            // 
            lbTotalMoneyInvoice.AutoSize = true;
            lbTotalMoneyInvoice.Location = new Point(30, 369);
            lbTotalMoneyInvoice.Name = "lbTotalMoneyInvoice";
            lbTotalMoneyInvoice.Size = new Size(79, 15);
            lbTotalMoneyInvoice.TabIndex = 5;
            lbTotalMoneyInvoice.Text = "Total Money: ";
            // 
            // dtgBillInvoice
            // 
            dtgBillInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgBillInvoice.Location = new Point(30, 207);
            dtgBillInvoice.Name = "dtgBillInvoice";
            dtgBillInvoice.Size = new Size(240, 150);
            dtgBillInvoice.TabIndex = 6;
            // 
            // btnConfirmInvoice
            // 
            btnConfirmInvoice.Location = new Point(30, 403);
            btnConfirmInvoice.Name = "btnConfirmInvoice";
            btnConfirmInvoice.Size = new Size(75, 23);
            btnConfirmInvoice.TabIndex = 7;
            btnConfirmInvoice.Text = "Confirm";
            btnConfirmInvoice.UseVisualStyleBackColor = true;
            btnConfirmInvoice.Click += btnConfirmInvoice_Click;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 450);
            Controls.Add(btnConfirmInvoice);
            Controls.Add(dtgBillInvoice);
            Controls.Add(lbTotalMoneyInvoice);
            Controls.Add(lbDatetimeInvoice);
            Controls.Add(lbCustomerInvoice);
            Controls.Add(lbEmployeeInvoice);
            Controls.Add(txtInvoice);
            Name = "Bill";
            Text = "Bill";
            Load += Bill_Load;
            ((System.ComponentModel.ISupportInitialize)dtgBillInvoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtInvoice;
        private Label lbEmployeeInvoice;
        private Label lbCustomerInvoice;
        private Label lbDatetimeInvoice;
        private Label lbTotalMoneyInvoice;
        private DataGridView dtgBillInvoice;
        private Button btnConfirmInvoice;
    }
}