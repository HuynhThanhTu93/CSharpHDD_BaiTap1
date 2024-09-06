namespace CSharpHDD_BaiTap1
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtso = new TextBox();
            btnTT = new Button();
            button2 = new Button();
            btnNhap = new Button();
            lblDaySo = new Label();
            label10 = new Label();
            lblChan = new Label();
            lblTong = new Label();
            lblLe = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 9);
            label1.Name = "label1";
            label1.Size = new Size(371, 33);
            label1.TabIndex = 0;
            label1.Text = "NHẬP DÃY SỐ VÀ TÍNH TỔNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 63);
            label2.Name = "label2";
            label2.Size = new Size(142, 33);
            label2.TabIndex = 0;
            label2.Text = "NHẬP SỐ: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 118);
            label3.Name = "label3";
            label3.Size = new Size(217, 33);
            label3.TabIndex = 0;
            label3.Text = "DÃY VỪA NHẬP: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 223);
            label5.Name = "label5";
            label5.Size = new Size(140, 33);
            label5.TabIndex = 0;
            label5.Text = "Tổng chẵn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(201, 223);
            label6.Name = "label6";
            label6.Size = new Size(104, 33);
            label6.TabIndex = 0;
            label6.Text = "Tổng lẻ";
            // 
            // txtso
            // 
            txtso.Location = new Point(172, 56);
            txtso.Name = "txtso";
            txtso.Size = new Size(100, 40);
            txtso.TabIndex = 1;
            // 
            // btnTT
            // 
            btnTT.Location = new Point(46, 286);
            btnTT.Name = "btnTT";
            btnTT.Size = new Size(135, 44);
            btnTT.TabIndex = 2;
            btnTT.Text = "Tiếp tục";
            btnTT.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(269, 286);
            button2.Name = "button2";
            button2.Size = new Size(131, 44);
            button2.TabIndex = 2;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(313, 56);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(87, 40);
            btnNhap.TabIndex = 2;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // lblDaySo
            // 
            lblDaySo.AutoSize = true;
            lblDaySo.BackColor = SystemColors.ControlDark;
            lblDaySo.Location = new Point(233, 118);
            lblDaySo.Name = "lblDaySo";
            lblDaySo.Size = new Size(167, 33);
            lblDaySo.TabIndex = 0;
            lblDaySo.Text = "                   ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10F);
            label10.Location = new Point(24, 179);
            label10.Name = "label10";
            label10.Size = new Size(218, 17);
            label10.TabIndex = 0;
            label10.Text = "TỔNG CÁC PHẦN TỬ TRONG DÃY:";
            // 
            // lblChan
            // 
            lblChan.AutoSize = true;
            lblChan.BackColor = SystemColors.ButtonShadow;
            lblChan.Location = new Point(158, 223);
            lblChan.Name = "lblChan";
            lblChan.Size = new Size(23, 33);
            lblChan.TabIndex = 0;
            lblChan.Text = " ";
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.BackColor = SystemColors.ButtonShadow;
            lblTong.Location = new Point(269, 165);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(111, 33);
            lblTong.TabIndex = 0;
            lblTong.Text = "            ";
            // 
            // lblLe
            // 
            lblLe.AutoSize = true;
            lblLe.BackColor = SystemColors.ButtonShadow;
            lblLe.Location = new Point(329, 223);
            lblLe.Name = "lblLe";
            lblLe.Size = new Size(23, 33);
            lblLe.TabIndex = 0;
            lblLe.Text = " ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 342);
            Controls.Add(button2);
            Controls.Add(btnNhap);
            Controls.Add(btnTT);
            Controls.Add(txtso);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblDaySo);
            Controls.Add(lblTong);
            Controls.Add(lblLe);
            Controls.Add(lblChan);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtso;
        private Button btnTT;
        private Button button2;
        private Button btnNhap;
        private Label lblDaySo;
        private Label label10;
        private Label lblChan;
        private Label lblTong;
        private Label lblLe;
    }
}