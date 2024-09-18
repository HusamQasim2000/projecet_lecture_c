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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1, number2, number3;
            //string operation1 = txtoperation1.Text;
            //string operation2 = txtoperation2.Text;
            //string intermediateResult = "";
            //string finalResult = "";
            //if(double.TryParse(txtnumber1.Text, out number1)&&
            //    double.TryParse(txtnumber2.Text, out number2) 
            //double.TryParse(txtnumber3.Text, out number3))



            //    {
            //        intermediateResult = performoperation(number1, number2, operation1).ToString();
            //        if (finalResult == "NaN")
            //        {
            //            MessageBox.Show("العملية الاولى غير صحيحة");
            //            txtoperation1.Focus();
            //            return;
            //        }
            //        finalResult = performoperation(Convert.ToDouble(intermediateResult), number3, operation2).ToString();
            //        if (finalResult == ""){
            //            MessageBox.Show("  العمليةالثانية غير صحيحة");
            //            txtoperation2.Focus();
            //            return;
            //        }
            //        txtResult.Text = finalResult.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("يرجى ادخال ارقام صحيحة.");
            //    }
            string expression = txtoperation1.Text + txtoperation2.Text;
            double result = 0;
            double tempResult;
            if (!double.TryParse(txtnumber1.Text, out number1) ||
                !double.TryParse(txtnumber2.Text, out number2) ||
                !double.TryParse(txtnumber3.Text, out number3))
            {
                MessageBox.Show("يرجى ادخال ارقام صحيحة.");
            }
            string[] tokens = expression.Split(' ', '+', '-', '*', '/');
            char[] operators = expression.ToCharArray().Where(c => "+-*/".Contains(c)).ToArray();
            for(int i=0; i < operators.Length; i++)
            {
                if (operators[i] == '*' || operators[i] == '/')
                {
                    double operand1 = double.Parse(tokens[i]);
                    double operand2 = double.Parse(tokens[i+1]);
                     tempResult = operators[i] == '*' ? operand1 * operand2 : operand1 / operand2;
                    tokens[i] = tempResult.ToString();
                    tokens = tokens.Where((val, idx) => idx != i + 1).ToArray();
                    operators = operators.Where((val, idx) => idx != i).ToArray();
                    i--;
                }
            }
            for (int i = 0; i < operators.Length; i++)
            {
                if (operators[i] == '*' || operators[i] == '/')
                {
                    double operand1 = double.Parse(tokens[i]);
                    double operand2 = double.Parse(tokens[i + 1]);
                     result = operators[i] == '+' ? operand1 + operand2 : operand1 - operand2;
                    tokens[i] = result.ToString();
                    tokens = tokens.Where((val, idx) => idx != i + 1).ToArray();
                    operators = operators.Where((val, idx) => idx != i).ToArray();
                    i--;
                }
            }
            txtResult.Text = result.ToString();
        }
        //private double performoperation(double num1,double num2,string operation)
        //{
        //    switch (operation)
        //    {
        //        case "+":
        //            return num1 + num2;
        //        case "-":
        //            return num1 - num2;
        //        case "*":
        //            return num1 * num2;
        //        case "/":
        //            return num2 !=0? num1 / num2:double.NaN;
        //        default:
        //            return double.NaN;
        //    }

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
