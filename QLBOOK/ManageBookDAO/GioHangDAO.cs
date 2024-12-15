using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageStuDAO;
using ManageBookDTO;

namespace MangeBookDAO
{
    public class GioHangDAO
    {
        public static void themGioHang(GioHangDTO cart)
        {
            string query = "INSERT INTO GioHang VALUES ('" + cart.MaKH + "', '" + cart.MaSach + "', " + cart.SoLuong + ", '" + cart.MaDV + "')";
            DataProvider.TruyVan_XuLy(query);

        }
        public static void xoaGioHang(GioHangDTO cart)
        {
            string query = "DELETE FROM GioHang WHERE MaKH = '" + cart.MaKH + "' AND MaSach = '" + cart.MaSach + "' AND MaDV = '" + cart.MaDV + "'";
            DataProvider.TruyVan_XuLy(query);
        }


    }
}
