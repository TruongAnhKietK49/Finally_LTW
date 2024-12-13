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
            tBoxMaKH = new TextBox();
            tBoxTenKH = new TextBox();
            label1 = new Label();
            labelNgSinh = new Label();
            dateTimeNgSinh = new DateTimePicker();
            tBoxAddress = new TextBox();
            labelAddress = new Label();
            tBoxEmailKH = new TextBox();
            labelEmail = new Label();
            tBoxSDT = new TextBox();
            labelSDT = new Label();
            label2 = new Label();
            btnSignUp = new Button();
            labelSex = new Label();
            rBtnNam = new RadioButton();
            rBtnNu = new RadioButton();
            SuspendLayout();
            // 
            // labelMaKH
            // 
            labelMaKH.AutoSize = true;
            labelMaKH.Location = new Point(272, 134);
            labelMaKH.Name = "labelMaKH";
            labelMaKH.Size = new Size(76, 30);
            labelMaKH.TabIndex = 0;
            labelMaKH.Text = "Mã KH";
            // 
            // tBoxMaKH
            // 
            tBoxMaKH.BackColor = Color.FromArgb(255, 255, 128);
            tBoxMaKH.Enabled = false;
            tBoxMaKH.Location = new Point(381, 129);
            tBoxMaKH.Name = "tBoxMaKH";
            tBoxMaKH.Size = new Size(339, 35);
            tBoxMaKH.TabIndex = 1;
            // 
            // tBoxTenKH
            // 
            tBoxTenKH.BackColor = Color.FromArgb(255, 255, 128);
            tBoxTenKH.Location = new Point(381, 185);
            tBoxTenKH.Name = "tBoxTenKH";
            tBoxTenKH.Size = new Size(339, 35);
            tBoxTenKH.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 190);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 2;
            label1.Text = "Tên KH";
            // 
            // labelNgSinh
            // 
            labelNgSinh.AutoSize = true;
            labelNgSinh.Location = new Point(242, 248);
            labelNgSinh.Name = "labelNgSinh";
            labelNgSinh.Size = new Size(108, 30);
            labelNgSinh.TabIndex = 4;
            labelNgSinh.Text = "Ngày Sinh";
            // 
            // dateTimeNgSinh
            // 
            dateTimeNgSinh.CalendarMonthBackground = Color.White;
            dateTimeNgSinh.Location = new Point(381, 244);
            dateTimeNgSinh.Name = "dateTimeNgSinh";
            dateTimeNgSinh.Size = new Size(339, 35);
            dateTimeNgSinh.TabIndex = 5;
            // 
            // tBoxAddress
            // 
            tBoxAddress.BackColor = Color.FromArgb(255, 255, 128);
            tBoxAddress.Location = new Point(381, 348);
            tBoxAddress.Name = "tBoxAddress";
            tBoxAddress.Size = new Size(339, 35);
            tBoxAddress.TabIndex = 7;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(272, 351);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(80, 30);
            labelAddress.TabIndex = 6;
            labelAddress.Text = "Địa Chỉ";
            // 
            // tBoxEmailKH
            // 
            tBoxEmailKH.BackColor = Color.FromArgb(255, 255, 128);
            tBoxEmailKH.Location = new Point(381, 404);
            tBoxEmailKH.Name = "tBoxEmailKH";
            tBoxEmailKH.Size = new Size(339, 35);
            tBoxEmailKH.TabIndex = 9;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(285, 407);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(63, 30);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email";
            // 
            // tBoxSDT
            // 
            tBoxSDT.BackColor = Color.FromArgb(255, 255, 128);
            tBoxSDT.Location = new Point(381, 463);
            tBoxSDT.Name = "tBoxSDT";
            tBoxSDT.Size = new Size(339, 35);
            tBoxSDT.TabIndex = 11;
            // 
            // labelSDT
            // 
            labelSDT.AutoSize = true;
            labelSDT.Location = new Point(280, 466);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(68, 30);
            labelSDT.TabIndex = 10;
            labelSDT.Text = "Số ĐT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(429, 37);
            label2.Name = "label2";
            label2.Size = new Size(150, 42);
            label2.TabIndex = 12;
            label2.Text = "Đăng ký";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Cyan;
            btnSignUp.Font = new Font("Times New Roman", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSignUp.ForeColor = Color.Blue;
            btnSignUp.Location = new Point(448, 543);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(140, 61);
            btnSignUp.TabIndex = 13;
            btnSignUp.Text = "Đăng ký";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUpClick;
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Location = new Point(256, 298);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(92, 30);
            labelSex.TabIndex = 14;
            labelSex.Text = "Giới tính";
            // 
            // rBtnNam
            // 
            rBtnNam.AutoSize = true;
            rBtnNam.Location = new Point(420, 296);
            rBtnNam.Name = "rBtnNam";
            rBtnNam.Size = new Size(83, 34);
            rBtnNam.TabIndex = 15;
            rBtnNam.TabStop = true;
            rBtnNam.Text = "Nam";
            rBtnNam.UseVisualStyleBackColor = true;
            // 
            // rBtnNu
            // 
            rBtnNu.AutoSize = true;
            rBtnNu.Location = new Point(539, 294);
            rBtnNu.Name = "rBtnNu";
            rBtnNu.Size = new Size(66, 34);
            rBtnNu.TabIndex = 16;
            rBtnNu.TabStop = true;
            rBtnNu.Text = "Nữ";
            rBtnNu.UseVisualStyleBackColor = true;
            // 
            // FormSignUpCustomer
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(986, 650);
            Controls.Add(rBtnNu);
            Controls.Add(rBtnNam);
            Controls.Add(labelSex);
            Controls.Add(btnSignUp);
            Controls.Add(label2);
            Controls.Add(tBoxSDT);
            Controls.Add(labelSDT);
            Controls.Add(tBoxEmailKH);
            Controls.Add(labelEmail);
            Controls.Add(tBoxAddress);
            Controls.Add(labelAddress);
            Controls.Add(dateTimeNgSinh);
            Controls.Add(labelNgSinh);
            Controls.Add(tBoxTenKH);
            Controls.Add(label1);
            Controls.Add(tBoxMaKH);
            Controls.Add(labelMaKH);
            Name = "FormSignUpCustomer";
            Text = "Tạo tài khoản Khách Hàng";
            Load += LoadMaKH;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMaKH;
        private TextBox tBoxMaKH;
        private TextBox tBoxTenKH;
        private Label label1;
        private TextBox textBox1;
        private Label labelNgSinh;
        private DateTimePicker dateTimeNgSinh;
        private TextBox tBoxAddress;
        private Label labelAddress;
        private TextBox tBoxEmailKH;
        private Label labelEmail;
        private TextBox tBoxSDT;
        private Label labelSDT;
        private Label label2;
        private Button btnSignUp;
        private TextBox textBox2;
        private Label labelSex;
        private RadioButton rBtnNam;
        private RadioButton rBtnNu;
    }
}