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
            labelTitle = new Label();
            labelAccount = new Label();
            tBoxAccount = new TextBox();
            tBoxPassword = new TextBox();
            labelPassword = new Label();
            btnSignIn = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Times New Roman", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelTitle.ForeColor = Color.FromArgb(255, 128, 0);
            labelTitle.Location = new Point(288, 64);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(294, 42);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Sign In Employee";
            // 
            // labelAccount
            // 
            labelAccount.AutoSize = true;
            labelAccount.Font = new Font("Times New Roman", 9.857143F);
            labelAccount.Location = new Point(150, 152);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(108, 27);
            labelAccount.TabIndex = 1;
            labelAccount.Text = "Tài khoản";
            // 
            // tBoxAccount
            // 
            tBoxAccount.Location = new Point(306, 147);
            tBoxAccount.Name = "tBoxAccount";
            tBoxAccount.Size = new Size(323, 35);
            tBoxAccount.TabIndex = 2;
            // 
            // tBoxPassword
            // 
            tBoxPassword.Location = new Point(306, 214);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.Size = new Size(323, 35);
            tBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Times New Roman", 9.857143F);
            labelPassword.Location = new Point(150, 219);
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
            btnSignIn.Location = new Point(364, 301);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(142, 47);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // FormSignInEmployee
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 428);
            Controls.Add(btnSignIn);
            Controls.Add(tBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(tBoxAccount);
            Controls.Add(labelAccount);
            Controls.Add(labelTitle);
            Name = "FormSignInEmployee";
            Text = "Đăng nhập Nhân Viên";
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
    }
}