using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int val = 0, i = 0;
        double FirstNumber;
        string Operation;
        double rezult;
        string text1;
        string text2;
        string rad;

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = label1.Text + "0";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "1";
            }
            else
            {
                label1.Text = label1.Text + "1";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text = label1.Text + "2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text = label1.Text + "3";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text = label1.Text + "4";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "5";
            }
            else
            {
                label1.Text = label1.Text + "5";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text = label1.Text + "6";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text = label1.Text + "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text = label1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text = label1.Text + "9";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (val == 0)
            {
                label1.Text = label1.Text + ".";
                val = 1;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            val = 0;
            i = 0;
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {if (i == 0)
            {
                FirstNumber = Convert.ToDouble(label1.Text);
                label1.Text = "0";
                Operation = "+";
                val = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                FirstNumber = Convert.ToDouble(label1.Text);
                label1.Text = "0";
                Operation = "-";
                val = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                FirstNumber = Convert.ToDouble(label1.Text);
                label1.Text = "0";
                Operation = "*";
                val = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                FirstNumber = Convert.ToDouble(label1.Text);
                label1.Text = "0";
                Operation = "/";
                val = 0;
            }
        } 
    
        private void button30_Click(object sender, EventArgs e)
        {
            
            FirstNumber = Convert.ToDouble(label1.Text);
            label1.Text = label1.Text + "%";
            Operation = "%";
            i = 1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (val == 0)
            {
              //  label
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //3.14159265359
            label1.Text = "п";
            Operation = "п";
            i = 1;

        }

        private void button27_Click(object sender, EventArgs e)
        {
            label1.Text = "e";
            Operation = "e";
            i = 1;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            rad = label1.Text;
            label1.Text = "√" + label1.Text;
            Operation = "√";
            i = 1;
            val = 0;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "0";
            Operation = "^";
            val = 0;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "log " + label1.Text;
            Operation = "log";
            i = 1;
            val = 0;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            FirstNumber= Convert.ToDouble(label1.Text);
            label1.Text = "ln "+label1.Text;
            Operation = "ln";
            i = 1;
            val = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            FirstNumber= Convert.ToDouble(label1.Text);
            label1.Text = label1.Text + "!";
            Operation = "!";
            i = 1;
            val = 0;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            FirstNumber= Convert.ToDouble(label1.Text);
            label1.Text = "sin " + label1.Text;
            Operation = "sin";
            i = 1;
            val = 0;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "cos " + label1.Text;
            Operation = "cos";
            i = 1;
            val = 0;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "tan " + label1.Text;
            Operation = "tan";
            i = 1;
            val = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double SecondNumber=1;
            double Result;
            if (i == 0)
            {
                SecondNumber = Convert.ToDouble(label1.Text);
            }
            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                label1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                label1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                label1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    label1.Text = "Nu se poate imparti la 0";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    label1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            if (Operation == "%")
            {
                Result = (FirstNumber / 100);
                label1.Text = Convert.ToString(Result);
                FirstNumber = Result;
                i = 0;
            }

            if (Operation == "п")
            {
                
                label1.Text= "3.14159265359";
                i = 0;
            }
            if (Operation == "e")
            {
                label1.Text = "2.71828182846";
                i = 0;
            }
            if (Operation == "√")
            {
                double r;
                r = Convert.ToDouble(rad);   
                Result = Math.Sqrt(r);
                label1.Text = Convert.ToString(Result);
                FirstNumber= Result;
                i = 0;

            }
            if (Operation == "^")
            {
                Result= (Math.Pow(FirstNumber , SecondNumber));
                label1.Text = Convert.ToString(Result);
                FirstNumber= Result;
            }
            if (Operation == "log")
            {   
                Result = Math.Log10(FirstNumber);
                label1.Text = Convert.ToString(Result);
                FirstNumber = Result;
                i = 0;

            }
            if (Operation == "ln")
            {
                Result = Math.Log(FirstNumber);
                label1.Text = Convert.ToString(Result);
                FirstNumber = Result;
                i = 0;
            }
            if (Operation == "!")
            { 
                int factorial=1;
                for (int j = 1; j <= FirstNumber; j++)
                {
                    factorial *= j;
                }
                label1.Text = Convert.ToString(factorial);
                i = 0;

            }
            if (Operation == "sin")
            {
                Result = Math.Sin(FirstNumber * Math.PI / 180);
                label1.Text = Convert.ToString(Result);
                i = 0;
            }
            if (Operation == "cos")
            {
                Result = Math.Cos(FirstNumber * Math.PI / 180);
                label1.Text = Convert.ToString(Result);
                i = 0;
            }
            if (Operation == "tan")
            {
                Result = Math.Tan(FirstNumber * Math.PI / 180);
                label1.Text = Convert.ToString(Result);
                i = 0;
            }

        }

        
    }
}
