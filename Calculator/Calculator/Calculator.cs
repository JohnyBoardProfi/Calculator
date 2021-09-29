using System;
using System.Windows.Forms;

namespace Calculator
{    
    public partial class Calculator : Form
    {
        public string sign;
        public double a, b;
        public bool isNewNumber = true;

        public Calculator()
        {
            InitializeComponent();
        }

        private void NumberBtn(string number)
        {
            if (!isNewNumber)
            {
                tB.Text += number;
                tB.Text += number;
            } 
            else
            {
                tB.Text = number;
                isNewNumber = false;
            }
        }

        private void btn0_Click(object sender, System.EventArgs e) => NumberBtn("0");

        private void btn1_Click(object sender, System.EventArgs e) => NumberBtn("1");

        private void btn2_Click(object sender, System.EventArgs e) => NumberBtn("2");

        private void btn3_Click(object sender, System.EventArgs e) => NumberBtn("3");

        private void btn4_Click(object sender, System.EventArgs e) => NumberBtn("4");

        private void btn5_Click(object sender, System.EventArgs e) => NumberBtn("5");

        private void btn6_Click(object sender, System.EventArgs e) => NumberBtn("6");

        private void btn7_Click(object sender, System.EventArgs e) => NumberBtn("7");

        private void btn8_Click(object sender, System.EventArgs e) => NumberBtn("8");

        private void btn9_Click(object sender, System.EventArgs e) => NumberBtn("9");

        private void btnDivide_Click(object sender, System.EventArgs e) => Operation("/");

        private void btnMultiple_Click(object sender, System.EventArgs e) => Operation("*");

        private void btnMinus_Click(object sender, System.EventArgs e) => Operation("-");

        private void btnPlus_Click(object sender, System.EventArgs e) => Operation("+");

        private void btnResult_Click(object sender, System.EventArgs e)
        {
            b = Convert.ToDouble(tB.Text);
            lbl.Text = String.Empty;
            switch (sign)
            {
                case "+":
                    tB.Text = (a + b).ToString();
                    break;
                case "-":
                    tB.Text = (a - b).ToString();
                    break;
                case "*":
                    tB.Text = (a * b).ToString();
                    break;
                case "/":
                    tB.Text = b != 0 ? (a / b).ToString() : "Cannot be divided by 0";
                    break;
            }
            sign = String.Empty;
            isNewNumber = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tB.Text = "0";
            lbl.Text = String.Empty;
            isNewNumber = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tB.Text = "0";
            isNewNumber = true;
        }

        private void btnBackSpace_Click(object sender, EventArgs e) => tB.Text = tB.Text.Length == 1 ? "0" : tB.Text.Remove(tB.Text.Length - 1);

        private void btnChange_Click(object sender, EventArgs e) => tB.Text = (Convert.ToDouble(tB.Text) * -1).ToString();

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (tB.Text.IndexOf('.') == -1)
            {
                tB.Text += '.';
                isNewNumber = false;
            }
        }

        private void Operation(string sign)
        {
            a = Convert.ToDouble(tB.Text);
            lbl.Text = tB.Text;
            lbl.Text += sign;
            this.sign = sign;
            isNewNumber = true;
        }
    }
}