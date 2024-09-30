namespace ThiTracNghiem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnThoat = new Button();
            btnVaoThi = new Button();
            button1 = new Button();
            grbThonTinThiSinh = new GroupBox();
            lblSoCauTN = new Label();
            lblTime = new Label();
            lblLop = new Label();
            lblNgaySinh = new Label();
            lblHoten = new Label();
            cbbMonThi = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            ptbHinhThiSinh = new PictureBox();
            llbLichThi = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            grbThonTinThiSinh.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbHinhThiSinh).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(llbLichThi);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 163);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 58);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 2;
            label8.Text = "Thông báo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bell_icon;
            pictureBox1.Location = new Point(32, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(349, 50);
            label1.Name = "label1";
            label1.Size = new Size(230, 38);
            label1.TabIndex = 0;
            label1.Text = "Thi Trắc Nghiệm";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnVaoThi);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(grbThonTinThiSinh);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 523);
            panel2.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnThoat.Location = new Point(660, 390);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(175, 70);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnVaoThi
            // 
            btnVaoThi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnVaoThi.Location = new Point(366, 390);
            btnVaoThi.Name = "btnVaoThi";
            btnVaoThi.Size = new Size(175, 70);
            btnVaoThi.TabIndex = 2;
            btnVaoThi.Text = "Vào Thi";
            btnVaoThi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button1.Location = new Point(72, 390);
            button1.Name = "button1";
            button1.Size = new Size(175, 70);
            button1.TabIndex = 1;
            button1.Text = "Xem Kết Quả";
            button1.UseVisualStyleBackColor = true;
            // 
            // grbThonTinThiSinh
            // 
            grbThonTinThiSinh.BackgroundImageLayout = ImageLayout.Center;
            grbThonTinThiSinh.Controls.Add(lblSoCauTN);
            grbThonTinThiSinh.Controls.Add(lblTime);
            grbThonTinThiSinh.Controls.Add(lblLop);
            grbThonTinThiSinh.Controls.Add(lblNgaySinh);
            grbThonTinThiSinh.Controls.Add(lblHoten);
            grbThonTinThiSinh.Controls.Add(cbbMonThi);
            grbThonTinThiSinh.Controls.Add(label7);
            grbThonTinThiSinh.Controls.Add(label6);
            grbThonTinThiSinh.Controls.Add(label5);
            grbThonTinThiSinh.Controls.Add(label4);
            grbThonTinThiSinh.Controls.Add(label3);
            grbThonTinThiSinh.Controls.Add(label2);
            grbThonTinThiSinh.Controls.Add(groupBox2);
            grbThonTinThiSinh.Location = new Point(21, 3);
            grbThonTinThiSinh.Name = "grbThonTinThiSinh";
            grbThonTinThiSinh.Size = new Size(917, 327);
            grbThonTinThiSinh.TabIndex = 0;
            grbThonTinThiSinh.TabStop = false;
            grbThonTinThiSinh.Text = "Thông tin thí sinh";
            // 
            // lblSoCauTN
            // 
            lblSoCauTN.AutoSize = true;
            lblSoCauTN.Location = new Point(767, 216);
            lblSoCauTN.Name = "lblSoCauTN";
            lblSoCauTN.Size = new Size(58, 20);
            lblSoCauTN.TabIndex = 12;
            lblSoCauTN.Text = "label12";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(767, 148);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(58, 20);
            lblTime.TabIndex = 11;
            lblTime.Text = "label11";
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new Point(361, 216);
            lblLop.Name = "lblLop";
            lblLop.Size = new Size(58, 20);
            lblLop.TabIndex = 10;
            lblLop.Text = "label10";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(365, 148);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(50, 20);
            lblNgaySinh.TabIndex = 9;
            lblNgaySinh.Text = "label9";
            // 
            // lblHoten
            // 
            lblHoten.AutoSize = true;
            lblHoten.Location = new Point(365, 80);
            lblHoten.Name = "lblHoten";
            lblHoten.Size = new Size(50, 20);
            lblHoten.TabIndex = 8;
            lblHoten.Text = "label8";
            // 
            // cbbMonThi
            // 
            cbbMonThi.FormattingEnabled = true;
            cbbMonThi.Location = new Point(674, 80);
            cbbMonThi.Name = "cbbMonThi";
            cbbMonThi.Size = new Size(151, 28);
            cbbMonThi.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(584, 216);
            label7.Name = "label7";
            label7.Size = new Size(172, 20);
            label7.TabIndex = 6;
            label7.Text = "Số câu hỏi trắc nghiệm:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(584, 148);
            label6.Name = "label6";
            label6.Size = new Size(133, 20);
            label6.TabIndex = 5;
            label6.Text = "Thời gian làm bài:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(584, 80);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 4;
            label5.Text = "Môn thi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(283, 216);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Lớp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(283, 148);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(283, 80);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ptbHinhThiSinh);
            groupBox2.Location = new Point(88, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(142, 156);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ảnh thí sinh";
            // 
            // ptbHinhThiSinh
            // 
            ptbHinhThiSinh.Location = new Point(23, 26);
            ptbHinhThiSinh.Name = "ptbHinhThiSinh";
            ptbHinhThiSinh.Size = new Size(99, 124);
            ptbHinhThiSinh.TabIndex = 0;
            ptbHinhThiSinh.TabStop = false;
            // 
            // llbLichThi
            // 
            llbLichThi.AutoSize = true;
            llbLichThi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llbLichThi.Location = new Point(155, 111);
            llbLichThi.Name = "llbLichThi";
            llbLichThi.Size = new Size(94, 31);
            llbLichThi.TabIndex = 3;
            llbLichThi.TabStop = true;
            llbLichThi.Text = "Lịch thi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 686);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Thi Trắc Nghiệm - hssv";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            grbThonTinThiSinh.ResumeLayout(false);
            grbThonTinThiSinh.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbHinhThiSinh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private GroupBox grbThonTinThiSinh;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private PictureBox ptbHinhThiSinh;
        private Label lblSoCauTN;
        private Label lblTime;
        private Label lblLop;
        private Label lblNgaySinh;
        private Label lblHoten;
        private ComboBox cbbMonThi;
        private Label label8;
        private PictureBox pictureBox1;
        private Button btnThoat;
        private Button btnVaoThi;
        private Button button1;
        private LinkLabel llbLichThi;
    }
}
