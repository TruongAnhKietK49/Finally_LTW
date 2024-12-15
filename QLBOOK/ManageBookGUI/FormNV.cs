using ManageBookBus;
using ManageBookDAO;
using ManageBookDTO;
using MangeBookDAO;
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
    public partial class FormNV : Form
    {
        string TenNV;
        public FormNV(string TenNV)
        {
            InitializeComponent();
            this.TenNV = TenNV;
            txtMaSach.ReadOnly = true;
        }

        private void FormNV_Load(object sender, EventArgs e)
        {
            labelTenNV.Text = $"Chào mừng, {TenNV}!";
            txtMaSach.Text = SachDAO.GetNewMaSach();
            LoadDataSach();
            labelAdmin.Text = $"{TenNV}";
        }

        private void LoadDataSach()
        {
            try
            {
                var danhSachSach = SachBus.GetListBook();
                dgvQLSach.DataSource = danhSachSach;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách sách: {ex.Message}");
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSach.Text) || string.IsNullOrEmpty(txtTacGia.Text) || string.IsNullOrEmpty(txtTheLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách.");
                return;
            }


            DichVuDAO.GetNewMaDV();

            if (!float.TryParse(txtGiaBan.Text, out float giaBan))
            {
                MessageBox.Show("Giá bán không hợp lệ!");
                return;
            }
            if (!float.TryParse(txtGiaThue.Text, out float giaThue))
            {
                MessageBox.Show("Giá thuê không hợp lệ!");
                return;
            }

            SachDTO sachMoi = new SachDTO
            {
                MaSach = txtMaSach.Text,
                TenSach = txtTenSach.Text,
                TacGia = txtTacGia.Text,
                NXB = dateTimePickerNXB.Value.ToString("yyyy-MM-dd"),
                TheLoai = txtTheLoai.Text,
                MaNV = txtMaNV.Text,
                GiaBan = giaBan,
                GiaThue = giaThue
            };


            try
            {

                bool themThanhCong = SachBus.themSach(sachMoi);
                if (themThanhCong)
                {

                    DichVuBus.themDV(new DichVuDTO
                    {
                        MaDV = DichVuDAO.GetNewMaDV(),
                        MaSach = sachMoi.MaSach,
                        TenDV = "Bán",
                        GiaTien = sachMoi.GiaBan.ToString(),
                    });

                    DichVuBus.themDV(new DichVuDTO
                    {
                        MaDV = DichVuDAO.GetNewMaDV(),
                        MaSach = sachMoi.MaSach,
                        TenDV = "Thuê",
                        GiaTien = sachMoi.GiaThue.ToString(),
                    });



                    MessageBox.Show("Thêm sách thành công!");
                    LoadDataSach();
                }
                else
                {
                    MessageBox.Show("Thêm sách thất bại!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }

            Reset();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvQLSach.SelectedRows.Count > 0)
            {
                if (!float.TryParse(txtGiaBan.Text, out float giaBan))
                {
                    MessageBox.Show("Giá bán không hợp lệ!");
                    return;
                }
                if (!float.TryParse(txtGiaThue.Text, out float giaThue))
                {
                    MessageBox.Show("Giá thuê không hợp lệ!");
                    return;
                }
                SachDTO sachSua = new SachDTO
                {
                    MaSach = dgvQLSach.SelectedRows[0].Cells["MaSach"].Value.ToString(),
                    TenSach = txtTenSach.Text,
                    TacGia = txtTacGia.Text,
                    NXB = dateTimePickerNXB.Value.ToString("yyyy-MM-dd"),
                    TheLoai = txtTheLoai.Text,
                    MaNV = txtMaNV.Text,
                    GiaBan = giaBan,
                    GiaThue = giaThue
                };

                try
                {
                    string maDVBan = DichVuDAO.GetMaDVByMaSach(sachSua.MaSach, "Bán");
                    string maDVThue = DichVuDAO.GetMaDVByMaSach(sachSua.MaSach, "Thuê");

                    if (SachBus.suaSach(sachSua))
                    {
                        if (maDVBan != null)
                        {
                            DichVuBus.suaDV(new DichVuDTO
                            {
                                MaDV = maDVBan,
                                MaSach = sachSua.MaSach,
                                TenDV = "Bán",
                                GiaTien = sachSua.GiaBan.ToString(),
                            });
                        }

                        if (maDVThue != null)
                        {
                            DichVuBus.suaDV(new DichVuDTO
                            {
                                MaDV = maDVThue,
                                MaSach = sachSua.MaSach,
                                TenDV = "Thuê",
                                GiaTien = sachSua.GiaThue.ToString(),
                            });
                        }

                        MessageBox.Show("Sửa sách thành công!");
                        LoadDataSach();
                    }
                    else
                    {
                        MessageBox.Show("Sửa sách thất bại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi sửa sách: {ex.Message}");
                }
            }
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvQLSach.SelectedRows.Count > 0)
            {
                string maSach = dgvQLSach.SelectedRows[0].Cells["MaSach"].Value.ToString();

                SachDTO xoaSach = new SachDTO
                {
                    MaSach = maSach
                };

                if (SachBus.xoaSach(xoaSach))
                {
                    MessageBox.Show("Xóa sách thành công!");
                    LoadDataSach();
                }
                else
                {
                    MessageBox.Show("Xóa sách thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để xóa.");
            }
            Reset();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenSach = txtTimKiemSach.Text;
            if (!string.IsNullOrEmpty(tenSach))
            {
                List<SachDTO> listSach = SachBus.TimKiemSachTheoTen(tenSach);

                if (listSach.Count > 0)
                {
                    dgvQLSach.DataSource = listSach;
                    dgvQLSach.Refresh();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách với tên '" + tenSach + "'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên sách cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Reset()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtTheLoai.Clear();
            txtMaNV.Clear();
            txtGiaBan.Clear();
            txtGiaThue.Clear();
            txtTimKiemSach.Clear();
        }

        private void dgvQLSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQLSach.Rows[e.RowIndex];

                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value.ToString();
                txtTacGia.Text = row.Cells["TacGia"].Value.ToString();
                txtTheLoai.Text = row.Cells["TheLoai"].Value.ToString();
                dateTimePickerNXB.Value = Convert.ToDateTime(row.Cells["NXB"].Value);
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
                txtGiaThue.Text = row.Cells["GiaThue"].Value.ToString();
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            Reset();
            LoadDataSach();
        }
    }
}
