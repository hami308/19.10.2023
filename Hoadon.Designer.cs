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
            dtgvhoadon = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvhoadon).BeginInit();
            SuspendLayout();
            // 
            // dtgvhoadon
            // 
            dtgvhoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvhoadon.Location = new Point(12, 53);
            dtgvhoadon.Name = "dtgvhoadon";
            dtgvhoadon.RowTemplate.Height = 25;
            dtgvhoadon.Size = new Size(776, 388);
            dtgvhoadon.TabIndex = 0;
            dtgvhoadon.CellContentClick += dtgvhoadon_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(239, 8);
            label1.Name = "label1";
            label1.Size = new Size(290, 37);
            label1.TabIndex = 1;
            label1.Text = "Danh sách các hoá đơn";
            // 
            // Hoadon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dtgvhoadon);
            Name = "Hoadon";
            Text = "Hoá Đơn";
            ((System.ComponentModel.ISupportInitialize)dtgvhoadon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvhoadon;
        private Label label1;
    }
}