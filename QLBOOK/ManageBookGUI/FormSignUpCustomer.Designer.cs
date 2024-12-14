namespace ManageBookGUI
{
    partial class FormSignUpCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUpCustomer));
            labelMaKH = new Label();
            label1 = new Label();
            labelNgSinh = new Label();
            labelAddress = new Label();
            labelEmail = new Label();
            labelSDT = new Label();
            label2 = new Label();
            labelSex = new Label();
            panel1 = new Panel();
            rBtnNu = new RadioButton();
            rBtnNam = new RadioButton();
            btnSignUp = new Button();
            tBoxSDT = new TextBox();
            tBoxEmailKH = new TextBox();
            tBoxAddress = new TextBox();
            dateTimeNgSinh = new DateTimePicker();
            tBoxTenKH = new TextBox();
            tBoxMaKH = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelMaKH
            // 
            labelMaKH.AutoSize = true;
            labelMaKH.Location = new Point(89, 46);
            labelMaKH.Name = "labelMaKH";
            labelMaKH.Size = new Size(76, 30);
            labelMaKH.TabIndex = 0;
            labelMaKH.Text = "Mã KH";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 102);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 2;
            label1.Text = "Tên KH";
            // 
            // labelNgSinh
            // 
            labelNgSinh.AutoSize = true;
            labelNgSinh.Location = new Point(59, 160);
            labelNgSinh.Name = "labelNgSinh";
            labelNgSinh.Size = new Size(108, 30);
            labelNgSinh.TabIndex = 4;
            labelNgSinh.Text = "Ngày Sinh";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(89, 263);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(80, 30);
            labelAddress.TabIndex = 6;
            labelAddress.Text = "Địa Chỉ";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(102, 319);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(63, 30);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email";
            // 
            // labelSDT
            // 
            labelSDT.AutoSize = true;
            labelSDT.Location = new Point(97, 378);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(68, 30);
            labelSDT.TabIndex = 10;
            labelSDT.Text = "Số ĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ScrollBar;
            label2.Font = new Font("Times New Roman", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(434, 28);
            label2.Name = "label2";
            label2.Size = new Size(146, 42);
            label2.TabIndex = 12;
            label2.Text = "Sign Up";
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Location = new Point(73, 210);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(92, 30);
            labelSex.TabIndex = 14;
            labelSex.Text = "Giới tính";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(labelSex);
            panel1.Controls.Add(labelSDT);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(labelAddress);
            panel1.Controls.Add(labelNgSinh);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelMaKH);
            panel1.Location = new Point(195, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 485);
            panel1.TabIndex = 17;
            // 
            // rBtnNu
            // 
            rBtnNu.AutoSize = true;
            rBtnNu.Location = new Point(211, 210);
            rBtnNu.Name = "rBtnNu";
            rBtnNu.Size = new Size(66, 34);
            rBtnNu.TabIndex = 26;
            rBtnNu.TabStop = true;
            rBtnNu.Text = "Nữ";
            rBtnNu.UseVisualStyleBackColor = true;
            // 
            // rBtnNam
            // 
            rBtnNam.AutoSize = true;
            rBtnNam.Location = new Point(92, 212);
            rBtnNam.Name = "rBtnNam";
            rBtnNam.Size = new Size(83, 34);
            rBtnNam.TabIndex = 25;
            rBtnNam.TabStop = true;
            rBtnNam.Text = "Nam";
            rBtnNam.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Cyan;
            btnSignUp.Font = new Font("Times New Roman", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSignUp.ForeColor = Color.Blue;
            btnSignUp.Location = new Point(148, 420);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(129, 53);
            btnSignUp.TabIndex = 24;
            btnSignUp.Text = "Đăng ký";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // tBoxSDT
            // 
            tBoxSDT.BackColor = Color.FromArgb(255, 255, 128);
            tBoxSDT.Location = new Point(53, 379);
            tBoxSDT.Name = "tBoxSDT";
            tBoxSDT.Size = new Size(339, 35);
            tBoxSDT.TabIndex = 23;
            // 
            // tBoxEmailKH
            // 
            tBoxEmailKH.BackColor = Color.FromArgb(255, 255, 128);
            tBoxEmailKH.Location = new Point(53, 320);
            tBoxEmailKH.Name = "tBoxEmailKH";
            tBoxEmailKH.Size = new Size(339, 35);
            tBoxEmailKH.TabIndex = 22;
            // 
            // tBoxAddress
            // 
            tBoxAddress.BackColor = Color.FromArgb(255, 255, 128);
            tBoxAddress.Location = new Point(53, 264);
            tBoxAddress.Name = "tBoxAddress";
            tBoxAddress.Size = new Size(339, 35);
            tBoxAddress.TabIndex = 21;
            // 
            // dateTimeNgSinh
            // 
            dateTimeNgSinh.CalendarMonthBackground = Color.White;
            dateTimeNgSinh.Location = new Point(53, 160);
            dateTimeNgSinh.Name = "dateTimeNgSinh";
            dateTimeNgSinh.Size = new Size(339, 35);
            dateTimeNgSinh.TabIndex = 20;
            // 
            // tBoxTenKH
            // 
            tBoxTenKH.BackColor = Color.FromArgb(255, 255, 128);
            tBoxTenKH.Location = new Point(53, 101);
            tBoxTenKH.Name = "tBoxTenKH";
            tBoxTenKH.Size = new Size(339, 35);
            tBoxTenKH.TabIndex = 19;
            // 
            // tBoxMaKH
            // 
            tBoxMaKH.BackColor = Color.FromArgb(255, 255, 128);
            tBoxMaKH.Enabled = false;
            tBoxMaKH.Location = new Point(53, 45);
            tBoxMaKH.Name = "tBoxMaKH";
            tBoxMaKH.Size = new Size(339, 35);
            tBoxMaKH.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(rBtnNu);
            panel2.Controls.Add(rBtnNam);
            panel2.Controls.Add(btnSignUp);
            panel2.Controls.Add(tBoxSDT);
            panel2.Controls.Add(tBoxEmailKH);
            panel2.Controls.Add(tBoxAddress);
            panel2.Controls.Add(dateTimeNgSinh);
            panel2.Controls.Add(tBoxTenKH);
            panel2.Controls.Add(tBoxMaKH);
            panel2.Location = new Point(393, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 485);
            panel2.TabIndex = 27;
            // 
            // FormSignUpCustomer
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(986, 650);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "FormSignUpCustomer";
            Text = "Tạo tài khoản Khách Hàng";
            Load += LoadMaKH;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMaKH;
        private Label label1;
        private TextBox textBox1;
        private Label labelNgSinh;
        private Label labelAddress;
        private Label labelEmail;
        private Label labelSDT;
        private Label label2;
        private TextBox textBox2;
        private Label labelSex;
        private Panel panel1;
        private RadioButton rBtnNu;
        private RadioButton rBtnNam;
        private Button btnSignUp;
        private TextBox tBoxSDT;
        private TextBox tBoxEmailKH;
        private TextBox tBoxAddress;
        private DateTimePicker dateTimeNgSinh;
        private TextBox tBoxTenKH;
        private TextBox tBoxMaKH;
        private Panel panel2;
    }
}