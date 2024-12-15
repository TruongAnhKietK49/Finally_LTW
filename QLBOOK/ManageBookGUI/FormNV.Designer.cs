namespace ManageBookGUI
{
    partial class FormNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNV));
            labelTenNV = new Label();
            groupBox1 = new GroupBox();
            dgvQLSach = new DataGridView();
            MaSach = new DataGridViewTextBoxColumn();
            TenSach = new DataGridViewTextBoxColumn();
            TacGia = new DataGridViewTextBoxColumn();
            NXB = new DataGridViewTextBoxColumn();
            TheLoai = new DataGridViewTextBoxColumn();
            MaNV = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            GiaThue = new DataGridViewTextBoxColumn();
            label8 = new Label();
            groupBox = new GroupBox();
            btnTaiLai = new Button();
            label9 = new Label();
            label4 = new Label();
            txtMaNV = new TextBox();
            label1 = new Label();
            dateTimePickerNXB = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTheLoai = new TextBox();
            txtGiaBan = new TextBox();
            txtTacGia = new TextBox();
            txtGiaThue = new TextBox();
            txtTenSach = new TextBox();
            txtMaSach = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            pictureBox1 = new PictureBox();
            txtTimKiemSach = new TextBox();
            groupBox2 = new GroupBox();
            btnTimKiem = new Button();
            label10 = new Label();
            labelAdmin = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQLSach).BeginInit();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // labelTenNV
            // 
            labelTenNV.AutoSize = true;
            labelTenNV.BackColor = Color.Transparent;
            labelTenNV.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelTenNV.ForeColor = Color.Yellow;
            labelTenNV.Location = new Point(49, 19);
            labelTenNV.Margin = new Padding(2, 0, 2, 0);
            labelTenNV.Name = "labelTenNV";
            labelTenNV.Size = new Size(146, 28);
            labelTenNV.TabIndex = 0;
            labelTenNV.Text = "Ten Nhan Vien";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(dgvQLSach);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.8F);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(47, 414);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1296, 253);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh mục sách";
            // 
            // dgvQLSach
            // 
            dgvQLSach.AllowUserToAddRows = false;
            dgvQLSach.AllowUserToDeleteRows = false;
            dgvQLSach.BackgroundColor = Color.White;
            dgvQLSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQLSach.Columns.AddRange(new DataGridViewColumn[] { MaSach, TenSach, TacGia, NXB, TheLoai, MaNV, GiaBan, GiaThue });
            dgvQLSach.Location = new Point(22, 45);
            dgvQLSach.Name = "dgvQLSach";
            dgvQLSach.ReadOnly = true;
            dgvQLSach.RowHeadersWidth = 51;
            dgvQLSach.Size = new Size(1257, 188);
            dgvQLSach.TabIndex = 14;
            dgvQLSach.CellClick += dgvQLSach_CellClick_1;
            // 
            // MaSach
            // 
            MaSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaSach.DataPropertyName = "MaSach";
            MaSach.FillWeight = 82.90998F;
            MaSach.HeaderText = "Mã sách";
            MaSach.MinimumWidth = 6;
            MaSach.Name = "MaSach";
            MaSach.ReadOnly = true;
            // 
            // TenSach
            // 
            TenSach.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenSach.DataPropertyName = "TenSach";
            TenSach.FillWeight = 128.342224F;
            TenSach.HeaderText = "Tên sách";
            TenSach.MinimumWidth = 6;
            TenSach.Name = "TenSach";
            TenSach.ReadOnly = true;
            // 
            // TacGia
            // 
            TacGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TacGia.DataPropertyName = "TacGia";
            TacGia.FillWeight = 98.12461F;
            TacGia.HeaderText = "Tác giả";
            TacGia.MinimumWidth = 6;
            TacGia.Name = "TacGia";
            TacGia.ReadOnly = true;
            // 
            // NXB
            // 
            NXB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NXB.DataPropertyName = "NXB";
            NXB.FillWeight = 98.12461F;
            NXB.HeaderText = "Ngày xuất bản";
            NXB.MinimumWidth = 6;
            NXB.Name = "NXB";
            NXB.ReadOnly = true;
            // 
            // TheLoai
            // 
            TheLoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TheLoai.DataPropertyName = "TheLoai";
            TheLoai.FillWeight = 98.12461F;
            TheLoai.HeaderText = "Thể loại";
            TheLoai.MinimumWidth = 6;
            TheLoai.Name = "TheLoai";
            TheLoai.ReadOnly = true;
            // 
            // MaNV
            // 
            MaNV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaNV.DataPropertyName = "MaNV";
            MaNV.FillWeight = 98.12461F;
            MaNV.HeaderText = "Mã nhân viên";
            MaNV.MinimumWidth = 6;
            MaNV.Name = "MaNV";
            MaNV.ReadOnly = true;
            // 
            // GiaBan
            // 
            GiaBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GiaBan.DataPropertyName = "GiaBan";
            GiaBan.FillWeight = 98.12461F;
            GiaBan.HeaderText = "Giá bán";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            // 
            // GiaThue
            // 
            GiaThue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GiaThue.DataPropertyName = "GiaThue";
            GiaThue.FillWeight = 98.12461F;
            GiaThue.HeaderText = "Giá thuê";
            GiaThue.MinimumWidth = 6;
            GiaThue.Name = "GiaThue";
            GiaThue.ReadOnly = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label8.ForeColor = Color.Yellow;
            label8.Location = new Point(511, 9);
            label8.Name = "label8";
            label8.Size = new Size(335, 41);
            label8.TabIndex = 27;
            label8.Text = "Quản lý thông tin sách";
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.Transparent;
            groupBox.Controls.Add(btnTaiLai);
            groupBox.Controls.Add(label9);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(txtMaNV);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(dateTimePickerNXB);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(label6);
            groupBox.Controls.Add(label7);
            groupBox.Controls.Add(txtTheLoai);
            groupBox.Controls.Add(txtGiaBan);
            groupBox.Controls.Add(txtTacGia);
            groupBox.Controls.Add(txtGiaThue);
            groupBox.Controls.Add(txtTenSach);
            groupBox.Controls.Add(txtMaSach);
            groupBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            groupBox.ForeColor = Color.Black;
            groupBox.Location = new Point(49, 77);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(988, 252);
            groupBox.TabIndex = 26;
            groupBox.TabStop = false;
            groupBox.Text = "Thông tin sách";
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackgroundImage = (Image)resources.GetObject("btnTaiLai.BackgroundImage");
            btnTaiLai.BackgroundImageLayout = ImageLayout.Stretch;
            btnTaiLai.Location = new Point(938, 207);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(44, 38);
            btnTaiLai.TabIndex = 21;
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(480, 133);
            label9.Name = "label9";
            label9.Size = new Size(141, 28);
            label9.TabIndex = 20;
            label9.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(480, 88);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 3;
            label4.Text = "Thể loại:";
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 12F);
            txtMaNV.Location = new Point(630, 130);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(283, 34);
            txtMaNV.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(43, 48);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã sách:";
            // 
            // dateTimePickerNXB
            // 
            dateTimePickerNXB.Font = new Font("Segoe UI", 12F);
            dateTimePickerNXB.Location = new Point(629, 42);
            dateTimePickerNXB.Name = "dateTimePickerNXB";
            dateTimePickerNXB.Size = new Size(284, 34);
            dateTimePickerNXB.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(44, 88);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên sách:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(480, 46);
            label3.Name = "label3";
            label3.Size = new Size(149, 28);
            label3.TabIndex = 2;
            label3.Text = "Ngày xuất bản:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(44, 136);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 4;
            label5.Text = "Tác giả:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(60, 204);
            label6.Name = "label6";
            label6.Size = new Size(86, 28);
            label6.TabIndex = 5;
            label6.Text = "Giá bán:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(449, 207);
            label7.Name = "label7";
            label7.Size = new Size(94, 28);
            label7.TabIndex = 6;
            label7.Text = "Giá thuê:";
            // 
            // txtTheLoai
            // 
            txtTheLoai.Font = new Font("Segoe UI", 12F);
            txtTheLoai.Location = new Point(630, 88);
            txtTheLoai.Name = "txtTheLoai";
            txtTheLoai.Size = new Size(283, 34);
            txtTheLoai.TabIndex = 13;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Font = new Font("Segoe UI", 12F);
            txtGiaBan.Location = new Point(162, 204);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(223, 34);
            txtGiaBan.TabIndex = 7;
            // 
            // txtTacGia
            // 
            txtTacGia.Font = new Font("Segoe UI", 12F);
            txtTacGia.Location = new Point(160, 136);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(283, 34);
            txtTacGia.TabIndex = 11;
            // 
            // txtGiaThue
            // 
            txtGiaThue.Font = new Font("Segoe UI", 12F);
            txtGiaThue.Location = new Point(558, 201);
            txtGiaThue.Name = "txtGiaThue";
            txtGiaThue.Size = new Size(239, 34);
            txtGiaThue.TabIndex = 8;
            // 
            // txtTenSach
            // 
            txtTenSach.Font = new Font("Segoe UI", 12F);
            txtTenSach.Location = new Point(162, 88);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(283, 34);
            txtTenSach.TabIndex = 10;
            // 
            // txtMaSach
            // 
            txtMaSach.Font = new Font("Segoe UI", 12F);
            txtMaSach.Location = new Point(162, 45);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(284, 34);
            txtMaSach.TabIndex = 9;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnXoa.ForeColor = SystemColors.ControlText;
            btnXoa.Location = new Point(361, 350);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 48);
            btnXoa.TabIndex = 25;
            btnXoa.Text = "Xóa sách";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnSua.ForeColor = SystemColors.ControlText;
            btnSua.Location = new Point(223, 350);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(113, 48);
            btnSua.TabIndex = 24;
            btnSua.Text = "Sửa sách";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.BackgroundImageLayout = ImageLayout.Stretch;
            btnThem.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnThem.ForeColor = SystemColors.ActiveCaptionText;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(72, 350);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(124, 48);
            btnThem.TabIndex = 23;
            btnThem.Text = "Thêm sách";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1255, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // txtTimKiemSach
            // 
            txtTimKiemSach.Location = new Point(105, 85);
            txtTimKiemSach.Name = "txtTimKiemSach";
            txtTimKiemSach.Size = new Size(191, 28);
            txtTimKiemSach.TabIndex = 30;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtTimKiemSach);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.8F);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(1043, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(302, 252);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm sách";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackgroundImageLayout = ImageLayout.Zoom;
            btnTimKiem.ForeColor = SystemColors.ControlText;
            btnTimKiem.Location = new Point(162, 157);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(121, 45);
            btnTimKiem.TabIndex = 31;
            btnTimKiem.Text = "Tìm sách";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 88);
            label10.Name = "label10";
            label10.Size = new Size(90, 22);
            label10.TabIndex = 0;
            label10.Text = "Tên sách:";
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.BackColor = Color.Transparent;
            labelAdmin.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelAdmin.ForeColor = SystemColors.ButtonFace;
            labelAdmin.Location = new Point(1237, 47);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(46, 17);
            labelAdmin.TabIndex = 32;
            labelAdmin.Text = "TenNV";
            // 
            // FormNV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1357, 693);
            Controls.Add(labelAdmin);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(groupBox);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(labelTenNV);
            Margin = new Padding(2);
            Name = "FormNV";
            Text = "FormNV";
            Load += FormNV_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQLSach).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTenNV;
        private GroupBox groupBox1;
        private DataGridView dgvQLSach;
        private DataGridViewTextBoxColumn MaSach;
        private DataGridViewTextBoxColumn TenSach;
        private DataGridViewTextBoxColumn TacGia;
        private DataGridViewTextBoxColumn NXB;
        private DataGridViewTextBoxColumn TheLoai;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn GiaThue;
        private Label label8;
        private GroupBox groupBox;
        private Label label9;
        private Label label4;
        private TextBox txtMaNV;
        private Label label1;
        private DateTimePicker dateTimePickerNXB;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTheLoai;
        private TextBox txtGiaBan;
        private TextBox txtTacGia;
        private TextBox txtGiaThue;
        private TextBox txtTenSach;
        private TextBox txtMaSach;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private PictureBox pictureBox1;
        private TextBox txtTimKiemSach;
        private GroupBox groupBox2;
        private Label label10;
        private Button btnTimKiem;
        private Label labelAdmin;
        private Button btnTaiLai;
    }
}