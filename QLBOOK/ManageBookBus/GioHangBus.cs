using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageBookDTO;
using ManageStuDAO;
using MangeBookDAO;

namespace ManageBookBus
{
    public class GioHangBus
    {
        public static bool ThemGioHang(GioHangDTO cart)
        {
            try
            {
                GioHangDAO.themGioHang(cart);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaGioHang(GioHangDTO cart)
        {
            try
            {
                // Gọi phương thức xóa giỏ hàng từ GioHangDAO
                GioHangDAO.xoaGioHang(cart);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }

}
