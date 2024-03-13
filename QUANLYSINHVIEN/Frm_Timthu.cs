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
    public partial class Frm_Timthu : Form
    {
        public Frm_Timthu()
        {
            InitializeComponent();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txt_nhapthu.Text);
            switch (a)
            {
                case 2:
                    lb_thu.Text = " Thứ hai";
                    break;
                case 3:
                    lb_thu.Text = " Thứ ba";
                    break;
                case 4:
                    lb_thu.Text = " Thứ tư";
                    break;
                case 5:
                    lb_thu.Text = " Thứ năm";
                    break;
                case 6:
                    lb_thu.Text = " Thứ sáu";
                    break;
                case 7:
                    lb_thu.Text = " Thứ bảy";
                    break;
                case 8:
                    lb_thu.Text = " Chủ nhật";
                    break;
            }
        }
    }
}
