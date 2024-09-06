namespace CSharpHDD_BaiTap1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblKQ = new Label();
            btnGiai = new Button();
            btnXTrang = new Button();
            btnThoat = new Button();
            txta = new TextBox();
            txtc = new TextBox();
            txtb = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 33);
            label1.TabIndex = 0;
            label1.Text = "Giải phương trình bậc 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 94);
            label2.Name = "label2";
            label2.Size = new Size(29, 33);
            label2.TabIndex = 0;
            label2.Text = "a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 137);
            label3.Name = "label3";
            label3.Size = new Size(30, 33);
            label3.TabIndex = 0;
            label3.Text = "b";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 179);
            label4.Name = "label4";
            label4.Size = new Size(27, 33);
            label4.TabIndex = 0;
            label4.Text = "c";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 227);
            label5.Name = "label5";
            label5.Size = new Size(106, 33);
            label5.TabIndex = 0;
            label5.Text = "Kết quả";
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Location = new Point(108, 260);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(263, 33);
            lblKQ.TabIndex = 0;
            lblKQ.Text = "                               ";
            // 
            // btnGiai
            // 
            btnGiai.Location = new Point(47, 359);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(97, 40);
            btnGiai.TabIndex = 1;
            btnGiai.Text = "Giải";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            // 
            // btnXTrang
            // 
            btnXTrang.Location = new Point(166, 359);
            btnXTrang.Name = "btnXTrang";
            btnXTrang.Size = new Size(153, 40);
            btnXTrang.TabIndex = 1;
            btnXTrang.Text = "Xóa trắng";
            btnXTrang.UseVisualStyleBackColor = true;
            btnXTrang.Click += btnXTrang_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(338, 359);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(96, 40);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txta
            // 
            txta.Location = new Point(136, 87);
            txta.Name = "txta";
            txta.Size = new Size(183, 40);
            txta.TabIndex = 2;
            // 
            // txtc
            // 
            txtc.Location = new Point(136, 172);
            txtc.Name = "txtc";
            txtc.Size = new Size(183, 40);
            txtc.TabIndex = 2;
            // 
            // txtb
            // 
            txtb.Location = new Point(136, 130);
            txtb.Name = "txtb";
            txtb.Size = new Size(183, 40);
            txtb.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 450);
            Controls.Add(txtc);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(btnThoat);
            Controls.Add(btnXTrang);
            Controls.Add(btnGiai);
            Controls.Add(lblKQ);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "GIAI PHUONG TRINH BAC 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblKQ;
        private Button btnGiai;
        private Button btnXTrang;
        private Button btnThoat;
        private TextBox txta;
        private TextBox txtc;
        private TextBox txtb;
    }
}
