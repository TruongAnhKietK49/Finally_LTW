using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ManageBookBus;
using ManageBookDAO;
using ManageBookDTO;
using ManageStuDAO;
using System.Data.SqlClient;

namespace ManageBookGUI
{
    public partial class FormKH : Form
    {
        private int selectedRowIndex = -1;

        public FormKH()
        {
            InitializeComponent();

        }

        private void FormKH_Load(object sender, EventArgs e)
        {
            GetData();
            GetData2();
            LoadTongSoLuong();
        }
        private void GetData()
        {
            try
            {
                string sql = @"SELECT Sach.MaSach, Sach.TenSach, Sach.TacGia, Sach.NXB, Sach.TheLoai, DichVu.GiaTien, DichVu.TenDV, DichVu.MaDV
                       FROM Sach
                       LEFT JOIN DichVu ON Sach.MaSach = DichVu.MaSach";

                DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
                dataGridView1.AutoGenerateColumns = true; // Bật tự động tạo cột
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dt != null && dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu!");
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        private void GetData2()
        {
            try
            {

                // Lấy giá trị thời hạn thuê từ txtThoiHanThue
                int thoiHanThue = txtThoiHanThue.Visible ?
                int.Parse(txtThoiHanThue.Text) : 0; // Kiểm tra nếu TextBox thời hạn thuê hiển thị
                                                    // Câu truy vấn SQL để lấy dữ liệu từ bảng GioHang và tính Giá Tiền = Giá Tiền * Số Lượng
                string sql = 
                    @" SELECT 
                    Sach.MaSach,
                    Sach.TenSach, 
                    GioHang.SoLuong,
                    DichVu.MaDV,
                    CASE 
                    WHEN DichVu.TenDV = 'bán' THEN (DichVu.GiaTien * GioHang.SoLuong)
                    WHEN DichVu.TenDV = 'thuê' THEN (1 * DichVu.GiaTien * GioHang.SoLuong) 
                    ELSE 0
                            END AS ThanhTien
                        FROM 
                            GioHang  
                        INNER JOIN 
                            KhachHang ON GioHang.MaKH = KhachHang.MaKH 
                        INNER JOIN 
                            Sach ON GioHang.MaSach = Sach.MaSach 
                        INNER JOIN 
                            DichVu ON GioHang.MaDV = DichVu.MaDV";

                // Sử dụng DataProvider để lấy dữ liệu
                DataTable dt = DataProvider.TruyVan_LayDuLieu(sql);
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Giả sử dataGridView2 là tên DataGridView trên form

                // Nếu có dữ liệu, hiển thị lên DataGridView
                if (dt != null && dt.Rows.Count > 0)
                {
                    dataGridView2.DataSource = dt;
                    LoadTongThanhTien();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu trong giỏ hàng!");
                }
            }
            catch (Exception ex)
            {
                //    MessageBox.Show("Lỗi khi lấy dữ liệu giỏ hàng: " + ex.Message);
            }
        }
        private void LoadTongSoLuong()
        {
            try
            {
                string query = "SELECT SUM(SoLuong) AS TongSoLuong FROM GioHang";
                object result = DataProvider.ExecuteScalar(query, CommandType.Text, null);

                if (result != DBNull.Value && result != null)
                {
                    txtTongSoLuong.Text = result.ToString();
                }
                else
                {
                    txtTongSoLuong.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void LoadTongThanhTien()
        {
            try
            {
                // Biến lưu tổng thành tiền
                decimal tongThanhTien = 0;

                // Duyệt qua tất cả các dòng trong DataGridView2 để tính tổng
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    // Kiểm tra nếu dòng không phải là dòng trống
                    if (row.Cells["ThanhTien"].Value != DBNull.Value)
                    {
                        // Cộng dồn giá trị thanh tiền vào tổng
                        tongThanhTien += Convert.ToDecimal(row.Cells["ThanhTien"].Value);
                    }
                }

                // Hiển thị tổng thành tiền lên TextBox
                txtTongThanhTien.Text = tongThanhTien.ToString("N0") + " VNĐ"; // N0 để hiển thị dạng số nguyên
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tổng thành tiền: " + ex.Message);
            }
        }



        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            txtMaSach.Text = dataGridView1.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
            txtTenSach.Text = dataGridView1.Rows[e.RowIndex].Cells["TenSach"].Value.ToString();
            txtLoaiSach.Text = dataGridView1.Rows[e.RowIndex].Cells["TheLoai"].Value.ToString();
            txtGia.Text = dataGridView1.Rows[e.RowIndex].Cells["GiaTien"].Value.ToString() + " VNĐ";
            txtTenDV.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDV"].Value.ToString();
            txtMaDV.Text= dataGridView1.Rows[e.RowIndex].Cells["TenDV"].Value.ToString();
            // Kiểm tra tên dịch vụ, nếu là "Thuê" thì hiển thị TextBox thời hạn thuê
            if (txtMaDV.Text == "Thuê")
            {
                // Hiển thị TextBox thời hạn thuê
                txtThoiHanThue.Visible = true;
                lblThoiHanThue.Visible = true; // Nếu bạn có Label cho TextBox thời hạn thuê, bạn cũng cần hiển thị nó
            }
            else
            {
                // Ẩn TextBox thời hạn thuê nếu dịch vụ không phải là "Thuê"
                txtThoiHanThue.Visible = false;
                lblThoiHanThue.Visible = false;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string tenSach = txtSearch.Text.Trim();
            try
            {
                List<SachDTO> dsSach = string.IsNullOrEmpty(tenSach)
                    ? SachDAO.layDSSach()
                    : SachDAO.timTheoTenSach(tenSach);

                if (dsSach != null && dsSach.Count > 0)
                {
                    dataGridView1.DataSource = dsSach;
                }
                else
                {
                    dataGridView1.DataSource = null;
                    //MessageBox.Show("Không tìm thấy sách phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemGH_Click(object sender, EventArgs e)
        {
            // Đảo trạng thái hiển thị của Panel
            panelGH.Visible = !panelGH.Visible;
        }

        private void sửThiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemGH_Click(object sender, EventArgs e)
        {
            try
            {

                GioHangDTO cart = new GioHangDTO
                {
                    MaKH = "KH.001",
                    MaSach = txtMaSach.Text,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    MaDV = txtTenDV.Text,
                };

                bool result = GioHangBus.ThemGioHang(cart);

                if (result)
                {
                    MessageBox.Show("Thêm giỏ hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetData2(); // Tải lại dữ liệu giỏ hàng
                    LoadTongSoLuong(); // Cập nhật tổng số lượng
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm giỏ hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaGH_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn trong DataGridView2 không
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    // Lấy dòng được chọn từ DataGridView
                    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                    // Tạo đối tượng GioHangDTO từ các giá trị của dòng đã chọn
                    GioHangDTO cart = new GioHangDTO
                    {
                        MaKH = "KH.001",   // Tên cột tương ứng
                        MaSach = selectedRow.Cells["MaSach"].Value.ToString(), // Tên cột tương ứng
                        SoLuong = int.Parse(selectedRow.Cells["SoLuong"].Value.ToString()), // Tên cột tương ứng
                        MaDV = selectedRow.Cells["MaDV"].Value.ToString(),    // Tên cột tương ứng
                    };

                    // Gọi phương thức xóa từ lớp Bus
                    bool result = GioHangBus.XoaGioHang(cart);

                    if (result)
                    {
                        MessageBox.Show("Xóa giỏ hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetData2(); // Tải lại dữ liệu giỏ hàng
                        LoadTongSoLuong(); // Cập nhật tổng số lượng
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa giỏ hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn giỏ hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
