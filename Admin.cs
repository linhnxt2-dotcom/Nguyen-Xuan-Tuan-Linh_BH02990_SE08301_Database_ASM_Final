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
using System.IO;

namespace Nguyen_Xuan_Tuan_Linh_BH02990_SE08301_Database_ASM_Final
{
    public partial class Admin : Form
    {
        int currentEmployeeID = 0;
        string selectedImagePath = "";
        int currentCategoryID = 0;
        int currentProductID = 0;
        int currentCustomerID = 0;

        DataTable cartTable = new DataTable();
        bool isCartCreate = false;
        public Admin()
        {
            InitializeComponent();
            InitializeCombobox();
            LoadCategoryToCombobox();
            InitializeComboboxCustomerGender();
        }
        // Load data when form load
        private void Admin_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataProducts();
            LoadDataCustomer();
            LoadCategoryData();
            LoadSupplierData();
            LoadProductDataToImport();
            LoadCategoryToCombobox();
        }
        // Combobox for role
        public void InitializeCombobox()
        {
            cbbRole.Items.Add("Admin");
            cbbRole.Items.Add("Sales");
            cbbRole.Items.Add("Warehouse");
            cbbRole.SelectedIndex = -1;
        }
        public void InitializeComboboxCustomerGender()
        {
            cbbCustomerGender.Items.Add("Male");
            cbbCustomerGender.Items.Add("Female");
            cbbCustomerGender.Items.Add("Other");
            cbbCustomerGender.SelectedIndex = -1;
        }
        // Load data to datagridview
        private void LoadData()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();
            string query = "select * from Employee";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvInfoEmployee.DataSource = dataTable;
            connection.Close();

        }
        private void LoadCategoryToCombobox()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();
            string query = "select * from Category";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            cbCategoryProduct.DataSource = dataTable;
            cbCategoryProduct.DisplayMember = "Ca_Name";
            cbCategoryProduct.ValueMember = "Ca_ID";
            connection.Close();
        }
        private void LoadDataProducts()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = "select " +
                        "Souvenir.P_ID AS [Product Code], " +
                        "Souvenir.P_Name AS [Product Name], " +
                        "Souvenir.P_Price AS [Product Price], " +
                        "Souvenir.P_Quantity AS [Product Quantity], " +
                        "Souvenir.P_Image AS [Product Image], " +
                        "Souvenir.P_Status AS [Product Status], " +
                        "Souvenir.Ca_ID AS [Category ID] " +
                        "from Souvenir";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvInfoProducts.DataSource = dataTable;
            connection.Close();
        }
        private void LoadCategoryData()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();
            string query = "select * from Category";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtgCategory.DataSource = dataTable;
            connection.Close();
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

        // Event for panel
        private void pnContentEmployee_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnManageCategory_Click(object sender, EventArgs e)
        {
            pnManageCategory.BringToFront();
        }
        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            pnContentEmployee.BringToFront();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            pnManageProduct.BringToFront();
        }
        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            pnManageCustomerContent.BringToFront();
        }
        // Validation functions
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 10)
            {
                MessageBox.Show("Phone number must be 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (phoneNumber[0] != '0')
            {
                MessageBox.Show("Phone number must start with 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                char c = phoneNumber[i];
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Phone number must contain only digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private bool IsValidPassword(string password)
        {
            if (password.Length < 10 || password.Length > 20)
            {
                MessageBox.Show("Password must be between 10 and 20 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool hasUpperCase = false;
            bool hasNumber = false;
            bool hasSpecial = false;

            for (int i = 0; i < password.Length; i++)
            {
                char letter = password[i];
                if (letter >= 'A' && letter <= 'Z')
                {
                    hasUpperCase = true;
                }
                else if (letter >= 'a' && letter <= 'z')
                {

                }
                else if (letter >= '0' && letter <= '9')
                {
                    hasNumber = true;
                }
                else
                {
                    hasSpecial = true;
                }
            }
            if (hasUpperCase == false)
            {
                MessageBox.Show("Password must contain at least one uppercase letter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (hasNumber == false)
            {
                MessageBox.Show("Password must contain at least one number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (hasSpecial == false)
            {
                MessageBox.Show("Password must contain at least one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool CheckPhoneNumber(string PhoneNumber)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = "select * from Employee where E_Phonenumber = @CheckPhoneNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CheckPhoneNumber", PhoneNumber);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Phone number already exists. Please enter a different phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return false;
            }
            return true;
        }
        private bool CheckUsername(string Username)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = "select * from Employee where E_Username = @CheckUsername";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CheckUsername", Username);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Username already exists. Please enter a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return false;
            }
            return true;
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





        // All events for Manage Employee
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckUsername(tbUsername.Text) == false)
            {
                tbUsername.Clear();
                tbUsername.Focus();
                return;
            }
            if (CheckPhoneNumber(tbPhoneNumber.Text) == false)
            {
                tbPhoneNumber.Clear();
                tbPhoneNumber.Focus();
                return;
            }
            if (IsValidPhoneNumber(tbPhoneNumber.Text) == false)
            {
                tbPhoneNumber.Clear();
                tbPhoneNumber.Focus();
                return;
            }
            if (IsValidPassword(tbPassword.Text) == false)
            {
                tbPassword.Clear();
                tbPassword.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tbFullName.Text) || string.IsNullOrEmpty(tbPosition.Text) || string.IsNullOrEmpty(tbPhoneNumber.Text)
                || string.IsNullOrEmpty(tbAddress.Text) || string.IsNullOrEmpty(cbbRole.Text) || string.IsNullOrEmpty(tbUsername.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();
            string query = "insert into Employee (E_Name, E_Position, E_Phonenumber, E_Address, E_Role, E_Username, E_Password, Status)" +
                            "values (@Fullname, @Position, @PhoneNumber, @Address, @Role, @Username, @Password, @Status)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Fullname", tbFullName.Text);
            command.Parameters.AddWithValue("@Position", tbPosition.Text);
            command.Parameters.AddWithValue("@PhoneNumber", tbPhoneNumber.Text);
            command.Parameters.AddWithValue("@Address", tbAddress.Text);
            command.Parameters.AddWithValue("@Role", cbbRole.Text);
            command.Parameters.AddWithValue("@Username", tbUsername.Text);
            command.Parameters.AddWithValue("@Password", tbPassword.Text);
            command.Parameters.AddWithValue("@Status", tbEmployeeStatus.Text);

            command.ExecuteNonQuery();
            connection.Close();


            MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            btnClear_Click(sender, e);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (IsValidPhoneNumber(tbPhoneNumber.Text) == false)
            {
                tbPhoneNumber.Clear();
                tbPhoneNumber.Focus();
                return;
            }
            if (IsValidPassword(tbPassword.Text) == false)
            {
                tbPassword.Clear();
                tbPassword.Focus();
                return;
            }
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = "update Employee set E_Name = @FullName, E_Position = @Position, E_Phonenumber = @PhoneNumber, E_Address = @Address, E_Role = @Role, E_Username = @Username, E_Password = @Password, Status = @Status " +
               "where E_ID = @EmployeeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FullName", tbFullName.Text);
            command.Parameters.AddWithValue("@Position", tbPosition.Text);
            command.Parameters.AddWithValue("@PhoneNumber", tbPhoneNumber.Text);
            command.Parameters.AddWithValue("@Address", tbAddress.Text);
            command.Parameters.AddWithValue("@Role", cbbRole.Text);
            command.Parameters.AddWithValue("@Username", tbUsername.Text);
            command.Parameters.AddWithValue("@Password", tbPassword.Text);
            command.Parameters.AddWithValue("@EmployeeID", currentEmployeeID);
            command.Parameters.AddWithValue("@Status", tbEmployeeStatus.Text);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
            btnClear_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentEmployeeID == 0)
            {
                MessageBox.Show("Please select an employee to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                connection.Open();

                string queryUpdateInvoices = "update Invoice set E_ID = null where E_ID = @EmployeeID";
                SqlCommand commandUpdateInvoices = new SqlCommand(queryUpdateInvoices, connection);
                commandUpdateInvoices.Parameters.AddWithValue("@EmployeeID", currentEmployeeID);
                commandUpdateInvoices.ExecuteNonQuery();

                string query = "delete from Employee where E_ID = @EmployeeID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeID", currentEmployeeID);

                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                btnClear_Click(sender, e);
                currentEmployeeID = 0;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFullName.Clear();
            tbPosition.Clear();
            tbPhoneNumber.Clear();
            tbAddress.Clear();
            cbbRole.SelectedIndex = -1;
            tbUsername.Clear();
            tbPassword.Clear();
            tbFullName.Focus();
            tbEmployeeStatus.Clear();
        }
        private void dgvInfoEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInfoEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentEmployeeID = Convert.ToInt32(dgvInfoEmployee.CurrentRow.Cells[0].Value);
            tbFullName.Text = dgvInfoEmployee.CurrentRow.Cells[1].Value.ToString();
            tbPosition.Text = dgvInfoEmployee.CurrentRow.Cells[2].Value.ToString();
            tbPhoneNumber.Text = dgvInfoEmployee.CurrentRow.Cells[3].Value.ToString();
            tbAddress.Text = dgvInfoEmployee.CurrentRow.Cells[4].Value.ToString();
            cbbRole.Text = dgvInfoEmployee.CurrentRow.Cells[5].Value.ToString();
            tbUsername.Text = dgvInfoEmployee.CurrentRow.Cells[6].Value.ToString();
            tbPassword.Text = dgvInfoEmployee.CurrentRow.Cells[7].Value.ToString();
            tbEmployeeStatus.Text = dgvInfoEmployee.CurrentRow.Cells[8].Value.ToString();
        }
        // All events for Manage Product
        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;

                pbProductImage.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (tbProductName.Text == "" || tbProductPrice.Text == "" || tbProductQuantity.Text == "" || tbProductStatus.Text == "" || cbCategoryProduct.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedImagePath == "")
            {
                MessageBox.Show("Please select an image for the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fileName = Path.GetFileName(selectedImagePath);
            string imageFolder = Application.StartupPath + "\\Images";


            Directory.CreateDirectory(imageFolder);
            File.Copy(selectedImagePath, imageFolder + "\\" + fileName, true);

            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = "insert into Souvenir (P_Name, P_Price, P_Quantity, P_Image, P_Status, Ca_ID)" +
                "values(@ProductName, @ProductPrice, @ProductQuantity, @ProductImage, @ProductStatus, @CategoryID)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductName", tbProductName.Text);
            command.Parameters.AddWithValue("@ProductPrice", Convert.ToDecimal(tbProductPrice.Text));
            command.Parameters.AddWithValue("@ProductQuantity", Convert.ToInt32(tbProductQuantity.Text));
            command.Parameters.AddWithValue("@ProductImage", "Images\\" + fileName);
            command.Parameters.AddWithValue("@ProductStatus", tbProductStatus.Text);
            command.Parameters.AddWithValue("CategoryID", Convert.ToInt32(cbCategoryProduct.SelectedValue));

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadDataProducts();
            LoadCategoryToCombobox();
            btnClearInfoProduct_Click(sender, e);
        }
        private void dgvInfoProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentProductID = Convert.ToInt32(dgvInfoProducts.CurrentRow.Cells[0].Value);
                tbProductName.Text = dgvInfoProducts.CurrentRow.Cells[1].Value.ToString();
                tbProductPrice.Text = dgvInfoProducts.CurrentRow.Cells[2].Value.ToString();
                tbProductQuantity.Text = dgvInfoProducts.CurrentRow.Cells[3].Value.ToString();
                string imagePath = dgvInfoProducts.CurrentRow.Cells[4].Value.ToString();
                if (File.Exists(imagePath))
                {
                    pbProductImage.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pbProductImage.Image = null;
                }
                tbProductStatus.Text = dgvInfoProducts.CurrentRow.Cells[5].Value.ToString();
                // Kiểm tra trực tiếp cái ô số 6 xem nó có bị rỗng (DBNull) hay không
                if (dgvInfoProducts.CurrentRow.Cells[6].Value != DBNull.Value && dgvInfoProducts.CurrentRow.Cells[6].Value != null)
                {
                    // Nếu có dữ liệu đàng hoàng, thì ép kiểu sang số nguyên
                    cbCategoryProduct.SelectedValue = Convert.ToInt32(dgvInfoProducts.CurrentRow.Cells[6].Value);
                }
                else
                {
                    // Nếu nó bị trống (DBNull), thì reset ComboBox
                    cbCategoryProduct.SelectedIndex = -1;
                }
            }
        }
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (tbProductName.Text == "" || tbProductPrice.Text == "" || tbProductQuantity.Text == "" || tbProductStatus.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selectedImagePath == "")
            {
                MessageBox.Show("Please select an image for the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = "update Souvenir set P_Name = @ProductName, P_Price = @ProductPrice, P_Quantity = @ProductQuantity, P_Image = @ProductImage, P_Status = @ProductStatus, Ca_ID = @CategoryID" +
                " where P_ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductName", tbProductName.Text);
            command.Parameters.AddWithValue("@ProductPrice", Convert.ToDecimal(tbProductPrice.Text));
            command.Parameters.AddWithValue("@ProductQuantity", Convert.ToInt32(tbProductQuantity.Text));
            command.Parameters.AddWithValue("@ProductImage", "Images\\" + Path.GetFileName(selectedImagePath));
            command.Parameters.AddWithValue("@ProductStatus", tbProductStatus.Text);
            command.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(cbCategoryProduct.SelectedValue));
            command.Parameters.AddWithValue("@ID", currentProductID);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataProducts();
            btnClearInfoProduct_Click(sender, e);
        }
        private void btnClearInfoProduct_Click(object sender, EventArgs e)
        {
            tbProductName.Clear();
            tbProductPrice.Clear();
            tbProductQuantity.Clear();
            tbProductStatus.Clear();
            cbCategoryProduct.SelectedIndex = -1;
            pbProductImage.Image = null;
            tbProductName.Focus();
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (currentProductID == 0)
            {
                MessageBox.Show("Please select a product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                connection.Open();
                string queryUpdateInvoiceDetails = "update InvoiceDetail set P_ID = null where P_ID = @ProductID";
                SqlCommand commandUpdateInvoiceDetails = new SqlCommand(queryUpdateInvoiceDetails, connection);
                commandUpdateInvoiceDetails.Parameters.AddWithValue("@ProductID", currentProductID);
                commandUpdateInvoiceDetails.ExecuteNonQuery();
                string queryUpdateImportDetails = "update ImportOrderDetail set P_ID = null where P_ID = @ProductID";
                SqlCommand commandUpdateImportDetails = new SqlCommand(queryUpdateImportDetails, connection);
                commandUpdateImportDetails.Parameters.AddWithValue("@ProductID", currentProductID);
                commandUpdateImportDetails.ExecuteNonQuery();

                string query = "delete from Souvenir where P_ID = @ProductID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", currentProductID);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataProducts();
                currentProductID = 0;
                btnClearInfoProduct_Click(sender, e);
            }
        }
        private void btnOkSearch_Click(object sender, EventArgs e)
        {
            if (tbSearchProduct.Text == "")
            {
                MessageBox.Show("Please enter a product name to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();
            string query = "select * from Souvenir" +
                " inner join Category on Souvenir.Ca_ID = Category.Ca_ID" +
                " where Souvenir.P_Name like @Keyword or Category.Ca_Name like @Keyword";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Keyword", "%" + tbSearchProduct.Text + "%");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvInfoProducts.DataSource = dataTable;
            connection.Close();
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No products found matching the search criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataProducts();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataProducts();
            tbSearchProduct.Clear();
        }

        private void btnManageWarehouse_Click(object sender, EventArgs e)
        {
            pnManageWarehouseContent.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (tbCategoryName.Text == "")
            {
                return;
            }

            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();
            string query = "insert into Category (Ca_Name) values (@CategoryName)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryName", tbCategoryName.Text);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Category added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCategoryData();
        }
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (currentCategoryID == 0)
            {
                MessageBox.Show("Please select a category to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();
            string query = "update Category set Ca_Name = @Ca_Name where Ca_ID = @Ca_ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Ca_Name", tbCategoryName.Text);
            command.Parameters.AddWithValue("@Ca_ID", currentCategoryID);
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Category updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCategoryData();
        }
        private void dtgCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgCategory.Rows[e.RowIndex];

                currentCategoryID = Convert.ToInt32(row.Cells[0].Value);

                tbCategoryName.Text = row.Cells[1].Value.ToString();
                tbCategoryId.Text = row.Cells[0].Value.ToString();
                tbCategoryName.Focus();
            }
        }
        private void btnClearCategory_Click(object sender, EventArgs e)
        {
            tbCategoryId.Clear();
            tbCategoryName.Clear();
            tbCategoryName.Focus();
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (currentCategoryID == 0)
            {
                MessageBox.Show("Please select a category to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                connection.Open();
                string queryUpdateSouvenirs = "update Souvenir set Ca_ID = null where P_ID = @Product_ID";
                SqlCommand commandUpdateSouvenirs = new SqlCommand(queryUpdateSouvenirs, connection);
                commandUpdateSouvenirs.Parameters.AddWithValue("@Product_ID", currentCategoryID);
                commandUpdateSouvenirs.ExecuteNonQuery();

                string query = "delete from Category where Ca_ID = @Ca_ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ca_ID", currentCategoryID);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategoryData();
                currentCategoryID = 0;
                LoadData();
                btnClearCategory_Click(sender, e);
            }
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
            currentCustomerID = Convert.ToInt32(dtgInfoCustomer.CurrentRow.Cells[0].Value);
            tbCustomerName.Text = dtgInfoCustomer.CurrentRow.Cells[1].Value.ToString();
            tbCustomerPhoneNumber.Text = dtgInfoCustomer.CurrentRow.Cells[2].Value.ToString();
            tbCustomerMail.Text = dtgInfoCustomer.CurrentRow.Cells[3].Value.ToString();
            tbCustomerAddress.Text = dtgInfoCustomer.CurrentRow.Cells[4].Value.ToString();
            cbbCustomerGender.Text = dtgInfoCustomer.CurrentRow.Cells[5].Value.ToString();
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

        private void btnRefreshCustomerInfo_Click(object sender, EventArgs e)
        {

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

        private void btnManageSales_Click(object sender, EventArgs e)
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

        private void btnAddToCart_Click(object sender, EventArgs e)
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
            cartTable.Rows.Clear();

            tbProductQuantitySale.Clear();
            if (cbbChooseCustomer.Items.Count > 0)
            {
                cbbChooseCustomer.SelectedIndex = -1;
            }
            lbTotalMoney.Text = "Total: 0 VND";
            MessageBox.Show("Cart has been cleared.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCheckOutSales_Click(object sender, EventArgs e)
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

                    string queryInvoiceDetail = "insert into InvoiceDetail (I_ID, P_ID, ID_Quantity, ID_Price) " +
                                                "values (" + invoiceID + ", " + productID + ", " + quantity + ", " + price + ")";
                    string queryUpdateStock = "UPDATE Souvenir SET P_Quantity = P_Quantity - " + quantity + " WHERE P_ID = " + productID;
                    SqlCommand cmdUpdateStock = new SqlCommand(queryUpdateStock, connection);
                    cmdUpdateStock.ExecuteNonQuery();

                    SqlCommand cmdInvoiceDetail = new SqlCommand(queryInvoiceDetail, connection);
                    cmdInvoiceDetail.ExecuteNonQuery();
                }
                MessageBox.Show("Invoice created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
        }

        private void btnInvoiceHistory_Click(object sender, EventArgs e)
        {
            pnInvoiceHistoryContent.BringToFront();
            LoadInvoiceHistory();
        }
        private void LoadInvoiceHistory()
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
                "left join Souvenir s on id.P_ID = s.P_ID " +
                "order by i.I_ID desc";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtgInvoiceHistory.DataSource = dataTable;
            connection.Close();
        }


        private void btnSearchInvoiceHistory_Click(object sender, EventArgs e)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();

            string sql = "select i.I_ID, i.I_Date, e.E_Name, c.C_Name "
                + "from Invoice i " +
                "inner join Employee e on i.E_ID = e.E_ID " +
                "inner join Customer c on i.C_ID = c.C_ID " +
                "where e.E_Name like @Search or c.C_Name like @Search";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Search", "%" + tbSearchInvoiceHistory.Text + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtgInvoiceHistory.DataSource = dataTable;

            connection.Close();

        }
        private void LoadProductDataToImport()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = "select P_ID, P_Name from Souvenir";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            cbbChooseProductImport.DataSource = dataTable;
            cbbChooseProductImport.DisplayMember = "P_Name";
            cbbChooseProductImport.ValueMember = "P_ID";

            connection.Close();


        }
        private void LoadSupplierData()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = "select S_ID, S_Name from Supplier";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            cbbChooseSupplier.DataSource = dataTable;
            cbbChooseSupplier.DisplayMember = "S_Name";
            cbbChooseSupplier.ValueMember = "S_ID";

            connection.Close();

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (cbbChooseProductImport.SelectedValue == null || cbbChooseSupplier.SelectedValue == null || string.IsNullOrEmpty(tbImportQuantity.Text) || string.IsNullOrEmpty(tbPriceImport.Text))
            {
                MessageBox.Show("Please fill in all fields to import products.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string employeeID = UserSection.EmployeeID.ToString();
            string supplierID = cbbChooseSupplier.SelectedValue.ToString();
            string productID = cbbChooseProductImport.SelectedValue.ToString();
            string quantity = tbImportQuantity.Text;
            string price = tbPriceImport.Text;

            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();

            string queryImport = "insert into ImportOrder (IO_Date, E_ID, S_ID) " +
                "values (getdate(), " +
                employeeID +
                ", " +
                supplierID +
                ")";
            SqlCommand cmdImport = new SqlCommand(queryImport, connection);
            cmdImport.ExecuteNonQuery();

            string queryGetImportID = "select max(IO_ID) from ImportOrder";
            SqlCommand cmdGetImportID = new SqlCommand(queryGetImportID, connection);
            int importID = Convert.ToInt32(cmdGetImportID.ExecuteScalar());

            string queryUpdateStock = "update Souvenir set P_Quantity = P_Quantity + " + quantity + " where P_ID = " + productID;
            SqlCommand cmdUpdateStock = new SqlCommand(queryUpdateStock, connection);
            cmdUpdateStock.ExecuteNonQuery();

            string queryDetail = "insert into ImportOrderDetail (IO_ID, P_ID, IOD_Quantity, IOD_UnitPrice) " +
                "values (" + importID + ", " + productID + ", " + quantity + ", " + price + ")";
            SqlCommand cmdDetail = new SqlCommand(queryDetail, connection);
            cmdDetail.ExecuteNonQuery();

            MessageBox.Show("Product imported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connection.Close();
        }

        private void pnContentImportHistory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchImportHistory_Click(object sender, EventArgs e)
        {
            string keyword = tbSearchImportHistory.Text.Trim();
            LoadImportHistory(keyword);
        }
        private void LoadImportHistory(string keyword = "")
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            connection.Open();

            string query = "select " +
                "io.IO_ID as [Import ID], " +
                "io.IO_Date as [Import Date], " +
                "e.E_Name as [Employee Name], " +
                "sup.S_Name as [Supplier], " +
                "p.P_Name as [Product Name], " +
                "iod.IOD_Quantity as [Quantity], " +
                "iod.IOD_UnitPrice as [Import Price], " +
                "(iod.IOD_Quantity * iod.IOD_UnitPrice) as [Subtotal] " +
                "from ImportOrder io " +
                "left join Employee e on io.E_ID = e.E_ID " +
                "left join Supplier sup on io.S_ID = sup.S_ID " +
                "left join ImportOrderDetail iod on io.IO_ID = iod.IO_ID " +
                "left join Souvenir p on iod.P_ID = p.P_ID";
            if (keyword == "")
            {
                query += " order by io.IO_ID desc";
            }
            else
            {
                query += " where e.E_Name like N'%" + keyword + "%' " +
                         "or sup.S_Name like N'%" + keyword + "%' " +
                         "or p.P_Name like N'%" + keyword + "%' " +
                         "order by io.IO_ID desc";
            }
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dtgImportHistory.DataSource = dataTable;
            connection.Close();
        }

        private void btnImportHistory_Click(object sender, EventArgs e)
        {
            pnContentImportHistory.BringToFront();
            LoadImportHistory("");
        }
        
    }
}
