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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        bool isnrmeric(string txt)
        {
            int c = 0;
            for (int i = 0; i < txt.Length; i++)
                if (txt[i] > 48 && txt[i] < 57)
                    c++;
            if (txt.Length == c)
                return true;
                return false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        int num;
        private void btn_sum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (txt_inqut.Text != "")
            {
                num = int.Parse(txt_inqut.Text);
                for (int i = 0; i <= num; i++)
                    sum += i;
                lbl_sum.Text = sum.ToString();
                lbl_sum.Visible = true;
            }
            else
            {
                MessageBox.Show("ادخل العدد");
                txt_inqut.Focus();
                txt_inqut.SelectAll();
            }
        }

        private void btn_fact_Click(object sender, EventArgs e)
        {
            double fact = 1;
            if (txt_inqut.Text != "")
            {
                num = int.Parse(txt_inqut.Text);
                for (int i = 1; i <= num; i++)
                    fact *= i;
                lbl_fact.Text = fact.ToString();
                lbl_fact.Visible = true;
            }
            else
            {
                MessageBox.Show("ادخل العدد");
                txt_inqut.Focus();
                txt_inqut.SelectAll();
            }
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            if (txt_inqut.Text != "")
            {
                num = int.Parse(txt_inqut.Text);
                lbl_sqrt.Text = Math.Sqrt(num).ToString();
                lbl_sqrt.Visible = true;
            }
            else
            {
                MessageBox.Show("ادخل العدد");
                txt_inqut.Focus();
                txt_inqut.SelectAll();
            }
        }

        private void txt_inqut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
