using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Husam_qasim_lecture3
{
    public partial class Form3 : Form
    {
        double x, y, z;
        string[] op = { "+", "-", "*", "/" };
        public Form3()
        {
            InitializeComponent();
            comb.Items.Add("+");
            comb.Items.Add("-");
            comb.Items.Add("*");
            comb.Items.Add("/");
            comb.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtr.ReadOnly = true;
            comb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtn1.Text = txtn2.Text = txtr.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                x= Convert.ToDouble(txtn1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("تحذير", "العدد الاول غير صحيح ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtn1.Text = "";
                txtn1.Focus();
                return;
            }
            try
            {
                y = Convert.ToDouble(txtn2.Text);
            }
            catch (Exception) {
                MessageBox.Show("تحذير", "العدد الاول غير صحيح ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtn2.Text = "";
                txtn2.Focus();
                return; }
            bool f = true;
            switch (comb.SelectedIndex)
            {
                    
                case 0:z = x + y; break;
                case 1: z = x - y; break;
                case 2: z = x * y; break;
                case 3:
                    if (y != 0)
                    {
                        z = x / y;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("لا يمكن القسمة على صفر");
                        f = false;
                        txtr = null;
                        break;
                    }
                    
                default: break;
            }
            if (f)
                txtr.Text = z.ToString();
        }
    }
}

