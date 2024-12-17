using ManageBookDTO;
using ManageStuDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangeBookDAO
{
    public class HoaDonDAO
    {
        // Lấy danh sách hóa đơn
        public List<HoaDonDTO> LayDanhSachHoaDon()
        {
            List<HoaDonDTO> list = new List<HoaDonDTO>();
            string query = "SELECT * FROM HoaDon";

            DataTable data = DataProvider.SelectData(query, CommandType.Text, null);

            foreach (DataRow row in data.Rows)
            {
                HoaDonDTO hoaDon = new HoaDonDTO(
                    row["MaHoaDon"].ToString(),
                    row["MaKhachHang"].ToString(),
                    row["MaSach"].ToString(),
                    row["MaDichVu"].ToString(),
                    int.Parse(row["SoLuong"].ToString()),
                    decimal.Parse(row["GiaSach"].ToString())
                );
                list.Add(hoaDon);
            }

            return list;
        }

        // Thêm hóa đơn
        public bool ThemHoaDon(HoaDonDTO hoaDon)
        {
            string query = "INSERT INTO HoaDon (MaHoaDon, MaKhachHang, MaSach, MaDichVu, SoLuong, GiaSach) " +
                           "VALUES (@MaHoaDon, @MaKhachHang, @MaSach, @MaDichVu, @SoLuong, @GiaSach)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoaDon", hoaDon.MaHoaDon),
                new SqlParameter("@MaKhachHang", hoaDon.MaKhachHang),
                new SqlParameter("@MaSach", hoaDon.MaSach),
                new SqlParameter("@MaDichVu", hoaDon.MaDichVu),
                new SqlParameter("@SoLuong", hoaDon.SoLuong),
                new SqlParameter("@GiaSach", hoaDon.GiaSach)
            };

            try
            {
                DataProvider.ExcuteNonQuery(query, CommandType.Text, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa hóa đơn
        public bool XoaHoaDon(string maHoaDon)
        {
            string query = "DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoaDon", maHoaDon)
            };

            try
            {
                DataProvider.ExcuteNonQuery(query, CommandType.Text, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Cập nhật hóa đơn
        public bool UpdateHoaDon(HoaDonDTO hoaDon)
        {
            string query = "UPDATE HoaDon " +
                           "SET MaKhachHang = @MaKhachHang, MaSach = @MaSach, MaDichVu = @MaDichVu, SoLuong = @SoLuong, GiaSach = @GiaSach " +
                           "WHERE MaHoaDon = @MaHoaDon";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoaDon", hoaDon.MaHoaDon),
                new SqlParameter("@MaKhachHang", hoaDon.MaKhachHang),
                new SqlParameter("@MaSach", hoaDon.MaSach),
                new SqlParameter("@MaDichVu", hoaDon.MaDichVu),
                new SqlParameter("@SoLuong", hoaDon.SoLuong),
                new SqlParameter("@GiaSach", hoaDon.GiaSach)
            };

            try
            {
                DataProvider.ExcuteNonQuery(query, CommandType.Text, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Tìm kiếm hóa đơn
        public List<HoaDonDTO> TimKiemHoaDon(string keyword)
        {
            List<HoaDonDTO> list = new List<HoaDonDTO>();
            string query = "SELECT * FROM HoaDon " +
                           "WHERE MaHoaDon LIKE @Keyword OR MaKhachHang LIKE @Keyword OR MaSach LIKE @Keyword";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Keyword", "%" + keyword + "%")
            };

            DataTable data = DataProvider.SelectData(query, CommandType.Text, parameters);

            foreach (DataRow row in data.Rows)
            {
                HoaDonDTO hoaDon = new HoaDonDTO(
                    row["MaHoaDon"].ToString(),
                    row["MaKhachHang"].ToString(),
                    row["MaSach"].ToString(),
                    row["MaDichVu"].ToString(),
                    int.Parse(row["SoLuong"].ToString()),
                    decimal.Parse(row["GiaSach"].ToString())
                );
                list.Add(hoaDon);
            }

            return list;
        }
    }
}