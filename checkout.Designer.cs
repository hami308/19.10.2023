namespace GiaoDien_qlpks
{
    partial class checkout
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
            Timkiem = new Button();
            thanhtoan = new Button();
            tabhoadon.SuspendLayout();
            tabControl1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabhoadon
            // 
            tabhoadon.Controls.Add(thanhtoan);
            tabhoadon.Text = "Thanh toán";
            tabhoadon.Click += tabhoadon_Click;
            tabhoadon.Controls.SetChildIndex(panel2, 0);
            tabhoadon.Controls.SetChildIndex(panel3, 0);
            tabhoadon.Controls.SetChildIndex(panel4, 0);
            tabhoadon.Controls.SetChildIndex(panel5, 0);
            tabhoadon.Controls.SetChildIndex(panel1, 0);
            tabhoadon.Controls.SetChildIndex(thanhtoan, 0);
            // 
            // Tongtien
            // 
            Tongtien.Location = new Point(536, 8);
            // 
            // tbsongayluutru
            // 
            tbsongayluutru.TextChanged += tbsongayluutru_TextChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 128, 128);
            panel5.Location = new Point(6, 230);
            panel5.Size = new Size(779, 178);
            // 
            // panel4
            // 
            panel4.BackColor = Color.MistyRose;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 192);
            panel3.Location = new Point(6, 158);
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Location = new Point(6, 84);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(Timkiem);
            panel1.Location = new Point(6, 13);
            panel1.Paint += panel1_Paint_2;
            panel1.Controls.SetChildIndex(tbmakhachhang, 0);
            panel1.Controls.SetChildIndex(Timkiem, 0);
            // 
            // Timkiem
            // 
            Timkiem.BackColor = Color.FromArgb(255, 128, 128);
            Timkiem.Location = new Point(554, 13);
            Timkiem.Name = "Timkiem";
            Timkiem.Size = new Size(64, 34);
            Timkiem.TabIndex = 2;
            Timkiem.Text = "Tìm";
            Timkiem.UseVisualStyleBackColor = false;
            Timkiem.Click += Timkiem_Click;
            // 
            // thanhtoan
            // 
            thanhtoan.BackColor = Color.FromArgb(255, 128, 128);
            thanhtoan.Location = new Point(322, 487);
            thanhtoan.Name = "thanhtoan";
            thanhtoan.Size = new Size(143, 44);
            thanhtoan.TabIndex = 12;
            thanhtoan.Text = "Thanh toán";
            thanhtoan.UseVisualStyleBackColor = false;
            thanhtoan.Click += thanhtoan_Click;
            // 
            // checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 582);
            Name = "checkout";
            Text = "Check out";
            Load += checkout_Load;
            tabhoadon.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Timkiem;
        private Button thanhtoan;
    }
}