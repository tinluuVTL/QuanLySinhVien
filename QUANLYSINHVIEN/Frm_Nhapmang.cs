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
    public partial class Frm_Nhapmang : Form
    {
        int Sum = 0, Suml = 0, Sumc = 0;

        private void btn_lam_Click(object sender, EventArgs e)
        {
            txt_mang.Text = " ";
            txt_sumle.Text = " ";
            txt_sumchan.Text = " ";
            txt_sum.Text = " ";
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

        public Frm_Nhapmang()
        {
            InitializeComponent();
        }

        private void btn_tinh_Click(object sender, EventArgs e)
        {
            string M = txt_mang.Text;
            string[] a = M.Split(' ');          
            int[] S = new int [a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                S[i] = int.Parse(a[i]);
                Sum += S[i];
                txt_sum.Text = Sum.ToString();
                
                if (S[i] % 2 == 0)
                {
                    Sumc += S[i];
                    txt_sumchan.Text = Sumc.ToString();
                   
                }
                if (S[i] % 2 != 0)
                {
                    Suml += S[i];
                    txt_sumle.Text = Suml.ToString();
                 
                }


            }
        }
    }
}
