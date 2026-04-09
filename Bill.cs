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
    public partial class Bill : Form
    {
        public Bill(string employeeName, string customerName, DataTable cartData, string totalAmount)
        {
            InitializeComponent();
            lbEmployeeInvoice.Text = "Staff: " + employeeName;
            lbCustomerInvoice.Text = "Customer: " + customerName;
            lbDatetimeInvoice.Text = "Date: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            dtgBillInvoice.DataSource = cartData;
            lbTotalMoneyInvoice.Text = "Total Amount: " + totalAmount;
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmInvoice_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
