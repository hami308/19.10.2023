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
            ((System.ComponentModel.ISupportInitialize)dtgvkhcu).BeginInit();
            SuspendLayout();
            // 
            // dtgvkhcu
            // 
            dtgvkhcu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvkhcu.Location = new Point(12, 77);
            dtgvkhcu.Name = "dtgvkhcu";
            dtgvkhcu.RowTemplate.Height = 25;
            dtgvkhcu.Size = new Size(804, 462);
            dtgvkhcu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(171, 26);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên khách hàng";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(340, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 34);
            textBox1.TabIndex = 2;
            // 
            // btntim
            // 
            btntim.BackColor = Color.FromArgb(255, 128, 128);
            btntim.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btntim.Location = new Point(554, 21);
            btntim.Name = "btntim";
            btntim.Size = new Size(75, 39);
            btntim.TabIndex = 3;
            btntim.Text = "Tìm";
            btntim.UseVisualStyleBackColor = false;
            btntim.Click += button1_Click;
            // 
            // danhsachkhachhangcu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(828, 555);
            Controls.Add(btntim);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dtgvkhcu);
            Name = "danhsachkhachhangcu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách khách hàng cũ";
            ((System.ComponentModel.ISupportInitialize)dtgvkhcu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvkhcu;
        private Label label1;
        private TextBox textBox1;
        private Button btntim;
    }
}