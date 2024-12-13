using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageBookDTO;
using ManageBookBus;

namespace ManageBookGUI
{
    public partial class FormSignInCustomer : Form
    {
        public FormSignInCustomer()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tBoxAccount.Text) || string.IsNullOrEmpty(tBoxPassword.Text))
            {
                MessageBox.Show("Vui lòng điền đày đủ thông tin!");
                return;
            }

            KhachHangDTO customer = new KhachHangDTO
            {
                Email = tBoxAccount.Text,
                SDT = tBoxPassword.Text
            };
            bool success = KhachHangBus.SignInCustomer(customer);
            if (success)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Close();
                FormMain mainForm = Application.OpenForms["FormMain"] as FormMain;
                if (mainForm != null)
                    mainForm.Hide();
                FormKH formKH = new FormKH(customer.TenKH);
                formKH.FormClosed += (s, args) =>
                {
                    if (mainForm != null)
                        mainForm.Show();
                };
                formKH.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
                tBoxAccount.Clear();
                tBoxPassword.Clear();
            }
        }
    }
}
