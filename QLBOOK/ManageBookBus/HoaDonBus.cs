using ManageBookDTO;
using MangeBookDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookBus
{
    public class HoaDonBus
    {
        private HoaDonDAO hoaDonDAO = new HoaDonDAO();

        // Lấy danh sách hóa đơn
        public List<HoaDonDTO> GetAllHoaDon()
        {
            return hoaDonDAO.LayDanhSachHoaDon();
        }

        // Thêm hóa đơn
        public bool AddHoaDon(HoaDonDTO hoaDon)
        {
            return hoaDonDAO.ThemHoaDon(hoaDon);
        }

        // Xóa hóa đơn
        public bool DeleteHoaDon(string maHoaDon)
        {
            return hoaDonDAO.XoaHoaDon(maHoaDon);
        }
        // Cập Nhật hóa đơn
        public bool UpdateHoaDon(HoaDonDTO hoaDon)
        {
            return hoaDonDAO.UpdateHoaDon(hoaDon);
        }

        // Tìm kiếm hóa đơn
        public List<HoaDonDTO> TimKiemHoaDon(string keyword)
        {
            return hoaDonDAO.TimKiemHoaDon(keyword);
        }
    }
}
