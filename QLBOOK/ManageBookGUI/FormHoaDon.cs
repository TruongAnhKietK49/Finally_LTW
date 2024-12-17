using ManageBookBus;
using ManageBookDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageBookGUI
{
    public partial class FormHoaDon : Form
    {
        private HoaDonBus hoaDonBUS = new HoaDonBus();
        public FormHoaDon()
        {
            InitializeComponent();
            LoadDanhSachHoaDon();
        }

        private void LoadDanhSachHoaDon()
        {
            List<HoaDonDTO> list = hoaDonBUS.GetAllHoaDon();
            foreach (var hoaDon in list)
            {
                hoaDon.ThanhTien = hoaDon.SoLuong * hoaDon.GiaSach;
            }

            dataGridViewHoaDon.DataSource = list;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            List<HoaDonDTO> list = hoaDonBUS.TimKiemHoaDon(keyword);
            dataGridViewHoaDon.DataSource = list;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDonDTO hoaDon = new HoaDonDTO(
                    txtMaHoaDon.Text,
                    txtMaKhachHang.Text,
                    txtMaSach.Text,
                    txtMaDichVu.Text,
                    int.Parse(txtSoLuong.Text),
                    decimal.Parse(txtGiaSach.Text)
                );

                if (hoaDonBUS.AddHoaDon(hoaDon))
                {
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachHoaDon();
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ! \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHoaDon.Text;

            if (string.IsNullOrEmpty(maHoaDon))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hoaDonBUS.DeleteHoaDon(maHoaDon))
            {
                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachHoaDon();
            }
            else
            {
                MessageBox.Show("Xóa hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDonDTO hoaDon = new HoaDonDTO(
                    txtMaHoaDon.Text,
                    txtMaKhachHang.Text,
                    txtMaSach.Text,
                    txtMaDichVu.Text,
                    int.Parse(txtSoLuong.Text),
                    decimal.Parse(txtGiaSach.Text)
                );

                if (hoaDonBUS.UpdateHoaDon(hoaDon))
                {
                    MessageBox.Show("Sửa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachHoaDon();
                }
                else
                {
                    MessageBox.Show("Sửa hóa đơn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ! \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewHoaDon.Rows[e.RowIndex];

                txtMaHoaDon.Text = row.Cells["MaHoaDon"].Value.ToString();
                txtMaKhachHang.Text = row.Cells["MaKhachHang"].Value.ToString();
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtMaDichVu.Text = row.Cells["MaDichVu"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtGiaSach.Text = row.Cells["GiaSach"].Value.ToString();
            }
        }

        private void ThanhTien()
        {
            try
            {
                // Kiểm tra và chuyển đổi dữ liệu nhập
                int soLuong = 0;
                decimal giaSach = 0;

                if (int.TryParse(txtSoLuong.Text, out soLuong) && decimal.TryParse(txtGiaSach.Text, out giaSach))
                {
                    // Tính thành tiền
                    decimal thanhTien = soLuong * giaSach;

                    // Hiển thị thành tiền với định dạng số thập phân
                    txtThanhTien.Text = thanhTien.ToString("N2");
                }
                else
                {
                    // Trường hợp nhập sai định dạng hoặc trống
                    txtThanhTien.Text = "0.00";
                }
            }
            catch
            {
                // Trường hợp lỗi 
                txtThanhTien.Text = "0.00";
            }
        }
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void txtGiaSach_TextChanged(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void ListBOOKS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBOOKS.SelectedItem != null)
            {
                // Lấy thông tin sách từ listBooks 
                SachDTO selectedBook = (SachDTO)ListBOOKS.SelectedItem;

                // Cập nhật các ô nhập liệu với thông tin sách
                txtMaSach.Text = selectedBook.MaSach;
                txtGiaSach.Text = selectedBook.GiaSach.ToString(); 

                // Tính lại thành tiền
                ThanhTien();
            }
        }
    }
}
