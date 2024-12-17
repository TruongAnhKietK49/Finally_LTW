using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookDTO
{
    public class HoaDonDTO
    {
        public string MaHoaDon { get; set; }
        public string MaKhachHang { get; set; }
        public string MaSach { get; set; }
        public string MaDichVu { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaSach { get; set; }
        public decimal ThanhTien { get; set; }
        public HoaDonDTO() { }

        public HoaDonDTO(string maHoaDon, string maKhachHang, string maSach, string maDichVu, int soLuong, decimal giaSach)
        {
            MaHoaDon = maHoaDon;
            MaKhachHang = maKhachHang;
            MaSach = maSach;
            MaDichVu = maDichVu;
            SoLuong = soLuong;
            GiaSach = giaSach;
            ThanhTien = soLuong * giaSach;
        }
    }
}
