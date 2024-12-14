namespace ManageBookGUI
{
    partial class FormSignInEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignInEmployee));
            labelTitle = new Label();
            labelAccount = new Label();
            tBoxAccount = new TextBox();
            tBoxPassword = new TextBox();
            labelPassword = new Label();
            btnSignIn = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Times New Roman", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelTitle.ForeColor = Color.FromArgb(255, 128, 0);
            labelTitle.Location = new Point(359, 40);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(294, 42);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Sign In Employee";
            // 
            // labelAccount
            // 
            labelAccount.AutoSize = true;
            labelAccount.Font = new Font("Times New Roman", 9.857143F);
            labelAccount.Location = new Point(60, 38);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(108, 27);
            labelAccount.TabIndex = 1;
            labelAccount.Text = "Tài khoản";
            // 
            // tBoxAccount
            // 
            tBoxAccount.Location = new Point(216, 33);
            tBoxAccount.Name = "tBoxAccount";
            tBoxAccount.Size = new Size(323, 35);
            tBoxAccount.TabIndex = 2;
            // 
            // tBoxPassword
            // 
            tBoxPassword.Location = new Point(216, 100);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.Size = new Size(323, 35);
            tBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Times New Roman", 9.857143F);
            labelPassword.Location = new Point(60, 105);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(104, 27);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Mật khẩu";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.Info;
            btnSignIn.Font = new Font("Times New Roman", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSignIn.ForeColor = SystemColors.Highlight;
            btnSignIn.Location = new Point(429, 333);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(142, 47);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(tBoxPassword);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(tBoxAccount);
            panel1.Controls.Add(labelAccount);
            panel1.Location = new Point(42, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 169);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(670, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 169);
            panel2.TabIndex = 7;
            // 
            // FormSignInEmployee
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(956, 422);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnSignIn);
            Controls.Add(labelTitle);
            Name = "FormSignInEmployee";
            Text = "Đăng nhập Nhân Viên";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelAccount;
        private TextBox tBoxAccount;
        private TextBox tBoxPassword;
        private Label labelPassword;
        private Button btnSignIn;
        private Panel panel1;
        private Panel panel2;
    }
}