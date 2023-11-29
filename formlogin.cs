using GiaoDien_qlpks.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GiaoDien_qlpks
{
    public partial class FormDangnhap : System.Windows.Forms.Form
    {
        public FormDangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Textbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string tendangnhap = textBox1.Text;
            string matkhau = textBox2.Text;
           

            if (!string.IsNullOrEmpty(tendangnhap) && !string.IsNullOrEmpty(matkhau) )
            {
                // Kiểm tra mật khẩu 
                DataProvider provider = new DataProvider();
                string query = $"SELECT COUNT(*) FROM [dbo].[Table_USER] WHERE USERNAME = '{tendangnhap}' AND PASSWORD = '{matkhau}'";
                if (provider.Kiemtra(query))
                {
                    MessageBox.Show(" Đăng nhập thành công !", "Thông báo");
                    Form Trangchu = new Trangchu(tendangnhap);
                    this.Hide();
                    Trangchu.ShowDialog();
                    this.Show();
 
                }
                else
                {
                    MessageBox.Show("Thông tin nhập đã sai . Vui lòng nhập lại!", "Thông báo");
                }
               
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin !", "Thông báo");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormDangnhap_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}