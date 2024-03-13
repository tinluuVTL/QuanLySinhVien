using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSINHVIEN
{
    public partial class Frm_Dangnhap : Form
    {
        public Frm_Dangnhap()
        {
            InitializeComponent();
        }
        int dem;
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
           
            if (txt_tendn.Text == "admin" && txt_matkhau.Text == "123456")
            {
                frm_QLsinhvien frm_qlsv = new frm_QLsinhvien();
                frm_qlsv.Show();
                this.Hide();
            }
            else
            {
                dem ++;
                MessageBox.Show("Đăng nhập thất bại, mời nhập lại!!");
                if(dem ==3)
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần");
                    Application.Exit();
                }

            }           
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_tendn.Text = " ";
            txt_matkhau.Text = " ";

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn thoát khỏi chương trình hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
