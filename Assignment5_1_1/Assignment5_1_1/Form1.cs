using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_1_1
{
    public partial class Form1 : Form, ICalculator
    {
        public decimal? FirstValue { get; set; }
        public decimal? SecondValue { get; set; }
        public decimal? ReturnValue { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object? sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal buttonOne = 1M;
            textBox1.Text = buttonOne.ToString();
            if (FirstValue == null)
            {
                FirstValue = buttonOne;
            } else
            {
                SecondValue = buttonOne;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            decimal buttonTwo = 2M;
            textBox1.Text = buttonTwo.ToString();
            if (FirstValue == null)
            {
                FirstValue = buttonTwo;
            }
            else
            {
                SecondValue = buttonTwo;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            decimal buttonThree = 3M;
            textBox1.Text = buttonThree.ToString();
            if (FirstValue == null)
            {
                FirstValue = buttonThree;
            }
            else
            {
                SecondValue = buttonThree;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            decimal buttonFour = 4M;
            textBox1.Text = buttonFour.ToString();
            if (FirstValue == null)
            {
                FirstValue = buttonFour;
            }
            else
            {
                SecondValue = buttonFour;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            decimal buttonFive = 5M;
            textBox1.Text = buttonFive.ToString();
            if (FirstValue == null)
            {
                FirstValue = buttonFive;
            }
            else
            {
                SecondValue = buttonFive;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            decimal buttonSix = 6M;
            textBox1.Text = buttonSix.ToString();
            if (FirstValue == null)
            {
                FirstValue = buttonSix;
            }
            else
            {
                SecondValue = buttonSix;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            decimal buttonSeven = 7M;
            textBox1.Text = buttonSeven.ToString();
            if (FirstValue == null)
            {
                FirstValue = buttonSeven;
            }
            else
            {
                SecondValue = buttonSeven;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            decimal buttonEight = 8M;
            textBox1.Text = buttonEight.ToString();
            if (FirstValue == null)
            {
                FirstValue = buttonEight;
            }
            else
            {
                SecondValue = buttonEight;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            decimal buttonNine = 9M;
            textBox1.Text = buttonNine.ToString();
            if (FirstValue == null)
            {
                FirstValue = buttonNine;
            }
            else
            {
                SecondValue = buttonNine;
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            decimal buttonZero = 0M;
            textBox1.Text = buttonZero.ToString();
            if (FirstValue == null)
            {
                FirstValue = buttonZero;
            }
            else
            {
                SecondValue = buttonZero;
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text = AdditionMethod().ToString();
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text = SubtractionMethod().ToString();
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBox1.Text = MultiplicationMethod().ToString();
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBox1.Text = DivisionMethod().ToString();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            FirstValue = null;
            SecondValue = null;
            ReturnValue = null;
            textBox1.Text = "0";
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            textBox1.Text = ReturnValue.ToString();
        }
        
        public decimal? AdditionMethod()
        {
            ReturnValue = FirstValue + SecondValue;
            return ReturnValue;
        }
        public decimal? SubtractionMethod()
        {
            ReturnValue = FirstValue - SecondValue;
            return ReturnValue;
        }
        public decimal? MultiplicationMethod()
        {
            ReturnValue = FirstValue * SecondValue;
            return ReturnValue;
        }
        public decimal? DivisionMethod()
        {
            ReturnValue = FirstValue / SecondValue;
            return ReturnValue;
        }
    }
}