using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBookDTO
{
    public class DichVuDTO
    {
            public string MaDV { get; set; } // Mã dịch vụ (Primary Key)
            public string TenDV { get; set; } // Tên dịch vụ
            public string MaSach { get; set; } // Mã sách (Foreign Key)
            public float GiaTien { get; set; } // Giá tiền
      
    }
}
