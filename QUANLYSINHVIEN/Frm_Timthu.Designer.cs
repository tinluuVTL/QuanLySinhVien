namespace QLSINHVIEN
{
    partial class Frm_Timthu
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
            this.txt_nhapthu = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.lb_thu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thứ";
            // 
            // txt_nhapthu
            // 
            this.txt_nhapthu.Location = new System.Drawing.Point(128, 51);
            this.txt_nhapthu.Name = "txt_nhapthu";
            this.txt_nhapthu.Size = new System.Drawing.Size(147, 27);
            this.txt_nhapthu.TabIndex = 1;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(128, 117);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(110, 38);
            this.btn_tim.TabIndex = 2;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // lb_thu
            // 
            this.lb_thu.AutoSize = true;
            this.lb_thu.Location = new System.Drawing.Point(128, 225);
            this.lb_thu.Name = "lb_thu";
            this.lb_thu.Size = new System.Drawing.Size(0, 20);
            this.lb_thu.TabIndex = 3;
            // 
            // Frm_Timthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 277);
            this.Controls.Add(this.lb_thu);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_nhapthu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Timthu";
            this.Text = "Frm_Timthu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nhapthu;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Label lb_thu;
    }
}