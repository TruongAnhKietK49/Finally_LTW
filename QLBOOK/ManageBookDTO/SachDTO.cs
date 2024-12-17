namespace ManageBookDTO
{
    public class SachDTO
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public decimal GiaSach { get; set; }

        // Constructor để tạo đối tượng Book
        public  SachDTO(string maSach, string tenSach, decimal giaSach)
        {
            MaSach = maSach;
            TenSach = tenSach;
            GiaSach = giaSach;
        }
    }
}
