namespace GiaoDien_qlpks
{
    partial class Datsanpham
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
            panel7 = new Panel();
            label5 = new Label();
            tbgia = new TextBox();
            panel6 = new Panel();
            btntim = new Button();
            tbtim = new TextBox();
            btndat = new Button();
            panel5 = new Panel();
            label4 = new Label();
            tbtongtien = new TextBox();
            panel4 = new Panel();
            nbsoluong = new NumericUpDown();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            tbtensp = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            tbmkh = new TextBox();
            label1 = new Label();
            panel8 = new Panel();
            label6 = new Label();
            tbid = new TextBox();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbsoluong).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(btndat);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 439);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 192, 192);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(tbgia);
            panel7.Location = new Point(387, 211);
            panel7.Name = "panel7";
            panel7.Size = new Size(405, 49);
            panel7.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 128, 128);
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 11);
            label5.Name = "label5";
            label5.Size = new Size(41, 28);
            label5.TabIndex = 3;
            label5.Text = "Giá";
            // 
            // tbgia
            // 
            tbgia.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbgia.Location = new Point(187, 8);
            tbgia.Name = "tbgia";
            tbgia.Size = new Size(162, 34);
            tbgia.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.MistyRose;
            panel6.Controls.Add(btntim);
            panel6.Controls.Add(tbtim);
            panel6.Location = new Point(12, 21);
            panel6.Name = "panel6";
            panel6.Size = new Size(369, 48);
            panel6.TabIndex = 6;
            // 
            // btntim
            // 
            btntim.BackColor = Color.Silver;
            btntim.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btntim.Location = new Point(247, 7);
            btntim.Name = "btntim";
            btntim.Size = new Size(75, 37);
            btntim.TabIndex = 3;
            btntim.Text = "Tìm";
            btntim.UseVisualStyleBackColor = false;
            btntim.Click += btntim_Click;
            // 
            // tbtim
            // 
            tbtim.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbtim.Location = new Point(53, 8);
            tbtim.Name = "tbtim";
            tbtim.Size = new Size(162, 34);
            tbtim.TabIndex = 2;
            // 
            // btndat
            // 
            btndat.BackColor = Color.FromArgb(255, 128, 128);
            btndat.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btndat.Location = new Point(567, 390);
            btndat.Name = "btndat";
            btndat.Size = new Size(75, 43);
            btndat.TabIndex = 5;
            btndat.Text = "Đặt";
            btndat.UseVisualStyleBackColor = false;
            btndat.Click += btndat_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 192, 192);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(tbtongtien);
            panel5.Location = new Point(387, 331);
            panel5.Name = "panel5";
            panel5.Size = new Size(405, 49);
            panel5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 128, 128);
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 11);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 3;
            label4.Text = "Tổng tiền";
            // 
            // tbtongtien
            // 
            tbtongtien.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbtongtien.Location = new Point(187, 8);
            tbtongtien.Name = "tbtongtien";
            tbtongtien.Size = new Size(162, 34);
            tbtongtien.TabIndex = 2;
            tbtongtien.TextChanged += tbtongtien_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 192);
            panel4.Controls.Add(nbsoluong);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(389, 271);
            panel4.Name = "panel4";
            panel4.Size = new Size(405, 49);
            panel4.TabIndex = 3;
            // 
            // nbsoluong
            // 
            nbsoluong.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            nbsoluong.Location = new Point(186, 8);
            nbsoluong.Name = "nbsoluong";
            nbsoluong.Size = new Size(161, 34);
            nbsoluong.TabIndex = 4;
            nbsoluong.ValueChanged += nbsoluong_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 128, 128);
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 11);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 3;
            label3.Text = "Số lượng";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 192);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(tbtensp);
            panel3.Location = new Point(388, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(405, 49);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 128);
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 11);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 3;
            label2.Text = "Tên sản phẩm";
            // 
            // tbtensp
            // 
            tbtensp.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbtensp.Location = new Point(186, 8);
            tbtensp.Name = "tbtensp";
            tbtensp.Size = new Size(162, 34);
            tbtensp.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(369, 341);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(tbmkh);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(388, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 49);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // tbmkh
            // 
            tbmkh.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbmkh.Location = new Point(187, 8);
            tbmkh.Name = "tbmkh";
            tbmkh.Size = new Size(161, 34);
            tbmkh.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 11);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 3;
            label1.Text = "Mã khách hàng";
            label1.Click += label1_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 192, 192);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(tbid);
            panel8.Location = new Point(389, 93);
            panel8.Name = "panel8";
            panel8.Size = new Size(405, 49);
            panel8.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 128, 128);
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 11);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 3;
            label6.Text = "ID sản phẩm";
            // 
            // tbid
            // 
            tbid.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            tbid.Location = new Point(186, 8);
            tbid.Name = "tbid";
            tbid.Size = new Size(162, 34);
            tbid.TabIndex = 2;
            // 
            // Datsanpham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Datsanpham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt sản phẩm";
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nbsoluong).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Label label4;
        private TextBox tbtongtien;
        private Panel panel4;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private TextBox tbtensp;
        private Label label1;
        private Button btndat;
        private Panel panel6;
        private Button btntim;
        private TextBox tbtim;
        private Panel panel7;
        private Label label5;
        private TextBox tbgia;
        private TextBox tbmkh;
        private NumericUpDown nbsoluong;
        private Panel panel8;
        private Label label6;
        private TextBox tbid;
    }
}