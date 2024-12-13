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
    public partial class FormSignInEmployee : Form
    {
        public FormSignInEmployee()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tBoxAccount.Text) || string.IsNullOrEmpty(tBoxPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            NhanVienDTO emp = new NhanVienDTO
            {
                Email = tBoxAccount.Text,
                SDT = tBoxPassword.Text
            };
            bool success = NhanVienBus.SignInEmployee(emp);
            if (success)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Close();
                FormMain mainForm = Application.OpenForms["FormMain"] as FormMain;
                if (mainForm != null)
                    mainForm.Hide();
                FormNV formNV = new FormNV(emp.TenNV);
                formNV.FormClosed += (s, args) =>
                {
                    if (mainForm != null)
                        mainForm.Show();
                };
                formNV.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
                tBoxAccount.Clear();
                tBoxPassword.Clear();
            }
        }
    }
}
