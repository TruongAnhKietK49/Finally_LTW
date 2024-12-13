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
            label1 = new Label();
            labelAccount = new Label();
            tBoxAccount = new TextBox();
            tBoxPassword = new TextBox();
            labelPassword = new Label();
            btnSignIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(371, 43);
            label1.Name = "label1";
            label1.Size = new Size(132, 42);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // labelAccount
            // 
            labelAccount.AutoSize = true;
            labelAccount.Location = new Point(168, 147);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(101, 30);
            labelAccount.TabIndex = 1;
            labelAccount.Text = "Tài khoản";
            // 
            // tBoxAccount
            // 
            tBoxAccount.Location = new Point(321, 142);
            tBoxAccount.Name = "tBoxAccount";
            tBoxAccount.Size = new Size(355, 35);
            tBoxAccount.TabIndex = 2;
            // 
            // tBoxPassword
            // 
            tBoxPassword.Location = new Point(321, 214);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.Size = new Size(355, 35);
            tBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(168, 219);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(101, 30);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Mật khẩu";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.Info;
            btnSignIn.Font = new Font("Times New Roman", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSignIn.Location = new Point(371, 291);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(153, 55);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "Đăng nhập";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // FormSignInCustomer
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 447);
            Controls.Add(btnSignIn);
            Controls.Add(tBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(tBoxAccount);
            Controls.Add(labelAccount);
            Controls.Add(label1);
            Name = "FormSignInCustomer";
            Text = "Đăng nhập Khách Hàng";
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
    }
}