using ManageBookDTO;
using ManageStuDAO;
using System.Data;
using System.Data.SqlClient;

namespace MangeBookDAO
{
    public class KhachHangDAO
    {
        public static string GetNewMaKH()
        {
            try
            {
                string query = "Select MAX(MaKH) From KhachHang";
                object result = DataProvider.ExecuteScalar(query, CommandType.Text, null);
                if (result == null || result == DBNull.Value)
                    return "KH.001";

                string resultStr = result.ToString();
                int index = 0;
                while (index < resultStr.Length && !char.IsDigit(resultStr[index]))
                {
                    index++;
                }

                string prefix = resultStr.Substring(0, index);
                string numericPart = resultStr.Substring(index);

                int currentNumber = int.Parse(numericPart);
                int newNumber = currentNumber + 1;

                string newClassID = $"{prefix}{newNumber:D3}";
                return newClassID;
            }
            catch { return "KH.001"; }
        }
        public static void AddCustomer(KhachHangDTO customer)
        {
            DataProvider.TruyVan_XuLy("Insert into KhachHang values('" + customer.MaKH + "',N'" + customer.TenKH + 
                "',N'" + customer.NgSinh + "',N'" + customer.Phai + "',N'" + customer.DiaChi + "',N'" + customer.Email + "',N'" + customer.SDT + "')");
        }
        public static string SignIn(KhachHangDTO customer)
        {
            try
            {
                string query = "Select *From KhachHang Where Email = '" + customer.Email + "' and SDT = '" + customer.SDT + "'";
                DataTable dataTable = DataProvider.TruyVan_LayDuLieu(query);
                if (dataTable.Rows.Count > 0)
                {
                    customer.MaKH = dataTable.Rows[0]["MaKH"].ToString();
                    customer.TenKH = dataTable.Rows[0]["TenKH"].ToString();
                    customer.NgSinh = dataTable.Rows[0]["NgSinh"].ToString();
                    customer.Phai = dataTable.Rows[0]["Phai"].ToString();
                    customer.DiaChi = dataTable.Rows[0]["DiaChi"].ToString();
                    customer.Email = dataTable.Rows[0]["Email"].ToString();
                    customer.SDT = dataTable.Rows[0]["SDT"].ToString();
                    return customer.TenKH;
                }
                else return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
