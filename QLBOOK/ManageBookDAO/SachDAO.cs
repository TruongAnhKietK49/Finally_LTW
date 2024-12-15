using ManageBookDTO;
using ManageStuDAO;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace ManageBookDAO
{
    public class SachDAO
    {
        public static List<SachDTO> GetListBook()
        {
            List<SachDTO> listSach = new List<SachDTO>();
            try
            {
                string query = "SELECT Sach.*, GiaBan = MAX(CASE WHEN DichVu.TenDV = N'Bán' THEN DichVu.GiaTien END)," +
                    "GiaThue = MAX(CASE WHEN DichVu.TenDV = N'Thuê' THEN DichVu.GiaTien END)\r\nFROM Sach\r\nLEFT JOIN DichVu ON Sach.MaSach = DichVu.MaSach\r\n" +
                    "GROUP BY Sach.MaSach, Sach.TenSach, Sach.TacGia, Sach.NXB, Sach.TheLoai, Sach.MaNV;";

                DataTable dtSach = DataProvider.TruyVan_LayDuLieu(query);
                foreach (DataRow row in dtSach.Rows)
                {
                    SachDTO sachDTO = new SachDTO
                    {
                        MaSach = row["MaSach"].ToString(),
                        TenSach = row["TenSach"].ToString(),
                        TacGia = row["TacGia"].ToString(),
                        TheLoai = row["TheLoai"].ToString(),
                        NXB = row["NXB"].ToString(),
                        MaNV = row["MaNV"].ToString(),
                        GiaBan = row["GiaBan"] != DBNull.Value ? Convert.ToSingle(row["GiaBan"]) : 0,
                        GiaThue = row["GiaThue"] != DBNull.Value ? Convert.ToSingle(row["GiaThue"]) : 0

                    };

                    listSach.Add(sachDTO);
                }
                return listSach;
            }
            catch
            {
                listSach.Clear();
            }
            return listSach;
        }
        public static string GetNewMaSach()
        {
            try
            {
                string query = "SELECT MAX(MaSach) FROM Sach";
                object result = DataProvider.ExecuteScalar(query, CommandType.Text, null);

                if (result == null || result == DBNull.Value)
                {
                    return "S.001";
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
                return "S.001";
            }
        }


        public static void themSach(SachDTO sachDTO)
        {
            try
            {
                DataProvider.TruyVan_XuLy("Insert into Sach values('" + sachDTO.MaSach + "',N'" + sachDTO.TenSach + "',N'"
                  + sachDTO.TacGia + "',N'" + sachDTO.NXB + "',N'" + sachDTO.TheLoai + "',N'" + sachDTO.MaNV + "')");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm sách: {ex.Message}");
                throw ex;
            }

        }

        public static void themDV(DichVuDTO dvDTO)
        {
            try
            {
                DataProvider.TruyVan_XuLy("Insert into DichVu values('" + dvDTO.TenDV + "',N'"
                  + dvDTO.MaSach + "',N'" + dvDTO.GiaTien + "')");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm dịch vụ: {ex.Message}");
                throw ex;
            }

        }

        public static void suaSach(SachDTO sachDTO)
        {

            string query = "UPDATE Sach SET TenSach = @TenSach, TacGia = @TacGia, NXB = @NXB, TheLoai=@TheLoai WHERE MaSach=@MaSach";
            SqlParameter[] parameters =
            {
                new SqlParameter("@TenSach", sachDTO.TenSach),
                new SqlParameter("@TacGia", sachDTO.TacGia),
                new SqlParameter("@NXB", sachDTO.NXB),
                new SqlParameter("@TheLoai", sachDTO.TheLoai),
                new SqlParameter("@MaSach", sachDTO.MaSach)
            };

            DataProvider.ExcuteNonQuery(query, CommandType.Text, parameters);
        }

        public static void xoaSach(SachDTO sachDTO)
        {
            DataProvider.TruyVan_XuLy("Delete From Sach Where MaSach = " + "'" + sachDTO.MaSach + "'");
        }

        public static List<SachDTO> TimKiemSachTheoTen(string tenSach)
        {
            List<SachDTO> listSach = new List<SachDTO>();
            try
            {
                string query = "SELECT s.MaSach, s.TenSach, s.TacGia, s.NXB, s.TheLoai, s.MaNV, MAX(CASE WHEN dv.TenDV = N'Bán' THEN dv.GiaTien END) AS GiaBan, MAX(CASE WHEN dv.TenDV = N'Thuê' THEN dv.GiaTien END) AS GiaThue \r\nFROM Sach s JOIN DichVu dv ON s.MaSach = dv.MaSach \r\nWHERE s.TenSach LIKE @TenSach\r\nGROUP BY s.MaSach, s.TenSach, s.TacGia, s.NXB, s.TheLoai, s.MaNV;";
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@TenSach", "%" + tenSach + "%");

                DataTable dtSach = DataProvider.SelectData(query, CommandType.Text, parameters);
                foreach (DataRow row in dtSach.Rows)
                {
                    SachDTO sachDTO = new SachDTO
                    {
                        MaSach = row["MaSach"].ToString(),
                        TenSach = row["TenSach"].ToString(),
                        TacGia = row["TacGia"].ToString(),
                        TheLoai = row["TheLoai"].ToString(),
                        NXB = row["NXB"].ToString(),
                        MaNV = row["MaNV"].ToString(),
                        GiaBan = row["GiaBan"] != DBNull.Value ? Convert.ToSingle(row["GiaBan"]) : 0,
                        GiaThue = row["GiaThue"] != DBNull.Value ? Convert.ToSingle(row["GiaThue"]) : 0

                    };
                    listSach.Add(sachDTO);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tìm kiếm sách: " + ex.Message);
                throw ex;
            }
            return listSach;
        }

    }
}
