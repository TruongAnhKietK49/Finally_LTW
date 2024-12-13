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
    public partial class FormKH : Form
    {
        string TenKH;
        public FormKH(string TenKH)
        {
            InitializeComponent();
            this.TenKH = TenKH;
        }

        private void FormKH_Load(object sender, EventArgs e)
        {
            labelTenKH.Text = $"Chào mừng, {TenKH}!";
        }
    }
}
