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
            labelTenNV = new Label();
            SuspendLayout();
            // 
            // labelTenNV
            // 
            labelTenNV.AutoSize = true;
            labelTenNV.Location = new Point(386, 184);
            labelTenNV.Name = "labelTenNV";
            labelTenNV.Size = new Size(68, 30);
            labelTenNV.TabIndex = 0;
            labelTenNV.Text = "label1";
            // 
            // FormNV
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTenNV);
            Name = "FormNV";
            Text = "FormNV";
            Load += FormNV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTenNV;
    }
}