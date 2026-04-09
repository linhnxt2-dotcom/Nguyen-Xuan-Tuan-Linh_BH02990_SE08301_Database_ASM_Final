using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nguyen_Xuan_Tuan_Linh_BH02990_SE08301_Database_ASM_Final
{
    public partial class Sales : Form
    {
        DataTable cartTable = new DataTable();
        bool isCartCreate = false;
        int currentCustomerID = 0;
        public Sales()
        {
            InitializeComponent();
            LoadDataCustomer();
            InitializeComboboxCustomerGender();
            LoadCustomerToCombobox();
        }
        private void LoadCustomerToCombobox()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();
            string query = "select C_ID, C_Name from Customer";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            cbbChooseCustomer.DataSource = dataTable;
            cbbChooseCustomer.DisplayMember = "C_Name";
            cbbChooseCustomer.ValueMember = "C_ID";
            connection.Close();
            cbbChooseCustomer.SelectedIndex = -1;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            pnSalesContent.BringToFront();
            lbStaffName.Text = "Employee create invoice: " + UserSection.EmployeeName;
            lbTotalMoney.Text = "Total: 0 VND";
            if (isCartCreate == false)
            {
                cartTable.Columns.Add("Product ID");
                cartTable.Columns.Add("Product Name");
                cartTable.Columns.Add("Quantity");
                cartTable.Columns.Add("Price");
                cartTable.Columns.Add("Total Price");

                dtgCart.DataSource = cartTable;
                isCartCreate = true;
            }
            LoadCustomerToCombobox();
            LoadDataProductsToSales();


        }
        private void LoadDataProductsToSales()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = "select P_ID AS [Product Code], " +
                "P_Name AS [Product Name], " +
                "P_Price AS [Product Price], " +
                "P_Quantity AS [Product Quantity] " +
                "from Souvenir";

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtgSaleProduct.DataSource = dataTable;

            connection.Close();
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {


        }
        private void CalculateTotal()
        {
            decimal total = 0;
            for (int i = 0; i < cartTable.Rows.Count; i++)
            {
                total += Convert.ToDecimal(cartTable.Rows[i][4]);

            }
            lbTotalMoney.Text = "Total: " + total.ToString() + " VND";
        }
        private void btnRefreshSale_Click(object sender, EventArgs e)
        {


        }
        private void btnCheckOutSales_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbProductQuantitySale.Text))
            {
                MessageBox.Show("Please enter the quantity of the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtgSaleProduct.SelectedRows.Count == null)
            {
                MessageBox.Show("Please select a product to add to the cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow selectedRow = dtgSaleProduct.CurrentRow;

            string id = dtgSaleProduct.CurrentRow.Cells[0].Value.ToString();
            string name = dtgSaleProduct.CurrentRow.Cells[1].Value.ToString();
            decimal price = Convert.ToDecimal(dtgSaleProduct.CurrentRow.Cells[2].Value);
            int availableQuantity = 0;
            if (!string.IsNullOrEmpty(tbProductQuantitySale.Text))
            {
                availableQuantity = Convert.ToInt32(tbProductQuantitySale.Text);
            }

            decimal totalPrice = price * availableQuantity;

            cartTable.Rows.Add(id, name, availableQuantity, price, totalPrice);
            CalculateTotal();

            tbProductQuantitySale.Clear();
        }

        private void btnCheckOutSales_Click_1(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty. Please add products to the cart before checking out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbChooseCustomer.SelectedValue == null || cbbChooseCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer for the invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string employeeID = UserSection.EmployeeID.ToString();
            string customerID = cbbChooseCustomer.SelectedValue.ToString();
            decimal totalAmount = Convert.ToDecimal(lbTotalMoney.Text.Replace("Total: ", "").Replace(" VND", ""));
            Bill popup = new Bill(employeeID, customerID, cartTable, totalAmount.ToString());
            if (popup.ShowDialog() == DialogResult.OK)
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                connection.Open();

                string querInvoice = "insert into Invoice " +
                    "(I_Date, E_ID, C_ID, I_TotalAmount) " +
                    "values (getdate(), " + employeeID + ", " + customerID + ", " + totalAmount + ")";
                SqlCommand cmd = new SqlCommand(querInvoice, connection);
                cmd.ExecuteNonQuery();

                string queryGetInvoiceID = "select max(I_ID) from Invoice";
                SqlCommand cmdGetInvoiceID = new SqlCommand(queryGetInvoiceID, connection);
                int invoiceID = Convert.ToInt32(cmdGetInvoiceID.ExecuteScalar());

                for (int i = 0; i < cartTable.Rows.Count; i++)
                {
                    string productID = cartTable.Rows[i]["Product ID"].ToString();
                    string price = cartTable.Rows[i]["Price"].ToString();
                    string quantity = cartTable.Rows[i]["Quantity"].ToString();

                    // 1. LƯU CHI TIẾT HÓA ĐƠN (Phần em đã bỏ quên)
                    string queryInvoiceDetail = "insert into InvoiceDetail (I_ID, P_ID, ID_Quantity, ID_Price) " +
                                                "values (" + invoiceID + ", " + productID + ", " + quantity + ", " + price + ")";
                    SqlCommand cmdInvoiceDetail = new SqlCommand(queryInvoiceDetail, connection);
                    cmdInvoiceDetail.ExecuteNonQuery(); // Phải có lệnh này SQL nó mới ghi vào sổ!

                    // 2. TRỪ HÀNG TỒN KHO (Phần của em viết đúng rồi)
                    string queryUpdateStock = "UPDATE Souvenir SET P_Quantity = P_Quantity - " + quantity + " WHERE P_ID = " + productID;
                    SqlCommand cmdUpdateStock = new SqlCommand(queryUpdateStock, connection);
                    cmdUpdateStock.ExecuteNonQuery();
                }
                MessageBox.Show("Invoice created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                cartTable.Clear();
            }
        }

        private void btnRefreshSale_Click_1(object sender, EventArgs e)
        {
            cartTable.Rows.Clear();

            tbProductQuantitySale.Clear();
            if (cbbChooseCustomer.Items.Count > 0)
            {
                cbbChooseCustomer.SelectedIndex = -1;
            }
            lbTotalMoney.Text = "Total: 0 VND";
            MessageBox.Show("Cart has been cleared.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            pnSalerManageCustomers.BringToFront();

        }
        private void LoadDataCustomer()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();
            string query = "select " +
                "C_ID AS [Customer ID], " +
                "C_Name AS [Customer Name], " +
                "C_Phonenumber AS [Customer Phone Number], " +
                "C_Mail AS [Customer Email], " +
                "C_Address AS [Customer Address], " +
                "Gender AS [Gender] " +
                "from Customer";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtgInfoCustomer.DataSource = dataTable;
            connection.Close();
        }
        private bool CheckEmail(string Email)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();
            string query = "select * from Customer where C_Mail = @CheckEmail";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CheckEmail", tbCustomerMail.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Email already exists. Please enter a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return false;
            }
            if (Email.Contains('@'))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (CheckEmail(tbCustomerMail.Text) == false)
            {
                return;
            }
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = "insert into Customer (C_Name, C_Phonenumber, C_Mail, C_Address, Gender) " +
                "values (@CustomerName, @CustomerPhoneNumber, @CustomerMail, @CustomerAddress, @CustomerGender)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerName", tbCustomerName.Text);
            command.Parameters.AddWithValue("@CustomerPhoneNumber", tbCustomerPhoneNumber.Text);
            command.Parameters.AddWithValue("@CustomerMail", tbCustomerMail.Text);
            command.Parameters.AddWithValue("@CustomerAddress", tbCustomerAddress.Text);
            command.Parameters.AddWithValue("@CustomerGender", cbbCustomerGender.Text);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Customer added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataCustomer();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (currentCustomerID == 0)
            {
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                connection.Open();
                string queryUpdateInvoices = "update Invoice set C_ID = null where C_ID = @CustomerID";
                SqlCommand commandUpdateInvoices = new SqlCommand(queryUpdateInvoices, connection);
                commandUpdateInvoices.Parameters.AddWithValue("@CustomerID", currentCustomerID);
                commandUpdateInvoices.ExecuteNonQuery();
                string query = "delete from Customer where C_ID = @CustomerID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", currentCustomerID);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataCustomer();
                currentCustomerID = 0;
                btnClearCustomer_Click(sender, e);
            }

        }

        private void dtgInfoCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgInfoCustomer.Rows[e.RowIndex];

                currentCustomerID = Convert.ToInt32(row.Cells["Customer ID"].Value);
                tbCustomerName.Text = row.Cells["Customer Name"].Value.ToString();
                tbCustomerPhoneNumber.Text = row.Cells["Customer Phone Number"].Value.ToString();
                tbCustomerMail.Text = row.Cells["Customer Email"].Value.ToString();
                tbCustomerAddress.Text = row.Cells["Customer Address"].Value.ToString();
                cbbCustomerGender.Text = row.Cells["Gender"].Value.ToString();
            }

        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            tbCustomerName.Clear();
            tbCustomerPhoneNumber.Clear();
            tbCustomerMail.Clear();
            tbCustomerAddress.Clear();
            cbbCustomerGender.SelectedIndex = -1;
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();
            string query = "update Customer set C_Name = @CustomerName, C_Phonenumber = @CustomerPhoneNumber, C_Mail = @CustomerMail, C_Address = @CustomerAddress, Gender = @CustomerGender " +
                "where C_ID = @CustomerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerName", tbCustomerName.Text);
            command.Parameters.AddWithValue("@CustomerPhoneNumber", tbCustomerPhoneNumber.Text);
            command.Parameters.AddWithValue("@CustomerMail", tbCustomerMail.Text);
            command.Parameters.AddWithValue("@CustomerAddress", tbCustomerAddress.Text);
            command.Parameters.AddWithValue("@CustomerGender", cbbCustomerGender.Text);
            command.Parameters.AddWithValue("@CustomerID", currentCustomerID);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataCustomer();
            btnClearCustomer_Click(sender, e);
        }
        private void LoadCustomertoSearch(string keyword = "")
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = "select C_ID as [Customer ID], C_Name as [Customer Name], " +
                "C_Phonenumber as [Phone number], C_Address as [Address] " +
                "from Customer";
            if (!string.IsNullOrEmpty(keyword))
            {
                query += " order by C_ID desc";
            }
            else
            {
                query += " where C_Name like N'%" + keyword + "%' " +
                    "or C_Phonenumber like N'%" + keyword + "%' " +
                    "order by C_ID desc";
            }
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtgInfoCustomer.DataSource = dataTable;
            connection.Close();
        }

        private void btnOkToSearchInfoCustomer_Click(object sender, EventArgs e)
        {
            string keyword = tbSearchInfoCustomer.Text;
            LoadCustomertoSearch(keyword);
        }
        public void InitializeComboboxCustomerGender()
        {
            cbbCustomerGender.Items.Add("Male");
            cbbCustomerGender.Items.Add("Female");
            cbbCustomerGender.Items.Add("Other");
            cbbCustomerGender.SelectedIndex = -1;
        }

        private void btnInvoiceHistory_Click(object sender, EventArgs e)
        {
            pnSalesInvoiceHistory.BringToFront();
            LoadInvoiceHistory("");
        }
        private void LoadInvoiceHistory(string keyword = "")
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();
            string sql = "select " +
                "i.I_ID as [Invoice ID], " +
                "i.I_Date as [Date], " +
                "e.E_Name as [Employee name], " +
                "c.C_Name as [Customer name], " +
                "s.P_Name as [Product name], " +
                "id.ID_Quantity as [Quantity], " +
                "id.ID_Price as [Unit Price], " +
                "(id.ID_Quantity * id.ID_Price) as [SubTotal], " +
                "i.I_TotalAmount as [Total Invoice Money] " +
                "from Invoice i " +
                "left join Employee e on i.E_ID = e.E_ID " +
                "left join Customer c on i.C_ID = c.C_ID " +
                "left join InvoiceDetail id on i.I_ID = id.I_ID " +
                "left join Souvenir s on id.P_ID = s.P_ID ";
            SqlCommand command;

            if (keyword == "")
            {
                sql += "order by i.I_ID desc";
                command = new SqlCommand(sql, connection);
            }
            else 
            {
                sql += " where e.E_Name like @Search " +
                    "or c.C_Name like @Search " +
                    "or s.P_Name like @Search " +
                    "order by i.I_ID desc";
                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@Search", "%" + keyword + "%");
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dtgInvoiceHistory.DataSource =dataTable;
            connection.Close();
        }

        private void btnSearchInvoiceHistory_Click(object sender, EventArgs e)
        {
            string keyword = tbSearchInvoiceHistory.Text.Trim();
            LoadInvoiceHistory(keyword);
        }
    }
}
