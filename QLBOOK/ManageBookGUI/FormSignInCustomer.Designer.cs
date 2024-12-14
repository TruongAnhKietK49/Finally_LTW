namespace ManageBookGUI
{
    partial class FormSignInCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignInCustomer));
            label1 = new Label();
            labelAccount = new Label();
            tBoxAccount = new TextBox();
            tBoxPassword = new TextBox();
            labelPassword = new Label();
            btnSignIn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(509, 40);
            label1.Name = "label1";
            label1.Size = new Size(132, 42);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // labelAccount
            // 
            labelAccount.AutoSize = true;
            labelAccount.Location = new Point(51, 27);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(101, 30);
            labelAccount.TabIndex = 1;
            labelAccount.Text = "Tài khoản";
            // 
            // tBoxAccount
            // 
            tBoxAccount.Location = new Point(204, 22);
            tBoxAccount.Name = "tBoxAccount";
            tBoxAccount.Size = new Size(355, 35);
            tBoxAccount.TabIndex = 2;
            // 
            // tBoxPassword
            // 
            tBoxPassword.Location = new Point(204, 94);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.Size = new Size(355, 35);
            tBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(51, 99);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(101, 30);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Mật khẩu";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.Info;
            btnSignIn.Font = new Font("Times New Roman", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSignIn.Location = new Point(259, 171);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(153, 55);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "Đăng nhập";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(tBoxPassword);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(tBoxAccount);
            panel1.Controls.Add(labelAccount);
            panel1.Location = new Point(117, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 260);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(778, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 260);
            panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(24, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 217);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormSignInCustomer
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1175, 477);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormSignInCustomer";
            Text = "Đăng nhập Khách Hàng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelAccount;
        private TextBox tBoxAccount;
        private TextBox tBoxPassword;
        private Label labelPassword;
        private Button btnSignIn;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}