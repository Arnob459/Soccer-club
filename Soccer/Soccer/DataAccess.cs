using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Soccer
{
    public static class DataAccess
    {
        private static string _connectionString =
            @"Data Source=WINDOWS-EKS4LMU;Initial Catalog=Soccer;Integrated Security=True";
        public static DataTable LoadData(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                return dt;
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }

        public static int ExecuteQuery(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                int row = cmd.ExecuteNonQuery();
                return row;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public static int ExecuteQuery1(string query)
        {
            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                int row = cmd.ExecuteNonQuery();
                return row;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
