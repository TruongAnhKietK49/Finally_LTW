namespace ManageBookDTO
{
    public class SachDTO
    {
            public string MaSach { get; set; } // Mã sách
            public string TenSach { get; set; } // Tên sách
            public string TacGia { get; set; } // Tác giả
            public DateTime? NXB { get; set; } // Ngày xuất bản
            public string TheLoai { get; set; } // Thể loại
             public string TenDV { get; set; } // Tên dịch vụ
            public float GiaTien { get; set; } // Giá tiền
    }
}
