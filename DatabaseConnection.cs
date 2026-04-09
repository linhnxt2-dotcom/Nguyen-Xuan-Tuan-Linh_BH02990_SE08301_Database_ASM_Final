using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Nguyen_Xuan_Tuan_Linh_BH02990_SE08301_Database_ASM_Final
{
    internal class DatabaseConnection
    {
        private static string connectionString = 
            "Data Source=DESKTOP-8T8KN0V;Initial Catalog=Linh_Souvenir;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = null;
            try 
            { 
                connection = new SqlConnection(connectionString);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to create a database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }
    }
}
