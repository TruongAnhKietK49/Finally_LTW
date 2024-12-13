using ManageBookBus;
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
    public partial class FormSignUpCustomer : Form
    {
        public FormSignUpCustomer()
        {
            InitializeComponent();
        }
        private void LoadMaKH(object sender, EventArgs e)
        {
            tBoxMaKH.Text = KhachHangDAO.GetNewMaKH();
        }
        private void btnSignUpClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxTenKH.Text) || string.IsNullOrEmpty(tBoxAddress.Text)
                || string.IsNullOrEmpty(tBoxEmailKH.Text) || string.IsNullOrEmpty(tBoxSDT.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để đăng ký!");
                return;
            }
            KhachHangDTO customer = new KhachHangDTO
            {
                MaKH = tBoxMaKH.Text,
                TenKH = tBoxTenKH.Text,
                NgSinh = dateTimeNgSinh.Value.ToString("yyyy-MM-dd"),
                Phai = rBtnNam.Checked ? "Nam" : "Nữ",
                DiaChi = tBoxAddress.Text,
                Email = tBoxEmailKH.Text,
                SDT = tBoxSDT.Text
            };
            try
            {
                bool success = KhachHangBus.AddCustomer(customer);
                if (success) 
                { 
                    MessageBox.Show("Đã tạo tài khoản thành công!\n" +
                        "Tài khoản: " + tBoxEmailKH.Text + "\n" +
                        "Mật khẩu: " + tBoxSDT.Text);
                    this.Close();
                }
                else { MessageBox.Show("Tạo tài khoản thất bại!"); }
            }
            catch (Exception ex) { MessageBox.Show($"Lỗi khi tạo tài khoản: {ex.Message}"); }
        }
    }
}
