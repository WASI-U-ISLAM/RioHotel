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
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = WASI-LENOVO\\SQLEXPRESS;Initial Catalog=\"RIO HOTEL\";Persist Security Info=True;User ID=sa;Password=w4a4s4i4;Encrypt=True;TrustServerCertificate=True ";
            return con;
        }

        public DataSet getData(String query) // Get Data from databsae
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query,String message) // Insertion Deletion Upadation 
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("'" + message + "'","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}