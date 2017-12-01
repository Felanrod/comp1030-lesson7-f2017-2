using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7
{
    public partial class Form1 : Form
    {
        const Int32 START_NUM = 100;
        const Int32 END_NUM = 120;
        const Int32 INC_2 = 2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoop1_Click(object sender, EventArgs e)
        {
            lblMsg1.Text = "";
            for (Int32 num = START_NUM; num <= END_NUM; num++)
            {
                lblMsg1.Text += num + " ";
            }
        }

        private void btnLoop2_Click(object sender, EventArgs e)
        {
            lblMsg2.Text = "";
            for (Int32 num = START_NUM; num <= END_NUM; num+= INC_2)
            {
                lblMsg2.Text += num + " ";
            }
        }

        private void btnWhile1_Click(object sender, EventArgs e)
        {
            // A few extra lines
            Int32 num = START_NUM;
            lblMsgWhile.Text = "";
            while (num <= END_NUM){
                lblMsgWhile.Text += num + " ";
                num++;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblSum.Text = "";
            bool ok = true;
            //checkBlank();
            if (Int32.TryParse(txtX.Text, out Int32 x) == false)
            {
                lblSum.Text = "Enter an Integer for x. ";
                ok = false;
            } else if (x < 0)
            {
                lblSum.Text = "Enter a positive number for x. ";
                ok = false;
            }
            if (Int32.TryParse(txtY.Text, out Int32 y) == false)
            {
                lblSum.Text += "Enter an Integer for y.";
                ok = false;
            }
            else if (y < 0)
            {
                lblSum.Text += "Enter a positive number for y.";
                ok = false;
            }
            if (ok)
            {
                Int32 sum = addNums(txtX.Text, txtY.Text);
                lblSum.Text = sum.ToString();
            }
            
        }

        private Int32 addNums(String numX, String numY)
        {
            Int32 sum = Convert.ToInt32(Convert.ToDecimal(numX)) + Convert.ToInt32(Convert.ToDecimal(numY));

            return sum;
        }

        private void checkBlank()
        {
            if (txtX.Text == "")
            {
                txtX.Text = "0";
            }
            if (txtY.Text == "")
            {
                txtY.Text = "0";
            }
        }
    }
}
