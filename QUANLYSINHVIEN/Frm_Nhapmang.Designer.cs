namespace QLSINHVIEN
{
    partial class Frm_Nhapmang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mang = new System.Windows.Forms.TextBox();
            this.txt_sumle = new System.Windows.Forms.TextBox();
            this.txt_sumchan = new System.Windows.Forms.TextBox();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.btn_tinh = new System.Windows.Forms.Button();
            this.btn_lam = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mảng A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng các số lẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng các số chẳn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng các số mảng A";
            // 
            // txt_mang
            // 
            this.txt_mang.Location = new System.Drawing.Point(225, 26);
            this.txt_mang.Name = "txt_mang";
            this.txt_mang.Size = new System.Drawing.Size(254, 27);
            this.txt_mang.TabIndex = 4;
            // 
            // txt_sumle
            // 
            this.txt_sumle.Location = new System.Drawing.Point(225, 73);
            this.txt_sumle.Name = "txt_sumle";
            this.txt_sumle.Size = new System.Drawing.Size(254, 27);
            this.txt_sumle.TabIndex = 5;
            // 
            // txt_sumchan
            // 
            this.txt_sumchan.Location = new System.Drawing.Point(225, 114);
            this.txt_sumchan.Name = "txt_sumchan";
            this.txt_sumchan.Size = new System.Drawing.Size(254, 27);
            this.txt_sumchan.TabIndex = 6;
            // 
            // txt_sum
            // 
            this.txt_sum.Location = new System.Drawing.Point(225, 156);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(254, 27);
            this.txt_sum.TabIndex = 7;
            // 
            // btn_tinh
            // 
            this.btn_tinh.Location = new System.Drawing.Point(30, 224);
            this.btn_tinh.Name = "btn_tinh";
            this.btn_tinh.Size = new System.Drawing.Size(75, 35);
            this.btn_tinh.TabIndex = 8;
            this.btn_tinh.Text = "Tính toán";
            this.btn_tinh.UseVisualStyleBackColor = true;
            this.btn_tinh.Click += new System.EventHandler(this.btn_tinh_Click);
            // 
            // btn_lam
            // 
            this.btn_lam.Location = new System.Drawing.Point(208, 221);
            this.btn_lam.Name = "btn_lam";
            this.btn_lam.Size = new System.Drawing.Size(107, 40);
            this.btn_lam.TabIndex = 9;
            this.btn_lam.Text = "Làm mới";
            this.btn_lam.UseVisualStyleBackColor = true;
            this.btn_lam.Click += new System.EventHandler(this.btn_lam_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(404, 221);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 40);
            this.btn_thoat.TabIndex = 10;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Frm_Nhapmang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 335);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_lam);
            this.Controls.Add(this.btn_tinh);
            this.Controls.Add(this.txt_sum);
            this.Controls.Add(this.txt_sumchan);
            this.Controls.Add(this.txt_sumle);
            this.Controls.Add(this.txt_mang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Nhapmang";
            this.Text = "Frm_Nhapmang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mang;
        private System.Windows.Forms.TextBox txt_sumle;
        private System.Windows.Forms.TextBox txt_sumchan;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.Button btn_tinh;
        private System.Windows.Forms.Button btn_lam;
        private System.Windows.Forms.Button btn_thoat;
    }
}