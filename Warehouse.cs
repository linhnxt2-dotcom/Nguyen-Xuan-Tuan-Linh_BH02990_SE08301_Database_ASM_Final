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
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
            LoadProductDataToImport();
            LoadSupplierData();
        }
        private void btnManageWarehouse_Click(object sender, EventArgs e)
        {
            pnManageWarehouse.BringToFront();
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
            cbbChooseProductImport.SelectedIndex = -1;
            cbbChooseSupplier.SelectedIndex = -1;
            tbImportQuantity.Clear();
            tbPriceImport.Clear();
        }

        private void btnImportHistory_Click(object sender, EventArgs e)
        {
            pnImportHistory.BringToFront();
            LoadImportHistory("");
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

        private void btnSearchImportHistory_Click(object sender, EventArgs e)
        {
            string keyword = tbSearchImportHistory.Text.Trim();
            LoadImportHistory(keyword);
        }
    }
}
