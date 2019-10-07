using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Frmdangnhap : Form
    {
        public Frmdangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if(txttaikhoan.Text != "admin" && txtmatkhau.Text !="123456"){
                MessageBox.Show("Đăng nhập không thành công! Vui lòng kiểm tra lại tài khoản và mật khẩu.");
            }
            else
            {
                MessageBox.Show("Bạn đã đăng nhập Thành công!!!");
                Frmmain frm = new Frmmain();
                frm.Show();
                this.Hide();

               
            }
        }
    }
}
