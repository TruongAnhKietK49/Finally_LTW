using ManageBookDTO;
using ManageStuDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MangeBookDAO
{
    public class DichVuDAO
    {
        public static List<DichVuDTO> GetListDV()
        {
            List<DichVuDTO> listDV = new List<DichVuDTO>();
            try
            {
                DataTable dtDV = DataProvider.TruyVan_LayDuLieu("Select * From DV");
                foreach (DataRow row in dtDV.Rows)
                {
                    DichVuDTO dvDTO = new DichVuDTO
                    {
                        MaDV = row["MaDV"].ToString(),
                        TenDV = row["TenDV"].ToString(),
                        MaSach = row["MaSach"].ToString(),
                        GiaTien = row["GiaTien"].ToString()
                    };

                    listDV.Add(dvDTO);
                }
                return listDV;
            }
            catch
            {
                listDV.Clear();
            }
            return listDV;
        }
        public static string GetNewMaDV()
        {
            try
            {
                string query = "SELECT MAX(MaDV) FROM DichVu";
                object result = DataProvider.ExecuteScalar(query, CommandType.Text, null);

                if (result == null || result == DBNull.Value)
                {
                    return "DV.001";
                }

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

                string newMaSach = $"{prefix}{newNumber:D3}";
                return newMaSach;


            }
            catch
            {
                return "DV.001";
            }
        }

        public static void themDV(DichVuDTO dvDTO)
        {
            try
            {
                DataProvider.TruyVan_XuLy("Insert into DichVu values('" + dvDTO.MaDV + "',N'" + dvDTO.TenDV + "',N'"
                  + dvDTO.MaSach + "',N'" + dvDTO.GiaTien + "')");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm dịch vụ: {ex.Message}");
                throw ex;
            }

        }

        public static void suaDV(DichVuDTO dvDTO)
        {
            string query = "UPDATE DichVu SET TenDV=@TenDV, MaSach=@MaSach, GiaTien=@GiaTien WHERE MaDV=@MaDV";
            SqlParameter[] parameters =
            {
        new SqlParameter("@MaDV", dvDTO.MaDV),
        new SqlParameter("@TenDV", dvDTO.TenDV),
        new SqlParameter("@MaSach", dvDTO.MaSach),
        new SqlParameter("@GiaTien", dvDTO.GiaTien),
    };

            DataProvider.ExcuteNonQuery(query, CommandType.Text, parameters);
        }

        public static void xoaDV(DichVuDTO dvDTO)
        {
            DataProvider.TruyVan_XuLy("Delete From DichVu Where MaDV = " + "'" + dvDTO.MaDV + "'");
        }

        public static string GetMaDVByMaSach(string maSach, string tenDV)
        {
            try
            {
                string query = "SELECT MaDV FROM DichVu WHERE MaSach = @MaSach AND TenDV = @TenDV";
                SqlParameter[] parameters =
                {
                    new SqlParameter("@MaSach", maSach),
                    new SqlParameter("@TenDV", tenDV)
                };

                object result = DataProvider.ExecuteScalar(query, CommandType.Text, parameters);

                if (result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy mã dịch vụ: {ex.Message}");
            }

            return null;
        }
    }
}
