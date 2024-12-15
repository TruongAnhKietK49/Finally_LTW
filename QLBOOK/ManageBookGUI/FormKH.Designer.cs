namespace ManageBookGUI
{
    partial class FormKH
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKH));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            txtMaKH = new TextBox();
            btnXemGH = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtSearch = new TextBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            menuStrip1 = new MenuStrip();
            imageList1 = new ImageList(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnThemGH = new Button();
            pictureBox4 = new PictureBox();
            panelGH = new Panel();
            pictureBox5 = new PictureBox();
            button3 = new Button();
            txtTongSoLuong = new TextBox();
            label13 = new Label();
            txtTongThanhTien = new TextBox();
            label12 = new Label();
            btnXoaGH = new Button();
            dataGridView2 = new DataGridView();
            txtTenSach = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtLoaiSach = new TextBox();
            txtMaSach = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtGia = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip2 = new MenuStrip();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            vănHọcToolStripMenuItem1 = new ToolStripMenuItem();
            sửThiToolStripMenuItem1 = new ToolStripMenuItem();
            côngNghệToolStripMenuItem = new ToolStripMenuItem();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            khoSáchToolStripMenuItem = new ToolStripMenuItem();
            thểLoạiToolStripMenuItem = new ToolStripMenuItem();
            vănHọcToolStripMenuItem = new ToolStripMenuItem();
            sửThiToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            label5 = new Label();
            txtTenDV = new TextBox();
            txtSoLuong = new TextBox();
            lblThoiHanThue = new Label();
            txtThoiHanThue = new TextBox();
            txtMaDV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelGH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(93, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(673, 247);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(94, 140, 65);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(txtMaKH);
            panel1.Controls.Add(btnXemGH);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1367, 67);
            panel1.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(972, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(53, 47);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 26;
            pictureBox6.TabStop = false;
            // 
            // txtMaKH
            // 
            txtMaKH.BackColor = Color.White;
            txtMaKH.Enabled = false;
            txtMaKH.Font = new Font("Segoe UI", 10F);
            txtMaKH.Location = new Point(1212, 19);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(95, 30);
            txtMaKH.TabIndex = 26;
            txtMaKH.TextAlign = HorizontalAlignment.Center;
            // 
            // btnXemGH
            // 
            btnXemGH.ForeColor = Color.FromArgb(94, 140, 65);
            btnXemGH.Location = new Point(1031, 18);
            btnXemGH.Name = "btnXemGH";
            btnXemGH.Size = new Size(115, 27);
            btnXemGH.TabIndex = 25;
            btnXemGH.Text = "Xem giỏ hàng";
            btnXemGH.TextAlign = ContentAlignment.MiddleRight;
            btnXemGH.UseVisualStyleBackColor = true;
            btnXemGH.Click += btnXemGH_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(71, 18);
            label1.Name = "label1";
            label1.Size = new Size(175, 35);
            label1.TabIndex = 21;
            label1.Text = "LionBookStore";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.books;
            pictureBox1.Location = new Point(22, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.Location = new Point(490, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(444, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(382, 19);
            label4.Name = "label4";
            label4.Size = new Size(102, 30);
            label4.TabIndex = 3;
            label4.Text = "Tìm kiếm";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1178, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 85);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(202, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.IndianRed;
            // 
            // btnThemGH
            // 
            btnThemGH.BackColor = Color.White;
            btnThemGH.Font = new Font("Segoe UI", 15F);
            btnThemGH.Location = new Point(490, 413);
            btnThemGH.Name = "btnThemGH";
            btnThemGH.Size = new Size(280, 50);
            btnThemGH.TabIndex = 4;
            btnThemGH.Text = "Thêm vào giỏ hàng";
            btnThemGH.TextAlign = ContentAlignment.MiddleRight;
            btnThemGH.UseVisualStyleBackColor = false;
            btnThemGH.Click += btnThemGH_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Add;
            pictureBox4.Location = new Point(501, 422);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // panelGH
            // 
            panelGH.BackColor = Color.FromArgb(197, 223, 113);
            panelGH.Controls.Add(pictureBox5);
            panelGH.Controls.Add(button3);
            panelGH.Controls.Add(txtTongSoLuong);
            panelGH.Controls.Add(label13);
            panelGH.Controls.Add(txtTongThanhTien);
            panelGH.Controls.Add(label12);
            panelGH.Controls.Add(btnXoaGH);
            panelGH.Controls.Add(dataGridView2);
            panelGH.Dock = DockStyle.Right;
            panelGH.ForeColor = SystemColors.ControlText;
            panelGH.Location = new Point(859, 67);
            panelGH.Name = "panelGH";
            panelGH.Size = new Size(508, 685);
            panelGH.TabIndex = 6;
            panelGH.Visible = false;
            panelGH.Paint += panel2_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.delete;
            pictureBox5.Location = new Point(348, 344);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(22, 27);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(305, 600);
            button3.Name = "button3";
            button3.Size = new Size(195, 50);
            button3.TabIndex = 17;
            button3.Text = "Thanh toán";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtTongSoLuong
            // 
            txtTongSoLuong.BackColor = Color.White;
            txtTongSoLuong.Enabled = false;
            txtTongSoLuong.Font = new Font("Segoe UI", 15F);
            txtTongSoLuong.Location = new Point(184, 471);
            txtTongSoLuong.Name = "txtTongSoLuong";
            txtTongSoLuong.Size = new Size(103, 41);
            txtTongSoLuong.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F);
            label13.Location = new Point(61, 473);
            label13.Name = "label13";
            label13.Size = new Size(115, 35);
            label13.TabIndex = 17;
            label13.Text = "Số lượng";
            // 
            // txtTongThanhTien
            // 
            txtTongThanhTien.BackColor = Color.White;
            txtTongThanhTien.Enabled = false;
            txtTongThanhTien.Font = new Font("Segoe UI", 15F);
            txtTongThanhTien.Location = new Point(184, 517);
            txtTongThanhTien.Name = "txtTongThanhTien";
            txtTongThanhTien.Size = new Size(171, 41);
            txtTongThanhTien.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F);
            label12.Location = new Point(61, 517);
            label12.Name = "label12";
            label12.Size = new Size(120, 35);
            label12.TabIndex = 17;
            label12.Text = "Tổng tiền";
            // 
            // btnXoaGH
            // 
            btnXoaGH.Location = new Point(348, 344);
            btnXoaGH.Name = "btnXoaGH";
            btnXoaGH.Size = new Size(135, 27);
            btnXoaGH.TabIndex = 6;
            btnXoaGH.Text = "Xóa sản phẩm";
            btnXoaGH.TextAlign = ContentAlignment.MiddleRight;
            btnXoaGH.UseVisualStyleBackColor = true;
            btnXoaGH.Click += btnXoaGH_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(29, 28);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(467, 285);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // txtTenSach
            // 
            txtTenSach.BackColor = Color.White;
            txtTenSach.Enabled = false;
            txtTenSach.Font = new Font("Segoe UI", 15F);
            txtTenSach.Location = new Point(197, 490);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(364, 41);
            txtTenSach.TabIndex = 7;
            txtTenSach.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(57, 487);
            label7.Name = "label7";
            label7.Size = new Size(110, 35);
            label7.TabIndex = 6;
            label7.Text = "Tên sách";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(58, 544);
            label8.Name = "label8";
            label8.Size = new Size(118, 35);
            label8.TabIndex = 8;
            label8.Text = "Loại sách";
            // 
            // txtLoaiSach
            // 
            txtLoaiSach.BackColor = Color.White;
            txtLoaiSach.Enabled = false;
            txtLoaiSach.Font = new Font("Segoe UI", 15F);
            txtLoaiSach.Location = new Point(197, 544);
            txtLoaiSach.Name = "txtLoaiSach";
            txtLoaiSach.Size = new Size(160, 41);
            txtLoaiSach.TabIndex = 9;
            txtLoaiSach.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMaSach
            // 
            txtMaSach.BackColor = Color.White;
            txtMaSach.Enabled = false;
            txtMaSach.Font = new Font("Segoe UI", 15F);
            txtMaSach.Location = new Point(197, 425);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(127, 41);
            txtMaSach.TabIndex = 11;
            txtMaSach.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(69, 428);
            label9.Name = "label9";
            label9.Size = new Size(107, 35);
            label9.TabIndex = 13;
            label9.Text = "Mã sách";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(605, 487);
            label10.Name = "label10";
            label10.Size = new Size(115, 35);
            label10.TabIndex = 14;
            label10.Text = "Số lượng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F);
            label11.Location = new Point(140, 612);
            label11.Name = "label11";
            label11.Size = new Size(51, 35);
            label11.TabIndex = 15;
            label11.Text = "Giá";
            // 
            // txtGia
            // 
            txtGia.BackColor = Color.White;
            txtGia.Enabled = false;
            txtGia.Font = new Font("Segoe UI", 15F);
            txtGia.Location = new Point(197, 606);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(138, 41);
            txtGia.TabIndex = 16;
            txtGia.TextAlign = HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.FromArgb(197, 223, 113);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { danhMụcToolStripMenuItem, trangChủToolStripMenuItem, khoSáchToolStripMenuItem, thểLoạiToolStripMenuItem, toolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 67);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(859, 43);
            menuStrip2.TabIndex = 19;
            menuStrip2.Text = "menuStrip2";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vănHọcToolStripMenuItem1, sửThiToolStripMenuItem1, côngNghệToolStripMenuItem });
            danhMụcToolStripMenuItem.Font = new Font("Segoe UI", 15F);
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(143, 39);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // vănHọcToolStripMenuItem1
            // 
            vănHọcToolStripMenuItem1.Name = "vănHọcToolStripMenuItem1";
            vănHọcToolStripMenuItem1.Size = new Size(226, 40);
            vănHọcToolStripMenuItem1.Text = "Văn học";
            // 
            // sửThiToolStripMenuItem1
            // 
            sửThiToolStripMenuItem1.Name = "sửThiToolStripMenuItem1";
            sửThiToolStripMenuItem1.Size = new Size(226, 40);
            sửThiToolStripMenuItem1.Text = "Sử thi";
            // 
            // côngNghệToolStripMenuItem
            // 
            côngNghệToolStripMenuItem.Name = "côngNghệToolStripMenuItem";
            côngNghệToolStripMenuItem.Size = new Size(226, 40);
            côngNghệToolStripMenuItem.Text = "Công nghệ";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.Font = new Font("Segoe UI", 15F);
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(138, 39);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // khoSáchToolStripMenuItem
            // 
            khoSáchToolStripMenuItem.Font = new Font("Segoe UI", 15F);
            khoSáchToolStripMenuItem.Name = "khoSáchToolStripMenuItem";
            khoSáchToolStripMenuItem.Size = new Size(132, 39);
            khoSáchToolStripMenuItem.Text = "Kho Sách";
            // 
            // thểLoạiToolStripMenuItem
            // 
            thểLoạiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vănHọcToolStripMenuItem, sửThiToolStripMenuItem });
            thểLoạiToolStripMenuItem.Font = new Font("Segoe UI", 15F);
            thểLoạiToolStripMenuItem.Name = "thểLoạiToolStripMenuItem";
            thểLoạiToolStripMenuItem.Size = new Size(135, 39);
            thểLoạiToolStripMenuItem.Text = "Giới thiệu";
            // 
            // vănHọcToolStripMenuItem
            // 
            vănHọcToolStripMenuItem.Name = "vănHọcToolStripMenuItem";
            vănHọcToolStripMenuItem.Size = new Size(224, 40);
            vănHọcToolStripMenuItem.Text = "Chính sách";
            // 
            // sửThiToolStripMenuItem
            // 
            sửThiToolStripMenuItem.Name = "sửThiToolStripMenuItem";
            sửThiToolStripMenuItem.Size = new Size(224, 40);
            sửThiToolStripMenuItem.Text = "Nội quy";
            sửThiToolStripMenuItem.Click += sửThiToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(27, 39);
            toolStripMenuItem1.Text = " ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(140, 671);
            label5.Name = "label5";
            label5.Size = new Size(98, 35);
            label5.TabIndex = 22;
            label5.Text = "Dịch vụ";
            // 
            // txtTenDV
            // 
            txtTenDV.BackColor = Color.White;
            txtTenDV.Enabled = false;
            txtTenDV.Font = new Font("Segoe UI", 15F);
            txtTenDV.Location = new Point(254, 671);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.Size = new Size(92, 41);
            txtTenDV.TabIndex = 24;
            txtTenDV.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSoLuong
            // 
            txtSoLuong.BackColor = Color.White;
            txtSoLuong.Font = new Font("Segoe UI", 15F);
            txtSoLuong.Location = new Point(741, 487);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(92, 41);
            txtSoLuong.TabIndex = 25;
            txtSoLuong.TextAlign = HorizontalAlignment.Center;
            // 
            // lblThoiHanThue
            // 
            lblThoiHanThue.AutoSize = true;
            lblThoiHanThue.Font = new Font("Segoe UI", 15F);
            lblThoiHanThue.Location = new Point(631, 606);
            lblThoiHanThue.Name = "lblThoiHanThue";
            lblThoiHanThue.Size = new Size(167, 35);
            lblThoiHanThue.TabIndex = 26;
            lblThoiHanThue.Text = "Thời hạn thuê";
            // 
            // txtThoiHanThue
            // 
            txtThoiHanThue.BackColor = Color.White;
            txtThoiHanThue.Font = new Font("Segoe UI", 15F);
            txtThoiHanThue.Location = new Point(616, 644);
            txtThoiHanThue.Name = "txtThoiHanThue";
            txtThoiHanThue.Size = new Size(202, 41);
            txtThoiHanThue.TabIndex = 27;
            txtThoiHanThue.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMaDV
            // 
            txtMaDV.BackColor = Color.White;
            txtMaDV.Enabled = false;
            txtMaDV.Font = new Font("Segoe UI", 15F);
            txtMaDV.Location = new Point(343, 672);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.Size = new Size(105, 41);
            txtMaDV.TabIndex = 28;
            txtMaDV.TextAlign = HorizontalAlignment.Center;
            // 
            // FormKH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 752);
            Controls.Add(txtMaDV);
            Controls.Add(txtThoiHanThue);
            Controls.Add(lblThoiHanThue);
            Controls.Add(txtSoLuong);
            Controls.Add(txtTenDV);
            Controls.Add(label5);
            Controls.Add(menuStrip2);
            Controls.Add(txtGia);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtMaSach);
            Controls.Add(txtLoaiSach);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtTenSach);
            Controls.Add(panelGH);
            Controls.Add(pictureBox4);
            Controls.Add(btnThemGH);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormKH";
            Text = "FormKH";
            Load += FormKH_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelGH.ResumeLayout(false);
            panelGH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private ImageList imageList1;
        private PictureBox pictureBox2;
        private TextBox txtSearch;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnThemGH;
        private PictureBox pictureBox4;
        private Panel panelGH;
        private DataGridView dataGridView2;
        private TextBox txtTenSach;
        private Label label7;
        private Label label8;
        private TextBox txtLoaiSach;
        private TextBox txtMaSach;
        private Label label9;
        private Label label10;
        private Button btnXoaGH;
        private TextBox txtTongSoLuong;
        private Label label13;
        private TextBox txtTongThanhTien;
        private Label label12;
        private Label label11;
        private TextBox txtGia;
        private Button button3;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem khoSáchToolStripMenuItem;
        private ToolStripMenuItem thểLoạiToolStripMenuItem;
        private ToolStripMenuItem vănHọcToolStripMenuItem;
        private ToolStripMenuItem sửThiToolStripMenuItem;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label5;
        private TextBox txtTenDV;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btnXemGH;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem vănHọcToolStripMenuItem1;
        private ToolStripMenuItem sửThiToolStripMenuItem1;
        private ToolStripMenuItem côngNghệToolStripMenuItem;
        private TextBox txtSoLuong;
        private TextBox txtMaKH;
        private Label lblThoiHanThue;
        private TextBox txtThoiHanThue;
        private TextBox txtMaDV;
    }
}