namespace GiaoDien_qlpks
{
    partial class Hoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoadon));
            tabhoadon = new TabPage();
            panel1 = new Panel();
            tbmakhachhang = new TextBox();
            label9 = new Label();
            panel5 = new Panel();
            dtgvsp = new DataGridView();
            label6 = new Label();
            panel4 = new Panel();
            tiensanpham = new TextBox();
            label8 = new Label();
            label7 = new Label();
            Tongtien = new TextBox();
            panel3 = new Panel();
            tbtienphong = new TextBox();
            label4 = new Label();
            tbsongayluutru = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            tbsophong = new TextBox();
            label3 = new Label();
            tbtenkhachhang = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabhoadon.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvsp).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabhoadon
            // 
            tabhoadon.BackColor = Color.MistyRose;
            tabhoadon.Controls.Add(panel1);
            tabhoadon.Controls.Add(panel5);
            tabhoadon.Controls.Add(panel4);
            tabhoadon.Controls.Add(panel3);
            tabhoadon.Controls.Add(panel2);
            tabhoadon.Controls.Add(pictureBox1);
            tabhoadon.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tabhoadon.Location = new Point(4, 30);
            tabhoadon.Name = "tabhoadon";
            tabhoadon.Padding = new Padding(3);
            tabhoadon.Size = new Size(791, 544);
            tabhoadon.TabIndex = 1;
            tabhoadon.Text = "Hoá đơn";
            tabhoadon.Click += tabhoadon_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbmakhachhang);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(0, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 55);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint_1;
            // 
            // tbmakhachhang
            // 
            tbmakhachhang.Location = new Point(348, 12);
            tbmakhachhang.Name = "tbmakhachhang";
            tbmakhachhang.Size = new Size(184, 34);
            tbmakhachhang.TabIndex = 1;
            tbmakhachhang.TextChanged += tbmakhachhang_TextChanged_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 192, 192);
            label9.Location = new Point(192, 15);
            label9.Name = "label9";
            label9.Size = new Size(145, 28);
            label9.TabIndex = 0;
            label9.Text = "Mã khách hàng";
            // 
            // panel5
            // 
            panel5.Controls.Add(dtgvsp);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(5, 220);
            panel5.Name = "panel5";
            panel5.Size = new Size(779, 197);
            panel5.TabIndex = 10;
            panel5.Paint += panel5_Paint;
            // 
            // dtgvsp
            // 
            dtgvsp.BackgroundColor = Color.FromArgb(255, 192, 192);
            dtgvsp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvsp.Location = new Point(3, 34);
            dtgvsp.Name = "dtgvsp";
            dtgvsp.ReadOnly = true;
            dtgvsp.RowTemplate.Height = 25;
            dtgvsp.Size = new Size(773, 160);
            dtgvsp.TabIndex = 1;
            dtgvsp.CellContentClick += dtgvsp_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 6);
            label6.Name = "label6";
            label6.Size = new Size(223, 28);
            label6.TabIndex = 0;
            label6.Text = "Danh sách các sản phẩm";
            // 
            // panel4
            // 
            panel4.Controls.Add(tiensanpham);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(Tongtien);
            panel4.Location = new Point(5, 423);
            panel4.Name = "panel4";
            panel4.Size = new Size(778, 50);
            panel4.TabIndex = 9;
            panel4.Paint += panel4_Paint;
            // 
            // tiensanpham
            // 
            tiensanpham.Location = new Point(158, 10);
            tiensanpham.Name = "tiensanpham";
            tiensanpham.ReadOnly = true;
            tiensanpham.Size = new Size(184, 34);
            tiensanpham.TabIndex = 1;
            tiensanpham.TextChanged += tiensanpham_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 192, 192);
            label8.Location = new Point(13, 12);
            label8.Name = "label8";
            label8.Size = new Size(137, 28);
            label8.TabIndex = 0;
            label8.Text = "Tiền sản phẩm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 192, 192);
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(450, 9);
            label7.Name = "label7";
            label7.Size = new Size(69, 31);
            label7.TabIndex = 3;
            label7.Text = "Tổng";
            // 
            // Tongtien
            // 
            Tongtien.Location = new Point(536, 11);
            Tongtien.Name = "Tongtien";
            Tongtien.ReadOnly = true;
            Tongtien.Size = new Size(184, 34);
            Tongtien.TabIndex = 4;
            Tongtien.TextChanged += Tongtien_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(tbtienphong);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(tbsongayluutru);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(6, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(778, 55);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // tbtienphong
            // 
            tbtienphong.Location = new Point(550, 10);
            tbtienphong.Name = "tbtienphong";
            tbtienphong.ReadOnly = true;
            tbtienphong.Size = new Size(184, 34);
            tbtienphong.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 192, 192);
            label4.Location = new Point(428, 12);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 2;
            label4.Text = "Tiền phòng";
            // 
            // tbsongayluutru
            // 
            tbsongayluutru.Location = new Point(166, 10);
            tbsongayluutru.Name = "tbsongayluutru";
            tbsongayluutru.ReadOnly = true;
            tbsongayluutru.Size = new Size(184, 34);
            tbsongayluutru.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 192, 192);
            label5.Location = new Point(13, 12);
            label5.Name = "label5";
            label5.Size = new Size(146, 28);
            label5.TabIndex = 0;
            label5.Text = "Số ngày lưu trú";
            // 
            // panel2
            // 
            panel2.Controls.Add(tbsophong);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tbtenkhachhang);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(6, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 55);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // tbsophong
            // 
            tbsophong.Location = new Point(550, 10);
            tbsophong.Name = "tbsophong";
            tbsophong.ReadOnly = true;
            tbsophong.Size = new Size(184, 34);
            tbsophong.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 192);
            label3.Location = new Point(428, 12);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 2;
            label3.Text = "Số phòng";
            // 
            // tbtenkhachhang
            // 
            tbtenkhachhang.Location = new Point(164, 10);
            tbtenkhachhang.Name = "tbtenkhachhang";
            tbtenkhachhang.ReadOnly = true;
            tbtenkhachhang.Size = new Size(184, 34);
            tbtenkhachhang.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(808, 715);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabhoadon);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 578);
            tabControl1.TabIndex = 0;
            // 
            // Hoadon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 578);
            Controls.Add(tabControl1);
            Name = "Hoadon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xem hoá đơn";
            Load += Hoadon_Load;
            tabhoadon.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvsp).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected TabPage tabhoadon;
        protected DataGridView dtgvsp;
        private Label label6;
        protected TextBox tiensanpham;
        private Label label8;
        private Label label7;
        protected TextBox Tongtien;
        protected TextBox tbtienphong;
        private Label label4;
        protected TextBox tbsongayluutru;
        private Label label5;
        protected TextBox tbsophong;
        private Label label3;
        protected TextBox tbtenkhachhang;
        private Label label1;
        private PictureBox pictureBox1;
        protected TabControl tabControl1;
        protected Panel panel5;
        protected Panel panel4;
        protected Panel panel3;
        protected Panel panel2;
        protected Panel panel1;
        protected TextBox tbmakhachhang;
        private Label label9;
    }
}