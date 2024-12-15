using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookDTO
{
    public class KhachHangDTO
    {
            public string MaKH { get; set; } // Mã khách hàng (Primary Key)
            public string TenKH { get; set; } // Tên khách hàng (Unique, Not Null)
            public DateTime NgSinh { get; set; } // Ngày sinh
            public string Phai { get; set; } // Giới tính
            public string DiaChi { get; set; } // Địa chỉ
            public string Email { get; set; } // Email (Unique, Not Null)
            public string SDT { get; set; } // Số điện thoại (Unique, Not Null)
        

    }
}
