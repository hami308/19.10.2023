namespace GiaoDien_qlpks
{
    partial class Thongtincanhan
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
            panel1 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            tbnhaplai = new TextBox();
            thoat = new Button();
            capnhap = new Button();
            panel6 = new Panel();
            matkhaumoi = new Label();
            textBox3 = new TextBox();
            panel2 = new Panel();
            tendangnhap1 = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            matkhaucu = new Label();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(thoat);
            panel1.Controls.Add(capnhap);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 426);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCoral;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(tbnhaplai);
            panel3.Location = new Point(0, 289);
            panel3.Name = "panel3";
            panel3.Size = new Size(605, 71);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 18);
            label2.Name = "label2";
            label2.Size = new Size(241, 28);
            label2.TabIndex = 2;
            label2.Text = " Nhập lại mật khẩu mới:";
            label2.Click += label2_Click;
            // 
            // tbnhaplai
            // 
            tbnhaplai.Location = new Point(240, 23);
            tbnhaplai.Name = "tbnhaplai";
            tbnhaplai.PasswordChar = '*';
            tbnhaplai.Size = new Size(327, 23);
            tbnhaplai.TabIndex = 1;
            tbnhaplai.TextChanged += tbnhaplai_TextChanged;
            // 
            // thoat
            // 
            thoat.BackColor = Color.FromArgb(255, 192, 192);
            thoat.FlatAppearance.MouseDownBackColor = Color.Cyan;
            thoat.FlatAppearance.MouseOverBackColor = Color.Red;
            thoat.FlatStyle = FlatStyle.Flat;
            thoat.Font = new Font("Segoe UI Variable Text Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            thoat.Location = new Point(467, 374);
            thoat.Name = "thoat";
            thoat.Size = new Size(98, 39);
            thoat.TabIndex = 6;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = false;
            thoat.Click += thoat_Click;
            // 
            // capnhap
            // 
            capnhap.BackColor = Color.FromArgb(255, 192, 192);
            capnhap.FlatAppearance.BorderColor = Color.Black;
            capnhap.FlatAppearance.BorderSize = 2;
            capnhap.FlatAppearance.MouseDownBackColor = Color.Cyan;
            capnhap.FlatAppearance.MouseOverBackColor = Color.Red;
            capnhap.FlatStyle = FlatStyle.Flat;
            capnhap.Font = new Font("Segoe UI Variable Text Light", 12F, FontStyle.Bold, GraphicsUnit.Point);
            capnhap.Location = new Point(283, 375);
            capnhap.Name = "capnhap";
            capnhap.Size = new Size(107, 39);
            capnhap.TabIndex = 5;
            capnhap.Text = "Cập nhập";
            capnhap.UseVisualStyleBackColor = false;
            capnhap.Click += capnhap_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightCoral;
            panel6.Controls.Add(matkhaumoi);
            panel6.Controls.Add(textBox3);
            panel6.Location = new Point(0, 191);
            panel6.Name = "panel6";
            panel6.Size = new Size(605, 71);
            panel6.TabIndex = 3;
            // 
            // matkhaumoi
            // 
            matkhaumoi.AutoSize = true;
            matkhaumoi.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            matkhaumoi.Location = new Point(15, 18);
            matkhaumoi.Name = "matkhaumoi";
            matkhaumoi.Size = new Size(156, 28);
            matkhaumoi.TabIndex = 2;
            matkhaumoi.Text = " Mật khẩu mới:";
            matkhaumoi.Click += matkhaumoi_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(240, 23);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(327, 23);
            textBox3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCoral;
            panel2.Controls.Add(tendangnhap1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(605, 71);
            panel2.TabIndex = 0;
            // 
            // tendangnhap1
            // 
            tendangnhap1.Location = new Point(240, 26);
            tendangnhap1.Name = "tendangnhap1";
            tendangnhap1.Size = new Size(325, 23);
            tendangnhap1.TabIndex = 3;
            tendangnhap1.TextChanged += tendangnhap1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 2;
            label1.Text = "Tên đăng nhập :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightCoral;
            panel5.Controls.Add(matkhaucu);
            panel5.Controls.Add(textBox2);
            panel5.Location = new Point(12, 108);
            panel5.Name = "panel5";
            panel5.Size = new Size(605, 71);
            panel5.TabIndex = 3;
            // 
            // matkhaucu
            // 
            matkhaucu.AutoSize = true;
            matkhaucu.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            matkhaucu.Location = new Point(17, 18);
            matkhaucu.Name = "matkhaucu";
            matkhaucu.Size = new Size(135, 28);
            matkhaucu.TabIndex = 2;
            matkhaucu.Text = "Mật khẩu cũ:";
            matkhaucu.Click += matkhaucu_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 26);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(327, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Thongtincanhan
            // 
            AcceptButton = capnhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            CancelButton = thoat;
            ClientSize = new Size(634, 450);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "Thongtincanhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Label matkhaumoi;
        private TextBox textBox3;
        private Panel panel5;
        private Label matkhaucu;
        private TextBox textBox2;
        private Label label1;
        public Button capnhap;
        public Button thoat;
        private TextBox tendangnhap1;
        private Panel panel3;
        private Label label2;
        private TextBox tbnhaplai;
    }
}