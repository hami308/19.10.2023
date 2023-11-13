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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkout));
            tabControl1 = new TabControl();
            tabthanhtoan = new TabPage();
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
            Thanhtoan = new Button();
            panel1 = new Panel();
            tbmakhachhang = new TextBox();
            Timkiem = new Button();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabthanhtoan.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabthanhtoan);
            tabControl1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(798, 440);
            tabControl1.TabIndex = 0;
            // 
            // tabthanhtoan
            // 
            tabthanhtoan.BackColor = Color.MistyRose;
            tabthanhtoan.Controls.Add(panel4);
            tabthanhtoan.Controls.Add(panel3);
            tabthanhtoan.Controls.Add(panel2);
            tabthanhtoan.Controls.Add(pictureBox1);
            tabthanhtoan.Controls.Add(Thanhtoan);
            tabthanhtoan.Controls.Add(panel1);
            tabthanhtoan.Location = new Point(4, 32);
            tabthanhtoan.Name = "tabthanhtoan";
            tabthanhtoan.Padding = new Padding(3);
            tabthanhtoan.Size = new Size(790, 404);
            tabthanhtoan.TabIndex = 0;
            tabthanhtoan.Text = "Thanh toán";
            tabthanhtoan.Click += tabthanhtoan_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(tiensanpham);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(Tongtien);
            panel4.Location = new Point(6, 231);
            panel4.Name = "panel4";
            panel4.Size = new Size(778, 55);
            panel4.TabIndex = 9;
            panel4.Paint += panel4_Paint;
            // 
            // tiensanpham
            // 
            tiensanpham.Location = new Point(158, 10);
            tiensanpham.Name = "tiensanpham";
            tiensanpham.Size = new Size(184, 31);
            tiensanpham.TabIndex = 1;
            tiensanpham.TextChanged += tiensanpham_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 12);
            label8.Name = "label8";
            label8.Size = new Size(127, 25);
            label8.TabIndex = 0;
            label8.Text = "Tiền sản phẩm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MistyRose;
            label7.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(450, 12);
            label7.Name = "label7";
            label7.Size = new Size(69, 31);
            label7.TabIndex = 3;
            label7.Text = "Tổng";
            // 
            // Tongtien
            // 
            Tongtien.Location = new Point(536, 12);
            Tongtien.Name = "Tongtien";
            Tongtien.Size = new Size(184, 31);
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
            // 
            // tbtienphong
            // 
            tbtienphong.Location = new Point(536, 10);
            tbtienphong.Name = "tbtienphong";
            tbtienphong.Size = new Size(184, 31);
            tbtienphong.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 12);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 2;
            label4.Text = "Tiền phòng";
            // 
            // tbsongayluutru
            // 
            tbsongayluutru.Location = new Point(158, 10);
            tbsongayluutru.Name = "tbsongayluutru";
            tbsongayluutru.Size = new Size(184, 31);
            tbsongayluutru.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 12);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
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
            tbsophong.Location = new Point(536, 10);
            tbsophong.Name = "tbsophong";
            tbsophong.Size = new Size(184, 31);
            tbsophong.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 12);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 2;
            label3.Text = "Số phòng";
            // 
            // tbtenkhachhang
            // 
            tbtenkhachhang.Location = new Point(158, 10);
            tbtenkhachhang.Name = "tbtenkhachhang";
            tbtenkhachhang.Size = new Size(184, 31);
            tbtenkhachhang.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(644, 291);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Thanhtoan
            // 
            Thanhtoan.BackColor = Color.FromArgb(255, 128, 128);
            Thanhtoan.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Thanhtoan.Location = new Point(329, 318);
            Thanhtoan.Name = "Thanhtoan";
            Thanhtoan.Size = new Size(121, 50);
            Thanhtoan.TabIndex = 5;
            Thanhtoan.Text = "Thanh toán";
            Thanhtoan.UseVisualStyleBackColor = false;
            Thanhtoan.Click += Thanhtoan_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(tbmakhachhang);
            panel1.Controls.Add(Timkiem);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(9, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 59);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // tbmakhachhang
            // 
            tbmakhachhang.Location = new Point(320, 13);
            tbmakhachhang.Name = "tbmakhachhang";
            tbmakhachhang.Size = new Size(184, 31);
            tbmakhachhang.TabIndex = 11;
            tbmakhachhang.TextChanged += textBox1_TextChanged;
            // 
            // Timkiem
            // 
            Timkiem.BackColor = Color.FromArgb(255, 128, 128);
            Timkiem.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            Timkiem.Location = new Point(523, 9);
            Timkiem.Name = "Timkiem";
            Timkiem.Size = new Size(75, 38);
            Timkiem.TabIndex = 4;
            Timkiem.Text = "Tìm";
            Timkiem.UseVisualStyleBackColor = false;
            Timkiem.Click += Timkiem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(156, 14);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 2;
            label2.Text = "Mã khách hàng";
            label2.Click += label2_Click;
            // 
            // checkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "checkout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check out";
            tabControl1.ResumeLayout(false);
            tabthanhtoan.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabthanhtoan;
        private Panel panel2;
        private Label label3;
        private TextBox tbtenkhachhang;
        private Label label1;
        private PictureBox pictureBox1;
        private Button Thanhtoan;
        private TextBox Tongtien;
        private Label label7;
        private Panel panel1;
        private Button Timkiem;
        private Label label2;
        private Panel panel3;
        private TextBox tbtienphong;
        private Label label4;
        private TextBox tbsongayluutru;
        private Label label5;
        private Panel panel4;
        private TextBox tiensanpham;
        private Label label8;
        private TextBox tbmakhachhang;
        private TextBox tbsophong;
    }
}