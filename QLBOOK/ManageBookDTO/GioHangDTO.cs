using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookDTO
{
    public class GioHangDTO
    {
        public string MaKH { get; set; } // Mã khách hàng (Foreign Key, Not Null)
        public string MaSach { get; set; } // Mã sách (Foreign Key, Not Null)
        public int SoLuong { get; set; } // Số lượng sách
        public string MaDV { get; set; } // Mã dịch vụ (Foreign Key, Not Null)

        // Tạo khóa chính gồm MaKH, MaSach, và MaDV
    }
}
