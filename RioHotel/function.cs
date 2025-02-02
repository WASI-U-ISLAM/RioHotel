using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RioHotel
{
    class function
    {
        private string connectionString = "Data Source=WASI-LENOVO\\SQLEXPRESS;Initial Catalog=\"RIO HOTEL\";Persist Security Info=True;User ID=sa;Password=w4a4s4i4;Encrypt=True;TrustServerCertificate=True";

        public SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataSet getData(string query)
        {
            using (SqlConnection conn = getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public void setData(string query, string message)
        {
            using (SqlConnection con = getConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public SqlDataReader getforCombo(string query)
        {
            SqlConnection con = getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd.ExecuteReader();  // Caller must close the reader
        }
    }
}
