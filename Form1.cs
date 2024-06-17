using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double laisuat = Double.Parse(txtsotienlaisuat.Text.Replace("%", "")) / 100;
            double sotien, sonamgui, ketqua;
            sotien = Convert.ToInt32(txtsotiengoc.Text);
            sonamgui = Convert.ToInt32(txtkqsonamgui.Text);
            for (int i = 1; i <= sonamgui; i++)
            {
                ketqua = sotien * laisuat;
                lsbkq.Items.Add(" năm" + i + " số tiền là " + txtsotiengoc.Text + " lãi suất= " + ketqua);
                sotien += ketqua;
            }
        }
    }
    }
}
