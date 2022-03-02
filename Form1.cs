using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7_1
{
    public partial class Form1 : Form
    {
        int total;
        decimal num1, num2, num3, num4;
        decimal rate1, rate2, rate3, rate4;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                num1++;
                total++;
            }
            if (radioButton2.Checked)
            {
                num2++;
                total++;
            }
            if (radioButton3.Checked)
            {
                num3++;
                total++;
            }
            if (radioButton4.Checked)
            {
                num4++;
                total++;
            }

            if (num1 != 0) rate1 = Math.Round((num1 / total) * 100, 2);
            else rate1 = 0;

            if (num2 != 0) rate2 = Math.Round((num2 / total) * 100, 2);
            else rate2 = 0;

            if (num3 != 0) rate3 = Math.Round((num3 / total) * 100, 2);
            else rate3 = 0;

            if (num4 != 0) rate4 = Math.Round((num4 / total) * 100, 2);
            else rate4 = 0;


            label2.Text = rate1.ToString() + " %";
            label3.Text = rate2.ToString() + " %";
            label4.Text = rate3.ToString() + " %";
            label5.Text = rate4.ToString() + " %";
            label6.Text = "總得票數：" + total.ToString();

            label7.Text = num1.ToString() + "票";
            label8.Text = num2.ToString() + "票";
            label9.Text = num3.ToString() + "票";
            label10.Text = num4.ToString() + "票";
        }
    }
}
