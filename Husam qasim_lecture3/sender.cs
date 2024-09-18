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
    public partial class sender : Form
    {
        public sender()
        {
            InitializeComponent();
        }
        private void traingforsender(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                if (btn == ptnyellow)
                {
                    button1.BackColor = Color.Yellow;
                }
                else if (btn == ptnred)
                {
                    button1.BackColor = Color.Red;
                }
                else if (btn == ptngreen)
                {
                    button1.BackColor = Color.Green;
                }
            }
            else if (sender is Label)
            {
                Label lbl = (Label)sender;
                if (lbl.Text == "الجهاز1")
                {
                    button1.Text = device1.Text;
                }
                else if (lbl.Text == "الجهاز2")
                {
                    button1.Text = device2.Text;
                }

            }
        }

        private void form2_Load(object sender, EventArgs e)
        {

        }
    }
}
