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
    public partial class Frm_Giaiptbac2 : Form
    {
        float delta;
        public Frm_Giaiptbac2()
        {
            InitializeComponent();
        }

        private void btn_giai_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txt_a.Text);
            float b = float.Parse(txt_b.Text);
            float c = float.Parse(txt_c.Text);

            float x;
            float x2;
            float x1;
            x1 = x2 = x = 0;
            delta = (b * b) - (4 * a * c);
            if (a == 0)
            {
                if (b == 0 && c != 0)
                    lb_ketqua.Text = "Phương trình vô nghiệm";
                if (b == 0 && c == 0)
                    lb_ketqua.Text = "Phương trình vô số nghiệm";
                else
                {
                    x = -c / b;
                    lb_ketqua.Text = "Phuong trinh co nghiem x= " + x.ToString();
                }
            }
            else
            {
                if (delta < 0)
                    lb_ketqua.Text="Phuong trinh vo nghiem";
                else if (delta == 0)
                {
                    x = -b / 2 * a;
                    lb_ketqua.Text="Phuong trinh co nghiem x= " + x.ToString();
                }
                else
                {
                    x1 = (-b - (float)Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b + (float)Math.Sqrt(delta)) / 2 * a;
                    lb_ketqua.Text="Phuong trinh co 2 nghiem  x1= " + x1.ToString()+ " và x2= " + x2.ToString();
                   
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn thoát khỏi chương trình hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
