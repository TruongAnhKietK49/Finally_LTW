namespace ManageBookGUI
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            labelTitle = new Label();
            btnSignUp = new Button();
            btnSignInCustomer = new Button();
            btnSignInEmployee = new Button();
            rTextBoxContent = new RichTextBox();
            picBoxCharacter = new PictureBox();
            groupBox1 = new GroupBox();
            picEvaluate = new PictureBox();
            menuStripBookStore = new MenuStrip();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            gópÝToolStripMenuItem = new ToolStripMenuItem();
            liênHệTrợGiúpToolStripMenuItem = new ToolStripMenuItem();
            groupStoreToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)picBoxCharacter).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEvaluate).BeginInit();
            menuStripBookStore.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.FromArgb(255, 192, 128);
            labelTitle.Font = new Font("Times New Roman", 21.8571434F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelTitle.ForeColor = Color.Blue;
            labelTitle.Location = new Point(520, 79);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(453, 58);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Henry's Book Store";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.Highlight;
            btnSignUp.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSignUp.ForeColor = Color.Yellow;
            btnSignUp.Location = new Point(38, 276);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(168, 79);
            btnSignUp.TabIndex = 1;
            btnSignUp.Text = "Tạo tài khoản\r\n(Customer)\r\n";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += CreateAccountClick;
            // 
            // btnSignInCustomer
            // 
            btnSignInCustomer.BackColor = SystemColors.Info;
            btnSignInCustomer.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSignInCustomer.ForeColor = SystemColors.ControlText;
            btnSignInCustomer.Location = new Point(38, 165);
            btnSignInCustomer.Name = "btnSignInCustomer";
            btnSignInCustomer.Size = new Size(173, 79);
            btnSignInCustomer.TabIndex = 2;
            btnSignInCustomer.Text = "Đăng nhập \r\n(Custumer)";
            btnSignInCustomer.UseVisualStyleBackColor = false;
            btnSignInCustomer.Click += SignInAccountCustomer;
            // 
            // btnSignInEmployee
            // 
            btnSignInEmployee.BackColor = Color.FromArgb(255, 128, 0);
            btnSignInEmployee.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSignInEmployee.ForeColor = SystemColors.Highlight;
            btnSignInEmployee.Location = new Point(38, 46);
            btnSignInEmployee.Name = "btnSignInEmployee";
            btnSignInEmployee.Size = new Size(173, 79);
            btnSignInEmployee.TabIndex = 3;
            btnSignInEmployee.Text = "Đăng nhập \r\n(Employee)";
            btnSignInEmployee.UseVisualStyleBackColor = false;
            btnSignInEmployee.Click += btnSignInEmployee_Click;
            // 
            // rTextBoxContent
            // 
            rTextBoxContent.BackColor = SystemColors.ScrollBar;
            rTextBoxContent.Font = new Font("Times New Roman", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 163);
            rTextBoxContent.ForeColor = SystemColors.MenuText;
            rTextBoxContent.Location = new Point(23, 450);
            rTextBoxContent.Name = "rTextBoxContent";
            rTextBoxContent.Size = new Size(725, 187);
            rTextBoxContent.TabIndex = 4;
            rTextBoxContent.Text = resources.GetString("rTextBoxContent.Text");
            // 
            // picBoxCharacter
            // 
            picBoxCharacter.BackgroundImage = (Image)resources.GetObject("picBoxCharacter.BackgroundImage");
            picBoxCharacter.BackgroundImageLayout = ImageLayout.Stretch;
            picBoxCharacter.Location = new Point(754, 450);
            picBoxCharacter.Name = "picBoxCharacter";
            picBoxCharacter.Size = new Size(141, 187);
            picBoxCharacter.TabIndex = 5;
            picBoxCharacter.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 128);
            groupBox1.Controls.Add(btnSignInEmployee);
            groupBox1.Controls.Add(btnSignInCustomer);
            groupBox1.Controls.Add(btnSignUp);
            groupBox1.Font = new Font("Times New Roman", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(1138, 265);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 398);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mục Đăng Nhập";
            // 
            // picEvaluate
            // 
            picEvaluate.BackgroundImage = (Image)resources.GetObject("picEvaluate.BackgroundImage");
            picEvaluate.BackgroundImageLayout = ImageLayout.Stretch;
            picEvaluate.Location = new Point(23, 212);
            picEvaluate.Name = "picEvaluate";
            picEvaluate.Size = new Size(546, 178);
            picEvaluate.TabIndex = 7;
            picEvaluate.TabStop = false;
            // 
            // menuStripBookStore
            // 
            menuStripBookStore.ImageScalingSize = new Size(28, 28);
            menuStripBookStore.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, gópÝToolStripMenuItem, liênHệTrợGiúpToolStripMenuItem, groupStoreToolStripMenuItem });
            menuStripBookStore.Location = new Point(0, 0);
            menuStripBookStore.Name = "menuStripBookStore";
            menuStripBookStore.Size = new Size(1414, 38);
            menuStripBookStore.TabIndex = 8;
            menuStripBookStore.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(125, 34);
            trangChủToolStripMenuItem.Text = "Trang Chủ";
            // 
            // gópÝToolStripMenuItem
            // 
            gópÝToolStripMenuItem.Name = "gópÝToolStripMenuItem";
            gópÝToolStripMenuItem.Size = new Size(87, 34);
            gópÝToolStripMenuItem.Text = "Góp Ý";
            gópÝToolStripMenuItem.Click += gópÝToolStripMenuItem_Click;
            // 
            // liênHệTrợGiúpToolStripMenuItem
            // 
            liênHệTrợGiúpToolStripMenuItem.Name = "liênHệTrợGiúpToolStripMenuItem";
            liênHệTrợGiúpToolStripMenuItem.Size = new Size(185, 34);
            liênHệTrợGiúpToolStripMenuItem.Text = "Liên Hệ Trợ Giúp";
            liênHệTrợGiúpToolStripMenuItem.Click += liênHệTrợGiúpToolStripMenuItem_Click;
            // 
            // groupStoreToolStripMenuItem
            // 
            groupStoreToolStripMenuItem.Name = "groupStoreToolStripMenuItem";
            groupStoreToolStripMenuItem.Size = new Size(141, 34);
            groupStoreToolStripMenuItem.Text = "Group Store";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1414, 819);
            Controls.Add(picEvaluate);
            Controls.Add(groupBox1);
            Controls.Add(picBoxCharacter);
            Controls.Add(rTextBoxContent);
            Controls.Add(labelTitle);
            Controls.Add(menuStripBookStore);
            MainMenuStrip = menuStripBookStore;
            Name = "FormMain";
            Text = "Manage Book Store";
            ((System.ComponentModel.ISupportInitialize)picBoxCharacter).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picEvaluate).EndInit();
            menuStripBookStore.ResumeLayout(false);
            menuStripBookStore.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button btnSignUp;
        private Button btnSignInCustomer;
        private RichTextBox rTextBoxContent;
        private PictureBox picBoxCharacter;
        private Button btnSignInEmployee;
        private GroupBox groupBox1;
        private PictureBox picEvaluate;
        private MenuStrip menuStripBookStore;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem gópÝToolStripMenuItem;
        private ToolStripMenuItem liênHệTrợGiúpToolStripMenuItem;
        private ToolStripMenuItem groupStoreToolStripMenuItem;
    }
}
