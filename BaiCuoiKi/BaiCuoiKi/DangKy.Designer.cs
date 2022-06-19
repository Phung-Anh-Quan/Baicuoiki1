
namespace BaiCuoiKi
{
    partial class DangKy
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
            this.txtDn = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txtxn = new System.Windows.Forms.TextBox();
            this.txtem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Đăng Nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xác Nhận Mật Khẩu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDn
            // 
            this.txtDn.Location = new System.Drawing.Point(337, 305);
            this.txtDn.Name = "txtDn";
            this.txtDn.Size = new System.Drawing.Size(100, 20);
            this.txtDn.TabIndex = 5;
            this.txtDn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(337, 334);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(100, 20);
            this.txtmk.TabIndex = 6;
            // 
            // txtxn
            // 
            this.txtxn.Location = new System.Drawing.Point(337, 364);
            this.txtxn.Name = "txtxn";
            this.txtxn.Size = new System.Drawing.Size(100, 20);
            this.txtxn.TabIndex = 7;
            // 
            // txtem
            // 
            this.txtem.Location = new System.Drawing.Point(337, 390);
            this.txtem.Name = "txtem";
            this.txtem.Size = new System.Drawing.Size(100, 20);
            this.txtem.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Đăng Ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaiCuoiKi.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1.Location = new System.Drawing.Point(184, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtem);
            this.Controls.Add(this.txtxn);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txtDn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DangKy";
            this.Text = "DangKy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDn;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txtxn;
        private System.Windows.Forms.TextBox txtem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}