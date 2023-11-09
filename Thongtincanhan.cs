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

namespace GiaoDien_qlpks
{
    public partial class Thongtincanhan : Form
    {
        public Thongtincanhan(string tendangnhap)
        {
            InitializeComponent();
            tendangnhap1.Text = tendangnhap;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void matkhaumoi_Click(object sender, EventArgs e)
        {

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void capnhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = tendangnhap1.Text;
            string matkhaucu = textBox2.Text;
            string matkhaumoi = textBox3.Text;
            string nhaplaimatkhau = tbnhaplai.Text;

            if (!string.IsNullOrEmpty(tendangnhap) && !string.IsNullOrEmpty(matkhaucu) && !string.IsNullOrEmpty(matkhaumoi) && !string.IsNullOrEmpty(nhaplaimatkhau))
            {
                DataProvider provider = new DataProvider();
                if (provider.CheckLogin(tendangnhap, matkhaucu))
                {
                    if (matkhaumoi == nhaplaimatkhau)
                    {
                        string query = $"UPDATE [dbo].[Table_USER] SET PASSWORD = '{matkhaumoi}' WHERE USERNAME = '{tendangnhap}'";
                        provider.ExecuteQuery(query);
                        MessageBox.Show("Cập nhật mật khẩu thành công!");
                      
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không khớp. Vui lòng nhập lại mật khẩu mới.","Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng. Vui lòng nhập lại mật khẩu cũ.","Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!","Thông báo");
            }
        }

        private void tendangnhap1_TextChanged(object sender, EventArgs e)
        {

        }

        private void matkhaucu_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnhaplai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
