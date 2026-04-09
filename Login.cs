using Microsoft.Data.SqlClient;

namespace Nguyen_Xuan_Tuan_Linh_BH02990_SE08301_Database_ASM_Final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            InitializeCombobox();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string role = cbbRole.SelectedItem.ToString();

            bool isValid = ValidateData(username, password, role);
            if (isValid)
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();

                    string query = "select E_ID, E_Name from Employee where E_Username = @username and E_Password = @password and E_Role = @role ";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@role", role);

                    SqlDataReader reader = command.ExecuteReader();
                    int E_ID = 0;
                    if (reader.Read()) 
                    { 
                        E_ID = reader.GetInt32(reader.GetOrdinal("E_ID"));

                        UserSection.EmployeeID = E_ID;
                        UserSection.EmployeeName = reader.GetString(reader.GetOrdinal("E_Name"));
                    }
                    connection.Close();
                    if (E_ID > 0)
                    {
                        MessageBox.Show("Login successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RedirectForm(role, E_ID);
                    }
                    else
                    {
                        MessageBox.Show("Invalid login credential", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearData();
                    }
                }

            }
        }

        public void InitializeCombobox()
        {
            cbbRole.Items.Add("Admin");
            cbbRole.Items.Add("Sales");
            cbbRole.Items.Add("Warehouse");

            cbbRole.SelectedIndex = 0;
        }
        private bool ValidateData(string username, string password, string role)
        {
            bool isValid = true;
            if (username == null || username == string.Empty)
            {
                MessageBox.Show("Username can not be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
                tbUsername.Focus();
            }
            else if (password == null || password == string.Empty)
            {
                MessageBox.Show("Password can not be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
                tbPassword.Focus();
            }
            else if (role == null || role == string.Empty)
            {
                MessageBox.Show("Role can not be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
                cbbRole.Focus();
            }
            return isValid;
        }
        private void RedirectForm(string selectRole, int EmployeeID)
        {
            if (selectRole == null || selectRole == string.Empty) 
            { 
                MessageBox.Show("Role can not be blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (selectRole == "Admin")
            {
                    Admin adminForm = new Admin();
                    this.Hide();
                    adminForm.Show();
}
            else if (selectRole == "Sales")
            {
                Sales salesForm = new Sales();
                this.Hide();
                salesForm.Show();
            }
            else if (selectRole == "Warehouse")
            {
                Warehouse warehouseForm = new Warehouse();
                this.Hide();
                warehouseForm.Show();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
            cbbRole.SelectedIndex = 0;
            tbUsername.Focus();
        }
        private void ClearData()
        {
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
            cbbRole.SelectedIndex = 0;
            tbUsername.Focus();
        }
    }
}
