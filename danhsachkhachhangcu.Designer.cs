namespace GiaoDien_qlpks
{
    partial class danhsachkhachhangcu
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
            dtgvkhcu = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            btntim = new Button();
            btntatca = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvkhcu).BeginInit();
            SuspendLayout();
            // 
            // dtgvkhcu
            // 
            dtgvkhcu.BackgroundColor = Color.FromArgb(255, 192, 192);
            dtgvkhcu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvkhcu.Location = new Point(12, 91);
            dtgvkhcu.Name = "dtgvkhcu";
            dtgvkhcu.RowTemplate.Height = 25;
            dtgvkhcu.Size = new Size(780, 550);
            dtgvkhcu.TabIndex = 0;
            dtgvkhcu.CellClick += dtgvkhcu_CellClick;
            dtgvkhcu.CellContentClick += dtgvkhcu_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(116, 28);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên khách hàng";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(269, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 34);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btntim
            // 
            btntim.BackColor = Color.FromArgb(255, 128, 128);
            btntim.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btntim.Location = new Point(528, 22);
            btntim.Name = "btntim";
            btntim.Size = new Size(75, 39);
            btntim.TabIndex = 3;
            btntim.Text = "Tìm";
            btntim.UseVisualStyleBackColor = false;
            btntim.Click += button1_Click;
            // 
            // btntatca
            // 
            btntatca.BackColor = Color.FromArgb(255, 128, 128);
            btntatca.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btntatca.Location = new Point(706, 56);
            btntatca.Name = "btntatca";
            btntatca.Size = new Size(89, 29);
            btntatca.TabIndex = 4;
            btntatca.Text = "Tất cả danh sách";
            btntatca.UseVisualStyleBackColor = false;
            btntatca.Click += btntatca_Click;
            // 
            // danhsachkhachhangcu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(807, 653);
            Controls.Add(btntatca);
            Controls.Add(btntim);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dtgvkhcu);
            Name = "danhsachkhachhangcu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lịch sử khách hàng";
            ((System.ComponentModel.ISupportInitialize)dtgvkhcu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvkhcu;
        private Label label1;
        private TextBox textBox1;
        private Button btntim;
        private Button btntatca;
    }
}