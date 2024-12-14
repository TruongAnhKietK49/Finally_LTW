namespace ManageBookGUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void CreateAccountClick(object sender, EventArgs e)
        {
            FormSignUpCustomer FSUC = new FormSignUpCustomer();
            FSUC.ShowDialog();
        }

        private void SignInAccountCustomer(object sender, EventArgs e)
        {
            FormSignInCustomer FSIC = new FormSignInCustomer();
            FSIC.ShowDialog();
        }

        private void btnSignInEmployee_Click(object sender, EventArgs e)
        {
            FormSignInEmployee FSIE = new FormSignInEmployee();
            FSIE.ShowDialog();
        }

        private void gópÝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mọi góp ý xin hãy gửi về địa chỉ mail: nhiny@gmail.com để được tiếp nhận và cải thiện!\n" +
                "Xin chân thành cảm ơn quý khách!");
        }

        private void liênHệTrợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Những khiếu nại xin hãy gửi qua địa chỉ mail: thanhtientung@gmail.com để được giúp đỡ và sẽ nhanh chóng khắc phục!\n" +
                "Xin lỗi vì sự bất tiện này!");
        }   

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
