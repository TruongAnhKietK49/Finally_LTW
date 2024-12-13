using ManageBookDTO;
using ManageStuDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangeBookDAO
{
    public class NhanVienDAO
    {
        public static string SignInEmployee(NhanVienDTO employee)
        {
            try
            {
                string query = "Select *From NhanVien Where Email = '" + employee.Email + "' and SDT = '" + employee.SDT + "'";
                DataTable dataTable = DataProvider.TruyVan_LayDuLieu(query);
                if (dataTable.Rows.Count > 0)
                {
                    employee.MaNV = dataTable.Rows[0]["MaNV"].ToString();
                    employee.TenNV = dataTable.Rows[0]["TenNV"].ToString();
                    employee.NgSinh = dataTable.Rows[0]["NgSinh"].ToString();
                    employee.Phai = dataTable.Rows[0]["Phai"].ToString();
                    employee.DiaChi = dataTable.Rows[0]["DiaChi"].ToString();
                    employee.Email = dataTable.Rows[0]["Email"].ToString();
                    employee.SDT = dataTable.Rows[0]["SDT"].ToString();
                    return employee.TenNV;
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
