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
            labelTenKH = new Label();
            SuspendLayout();
            // 
            // labelTenKH
            // 
            labelTenKH.AutoSize = true;
            labelTenKH.Location = new Point(298, 159);
            labelTenKH.Name = "labelTenKH";
            labelTenKH.Size = new Size(116, 30);
            labelTenKH.TabIndex = 0;
            labelTenKH.Text = "labelTenKH";
            // 
            // FormKH
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTenKH);
            Name = "FormKH";
            Text = "FormKH";
            Load += FormKH_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTenKH;
    }
}