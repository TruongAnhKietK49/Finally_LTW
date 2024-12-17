using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManageStuDAO
{
    public class DataProvider
    {
        public static string connectionString
        {
            get
            {
                return "Data Source=DESKTOP-AT07G57\\SQLEXPRESS; Initial Catalog=BookStore_Management; Integrated Security=True; TrustServerCertificate = True;";
            }
        }

        public static bool TruyVan_XuLy(string sql)
        {
            try
            {
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                SqlCommand command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();
                connect.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static DataTable TruyVan_LayDuLieu(string sql)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public static void ExcuteNonQuery(string sql, CommandType cmdType, SqlParameter[] paras)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandText = sql;
            cmd.CommandType = cmdType;
            if (paras != null)
                cmd.Parameters.AddRange(paras);
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public static DataTable SelectData(string sql, CommandType cmdType, SqlParameter[] paras)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandText = sql;
            cmd.CommandType = cmdType;
            if (paras != null)
                cmd.Parameters.AddRange(paras);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            connect.Close();
            return dataTable;
        }
        public static object ExecuteScalar(string sql, CommandType cmdType, SqlParameter[] paras)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.CommandText = sql;
            cmd.CommandType = cmdType;

            if (paras != null)
            {
                cmd.Parameters.AddRange(paras);
            }

            object result = cmd.ExecuteScalar();
            connect.Close();

            return result;
        }
    }
}
