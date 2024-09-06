using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpHDD_BaiTap1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<int> arr_Dayso = new List<int>();
        private void btnNhap_Click(object sender, EventArgs e)
        {
            int so = int.Parse(txtso.Text);
            int tong = 0;
            int chan;
            arr_Dayso.Add(so);
            lblDaySo.Text = "";
            foreach (int i in arr_Dayso)
            {
                lblDaySo.Text += i + " ";
                tong += i;
                lblTong.Text = tong.ToString();
            }
            txtso.Text = "";
            for (int i = 2; i<= so; i+=2) 
            {
                chan += i;
            } 
                
        }

    }
}
