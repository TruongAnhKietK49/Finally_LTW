using ManageBookDTO;
using ManageStuDAO;
using System.Data;
using System.Data.SqlClient;


namespace ManageBookDAO
{
    public class SachDAO
    {
        public static List<SachDTO> layDSSach()
        {
            List<SachDTO> dsSach = new List<SachDTO>();

            try
            {
                // Câu truy vấn SQL để lấy dữ liệu từ bảng Sach kết hợp với bảng DichVu
                string sql = "SELECT Sach.MaSach, Sach.TenSach, Sach.TacGia, Sach.NXB, Sach.TheLoai, DichVu.GiaTien, DichVu.TenDV " +
                             "FROM Sach " +
                             "LEFT JOIN DichVu ON Sach.MaSach = DichVu.MaSach"; // Kết hợp bảng Sach và DichVu

                // Sử dụng DataProvider để lấy dữ liệu từ câu truy vấn SQL
                DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);

                // Kiểm tra xem có dữ liệu trả về từ truy vấn
                if (dt != null && dt.Rows.Count > 0)
                {
                    // Duyệt qua từng dòng trong DataTable và tạo đối tượng SachDTO
                    foreach (DataRow r in dt.Rows)
                    {
                        SachDTO sach = new SachDTO
                        {
                            MaSach = r["MaSach"].ToString(),
                            TenSach = r["TenSach"].ToString(),
                            TacGia = r["TacGia"].ToString(),
                            TheLoai = r["TheLoai"].ToString(),
                            NXB = r["NXB"] != DBNull.Value ? (DateTime?)r["NXB"] : null, // Kiểm tra nếu NXB có giá trị
                            GiaTien = r["GiaTien"] != DBNull.Value ? (float)Convert.ToDouble(r["GiaTien"]) : 0f, // Kiểm tra nếu GiaTien có giá trị
                            TenDV = r["TenDV"].ToString() // Kiểm tra nếu TenDV có giá trị
                        };
                        // Thêm đối tượng sách vào danh sách
                        dsSach.Add(sach);
                    }
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
            }

            // Trả về danh sách sách
            return dsSach;
        }




        public static List<SachDTO> timTheoTenSach(string ten)
        {
            List<SachDTO> dsSach = new List<SachDTO>();

            // Tham số truyền vào cho câu lệnh SQL
            SqlParameter[] pa = new SqlParameter[1];
            pa[0] = new SqlParameter("Ten", ten);

            // Truy vấn dữ liệu từ bảng Sach kết hợp với bảng DichVu
            string sql = "SELECT Sach.MaSach, Sach.TenSach, Sach.TacGia, Sach.TheLoai, Sach.NXB, DichVu.GiaTien, DichVu.TenDV " +
                         "FROM Sach " +
                         "LEFT JOIN DichVu ON Sach.MaSach = DichVu.MaSach " +
                         "WHERE Sach.TenSach LIKE N'%' + @Ten + '%'";

            // Truy vấn dữ liệu và lấy kết quả
            DataTable dtSach = DataProvider.SelectData(sql, CommandType.Text, pa);

            // Duyệt qua từng dòng dữ liệu để tạo danh sách đối tượng SachDTO
            foreach (DataRow r in dtSach.Rows)
            {
                SachDTO sach = new SachDTO
                {
                    MaSach = r["MaSach"].ToString(),
                    TenSach = r["TenSach"].ToString(),
                    TacGia = r["TacGia"].ToString(),
                    TheLoai = r["TheLoai"].ToString(),
                    TenDV = r["TenDV"] != DBNull.Value ? r["TenDV"].ToString() : "",  // Thêm tên dịch vụ
                    GiaTien = r["GiaTien"] != DBNull.Value ? (float)Convert.ToDouble(r["GiaTien"]) : 0f  // Thêm giá tiền
                };

                if (r["NXB"] != DBNull.Value)
                    sach.NXB = DateTime.Parse(r["NXB"].ToString());

                // Thêm đối tượng sach vào danh sách
                dsSach.Add(sach);
            }

            return dsSach;
        }


    }



}
