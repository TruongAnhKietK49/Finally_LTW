namespace ManageBookGUI
{
    partial class FormHoaDon
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
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            ListBOOKS = new ListBox();
            DanhSachHD = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaHoaDon = new TextBox();
            txtMaKhachHang = new TextBox();
            txtMaSach = new TextBox();
            txtMaDichVu = new TextBox();
            txtSoLuong = new TextBox();
            txtThanhTien = new TextBox();
            txtGiaSach = new TextBox();
            dataGridViewHoaDon = new DataGridView();
            MaHD = new DataGridViewTextBoxColumn();
            MaKH = new DataGridViewTextBoxColumn();
            MaBOOKS = new DataGridViewTextBoxColumn();
            MaDV = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            GiaSach = new DataGridViewTextBoxColumn();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnThanhTien = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoaDon).BeginInit();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(56, 67);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(15, 96);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(157, 23);
            txtTimKiem.TabIndex = 1;
            // 
            // ListBOOKS
            // 
            ListBOOKS.FormattingEnabled = true;
            ListBOOKS.ItemHeight = 15;
            ListBOOKS.Location = new Point(15, 153);
            ListBOOKS.Name = "ListBOOKS";
            ListBOOKS.Size = new Size(157, 484);
            ListBOOKS.TabIndex = 2;
            ListBOOKS.SelectedIndexChanged += ListBOOKS_SelectedIndexChanged;
            // 
            // DanhSachHD
            // 
            DanhSachHD.AutoSize = true;
            DanhSachHD.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DanhSachHD.Location = new Point(440, 9);
            DanhSachHD.Name = "DanhSachHD";
            DanhSachHD.Size = new Size(181, 25);
            DanhSachHD.TabIndex = 3;
            DanhSachHD.Text = "Danh Sách Hóa Đơn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(260, 104);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 4;
            label1.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(529, 99);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 5;
            label2.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(836, 99);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "Mã Sách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 292);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 7;
            label4.Text = "Mã Dịch Vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(529, 292);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Số Lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(836, 292);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 9;
            label6.Text = "Giá Sách";
            label6.Click += label6_Click;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(225, 161);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(137, 23);
            txtMaHoaDon.TabIndex = 11;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(513, 161);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(137, 23);
            txtMaKhachHang.TabIndex = 15;
            txtMaKhachHang.TextChanged += textBox3_TextChanged;
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(795, 161);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(137, 23);
            txtMaSach.TabIndex = 16;
            // 
            // txtMaDichVu
            // 
            txtMaDichVu.Location = new Point(225, 389);
            txtMaDichVu.Name = "txtMaDichVu";
            txtMaDichVu.Size = new Size(137, 23);
            txtMaDichVu.TabIndex = 17;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(513, 389);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(137, 23);
            txtSoLuong.TabIndex = 18;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(970, 770);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(137, 23);
            txtThanhTien.TabIndex = 19;
            // 
            // txtGiaSach
            // 
            txtGiaSach.Location = new Point(808, 389);
            txtGiaSach.Name = "txtGiaSach";
            txtGiaSach.Size = new Size(137, 23);
            txtGiaSach.TabIndex = 20;
            txtGiaSach.TextChanged += txtGiaSach_TextChanged;
            // 
            // dataGridViewHoaDon
            // 
            dataGridViewHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHoaDon.Columns.AddRange(new DataGridViewColumn[] { MaHD, MaKH, MaBOOKS, MaDV, SoLuong, GiaSach });
            dataGridViewHoaDon.Location = new Point(225, 508);
            dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            dataGridViewHoaDon.Size = new Size(828, 150);
            dataGridViewHoaDon.TabIndex = 21;
            dataGridViewHoaDon.CellClick += dataGridViewHoaDon_CellClick;
            // 
            // MaHD
            // 
            MaHD.HeaderText = "Mã Hóa Đơn";
            MaHD.Name = "MaHD";
            // 
            // MaKH
            // 
            MaKH.HeaderText = "Mã Khách Hàng";
            MaKH.Name = "MaKH";
            // 
            // MaBOOKS
            // 
            MaBOOKS.HeaderText = "Mã Sách";
            MaBOOKS.Name = "MaBOOKS";
            // 
            // MaDV
            // 
            MaDV.HeaderText = "Mã Dịch Vụ";
            MaDV.Name = "MaDV";
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.Name = "SoLuong";
            // 
            // GiaSach
            // 
            GiaSach.HeaderText = "Giá Sách";
            GiaSach.Name = "GiaSach";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(225, 769);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(513, 769);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 23;
            btnSua.Text = "Sửa Hóa Đơn";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(912, 448);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 24;
            btnThem.Text = "Thêm Vào";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnThanhTien
            // 
            btnThanhTien.Location = new Point(1000, 701);
            btnThanhTien.Name = "btnThanhTien";
            btnThanhTien.Size = new Size(75, 23);
            btnThanhTien.TabIndex = 25;
            btnThanhTien.Text = "Thành Tiền";
            btnThanhTien.UseVisualStyleBackColor = true;
            btnThanhTien.Click += btnThanhTien_Click;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 831);
            Controls.Add(btnThanhTien);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(dataGridViewHoaDon);
            Controls.Add(txtGiaSach);
            Controls.Add(txtThanhTien);
            Controls.Add(txtSoLuong);
            Controls.Add(txtMaDichVu);
            Controls.Add(txtMaSach);
            Controls.Add(txtMaKhachHang);
            Controls.Add(txtMaHoaDon);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DanhSachHD);
            Controls.Add(ListBOOKS);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            ForeColor = Color.Red;
            Name = "FormHoaDon";
            Text = "FormHoaDon";
            ((System.ComponentModel.ISupportInitialize)dataGridViewHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private ListBox ListBOOKS;
        private Label DanhSachHD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMaHoaDon;
        private TextBox txtMaKhachHang;
        private TextBox txtMaSach;
        private TextBox txtMaDichVu;
        private TextBox txtSoLuong;
        private TextBox txtThanhTien;
        private TextBox txtGiaSach;
        private DataGridView dataGridViewHoaDon;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn MaBOOKS;
        private DataGridViewTextBoxColumn MaDV;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn GiaSach;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnThanhTien;
    }
}