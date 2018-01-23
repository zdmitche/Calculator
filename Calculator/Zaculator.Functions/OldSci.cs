using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaculator.Functions
{
    class OldSci
    {
        private string preEntry;
        private string operation;
        private string entry;
        private bool first; //used for starting a chain of operations
        private bool overwrite; //used for ovewriting an entry after pressing equals
        private bool degreeSelected; //used for determining whether to use degrees or radians
        
        public ZaculatorScientific()
        {
            InitializeComponent();
            preEntry = "0";
            entry = "0";
            first = true;
            overwrite = false;
            degreeSelected = true;
        }

       //----------------------------------------------------------------------------
        //-------------------------Start of simple calculator-------------------------
        //----------------------------------------------------------------------------

        // adds current number button to display
        private void buttonNum_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button) sender;

            if (overwrite || entry == "0")
            {
                entry = currentButton.Text;
                overwrite = false;
            }
            else
            {
                entry = entry + currentButton.Text;
            }
            display.Text = entry;
        }

        // adds a decimal
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (entry == "0" || overwrite)
            {
                entry = "0.";
                overwrite = false;
            }
            else if (!entry.Contains("."))
                entry += ".";
            display.Text = entry;
        }

        // negates entry
        private void buttonNegate_Click(object sender, EventArgs e)
        {
            if (entry.Contains("-"))
                entry = entry.Substring(1, entry.Length - 1);
            else
                entry = "-" + entry;
            display.Text = entry;
        }

        // clears everything
        private void buttonClear_Click(object sender, EventArgs e)
        {
            preEntry = "0";
            entry = "0";
            first = true;
            overwrite = false;
            display.Text = entry;
        }

        // clears only entry
        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            entry = "0";
            display.Text = entry;
        }

        // takes away a character from the display unless the display
        // already has a lenth of 1
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (entry.Length == 1)
                return;
            entry = entry.Substring(0, entry.Length - 1);
            display.Text = entry;
        }

        // applies an operator to preEntry and entry
        private void operatorClick(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;

            // formats the text of the button into a string variable
            if (currentButton.Text == "−") operation = "-";
            else if (currentButton.Text == "×") operation = "*";
            else if (currentButton.Text == "÷") operation = "/";
            else operation = currentButton.Text;

            if (first)
            {
                preEntry = entry;
            }
            else
            {
                if (operation == "+")
                {
                    preEntry = add(preEntry, entry);
                }                    
                else if (operation == "-")
                {
                    preEntry = subtract(preEntry, entry);
                }
                else if (operation == "*")
                {
                    preEntry = multiply(preEntry, entry);
                }
                else if (operation == "/")
                {
                    preEntry = divide(preEntry, entry);
                }
            }
            display.Text = preEntry;

            entry = "0";
            first = false;
        }

        // finds new display based on what the previous operator was
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (operation == "+")
                entry = add(preEntry, entry);
            if (operation == "-")
                entry = subtract(preEntry, entry);
            if (operation == "*")
                entry = multiply(preEntry, entry);
            if (operation == "/")
                entry = divide(preEntry, entry);
            // start scientific calculator operations
            else if (operation == "exp") // for generic exponents
                entry = "" + Math.Pow(Double.Parse(preEntry), Double.Parse(entry));
            else if (operation == "log")
                entry = "" + Math.Log(Double.Parse(preEntry), Double.Parse(entry));
            else if (operation == "power") // for scientific notation
                entry = "" + Double.Parse(entry);
            else if (operation == "root")
                entry = "" + Math.Pow(Double.Parse(preEntry), 1 / Double.Parse(entry));
            // end scientific calculator operations

            display.Text = entry;
            preEntry = entry;
            first = true;
            overwrite = true;
        }

        // helper method for adding two strings
        private string add (string first, string second)
        {
            string value = "" + (Double.Parse(first) + Double.Parse(second));
            return value;
        }

        // helper method for subtracting two strings
        private string subtract(string first, string second)
        {
            string value = "" + (Double.Parse(first) - Double.Parse(second));
            return value;
        }

        // helper method for multiplying two strings
        private string multiply(string first, string second)
        {
            string value = "" + (Double.Parse(first) * Double.Parse(second));
            return value;
        }

        // helper method for dividing two strings
        private string divide(string first, string second)
        {
            string value = "" + (Double.Parse(first) / Double.Parse(second));
            return value;
        }

        // used to find the reciprocal (1/x)
        private void buttonReciprocal_Click(object sender, EventArgs e)
        {
            entry = "" + (1.0 / Double.Parse(entry));
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // used to find the square root
        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            entry = "" + (Math.Sqrt(Double.Parse(entry)));
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // calculates the percentage of the previous number (preEntry) mostly for
        // the purpose of adding and subtracting percents
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            entry = "" + (Double.Parse(preEntry) * Double.Parse(entry) / 100);
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // used to display the author
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Zach", "About Zaculator");
        }

        // used to enable keys to interact with the program
        private void Zaculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                Button b = new Button();
                b.Text = "1";
                buttonNum_Click(b, e);
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                Button b = new Button();
                b.Text = "2";
                buttonNum_Click(b, e);
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                Button b = new Button();
                b.Text = "3";
                buttonNum_Click(b, e);
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                Button b = new Button();
                b.Text = "4";
                buttonNum_Click(b, e);
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                Button b = new Button();
                b.Text = "5";
                buttonNum_Click(b, e);
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                Button b = new Button();
                b.Text = "6";
                buttonNum_Click(b, e);
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                Button b = new Button();
                b.Text = "7";
                buttonNum_Click(b, e);
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                Button b = new Button();
                b.Text = "8";
                buttonNum_Click(b, e);
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                Button b = new Button();
                b.Text = "9";
                buttonNum_Click(b, e);
            }
            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                Button b = new Button();
                b.Text = "0";
                buttonNum_Click(b, e);
            }
            else if (e.KeyCode == Keys.Back)
                buttonBackspace_Click(sender, e);
            else if (e.KeyCode == Keys.Decimal)
                buttonDecimal_Click(sender, e);
            else if (e.KeyCode == Keys.Add)
            {
                Button b = new Button();
                b.Text = "+";
                operatorClick(b, e);
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                Button b = new Button();
                b.Text = "-";
                operatorClick(b, e);
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                Button b = new Button();
                b.Text = "*";
                operatorClick(b, e);
            }
            else if (e.KeyCode == Keys.Divide)
            {
                Button b = new Button();
                b.Text = "/";
                operatorClick(b, e);
            }
            else if (e.KeyCode == Keys.Enter)
                buttonEquals_Click(sender, e);
        }

        // used to copy display to clipboard
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(display.Text);
        }

        // used to paste text from clipboard to display
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display.Text = Clipboard.GetText();
        }

        //----------------------------------------------------------------------------
        //--------------------------End of simple calculator--------------------------
        //----------------------------------------------------------------------------



        // used to switch to the standard calculator;
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zaculator z = new Zaculator();
            z.Show();
            z.Location = this.Location;
            this.Hide();
        }

        //-----------exponential-----------

        // used to square an entry
        private void squaredButton_Click(object sender, EventArgs e)
        {
            entry = multiply(entry, entry);
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // used to cube an entry
        private void cubedButton_Click(object sender, EventArgs e)
        {
            entry = "" + Math.Pow(Double.Parse(entry), 3);
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // raises the mathematical constant e to a number
        private void naturalExponentialButton_Click(object sender, EventArgs e)
        {
            entry = "" + Math.Exp(Double.Parse(entry));
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // raises x to the power of y
        private void genericExponentButton_Click(object sender, EventArgs e)
        {
            preEntry = entry;
            entry = "0";
            operation = "exp";
        }

        //--------------root---------------

        // takes the cubed root of a number
        private void cubedRootButton_Click(object sender, EventArgs e)
        {
            entry = "" + Math.Pow(Double.Parse(entry), 1 / 3.0);
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // takes the yth root of x
        private void genericRootButton_Click(object sender, EventArgs e)
        {
            preEntry = entry;
            entry = "0";
            operation = "root";
        }

        //-----------logarithmic-----------

        // takes the natural log of a number
        private void naturalLogButton_Click(object sender, EventArgs e)
        {
            entry = "" + Math.Log(Double.Parse(entry));
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // takes log base x of y
        private void genericLogButton_Click(object sender, EventArgs e)
        {
            preEntry = entry;
            entry = "0";
            operation = "log";
        }

        //----------triginometric----------

        // takes the sine of the number in the selected angle units (rads/degrees)
        private void sineButton_Click(object sender, EventArgs e)
        {
            double num = Double.Parse(entry);
            if (degreeSelected)
                num *= Math.PI / 180;
            entry = "" + Math.Sin(num);
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // takes the cossine of the number in the selected angle units (rads/degrees)
        private void cosineButton_Click(object sender, EventArgs e)
        {
            double num = Double.Parse(entry);
            if (degreeSelected)
                num *= Math.PI / 180;
            entry = "" + Math.Cos(num);
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // takes the tangent of the number in the selected angle units (rads/degrees)
        private void tangentButton_Click(object sender, EventArgs e)
        {
            double num = Double.Parse(entry);
            if (degreeSelected)
                num *= Math.PI / 180;
            entry = "" + Math.Tan(num);
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // takes the inverse sine of the number and returns it in the selected angle units (rads/degrees)
        private void inverseSineButton_Click(object sender, EventArgs e)
        {
            double num = Math.Asin(Double.Parse(entry));
            if (degreeSelected)
                num *= 180 / Math.PI;
            entry = "" + num;
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // takes the inverse cosine of the number and returns it in the selected angle units (rads/degrees)
        private void inverseCosineButton_Click(object sender, EventArgs e)
        {
            double num = Math.Acos(Double.Parse(entry));
            if (degreeSelected)
                num *= 180 / Math.PI;
            entry = "" + num;
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // takes the inverse tangent of the number and returns it in the selected angle units (rads/degrees)
        private void inverseTangentButton_Click(object sender, EventArgs e)
        {
            double num = Math.Atan(Double.Parse(entry));
            if (degreeSelected)
                num *= 180 / Math.PI;
            entry = "" + num;
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        //-----------hyperbolic------------

        // takes the hyperbolic sine of a number
        private void hyperbolicSineButton_Click(object sender, EventArgs e)
        {
            entry = "" + Math.Sinh(Double.Parse(entry));
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // takes the hyperbolic cosine of a number
        private void hyperbolicCosineButton_Click(object sender, EventArgs e)
        {
            entry = "" + Math.Cosh(Double.Parse(entry));
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // takes the hyperbolic tangent of a number
        private void hyperbolicTangent_Click(object sender, EventArgs e)
        {
            entry = "" + Math.Tanh(Double.Parse(entry));
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        //------------constants------------

        // used to set entry equal to the mathematical constant pi
        private void piButton_Click(object sender, EventArgs e)
        {
            entry = "" + Math.PI;
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // used to set entry equal to the mathematical constant e
        private void eButton_Click(object sender, EventArgs e)
        {
            entry = "" + Math.E;
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        //--------------other--------------

        // finds the factorial of a number
        private void factorialButton_Click(object sender, EventArgs e)
        {
            if (entry.Contains("-") || Double.Parse(entry) % 1 != 0)
            {
                display.Text = "Error";
                entry = "0";
                return;
            }

            int num = (int) Double.Parse(entry);
            int total = 1;
            for (int i = num; i > 1; i--)
            {
                total *= i;
            }

            entry = "" + total;
            display.Text = entry;
            first = true;
            overwrite = true;
        }

        // used to express entry in scientific notation
        private void exponentButton_Click(object sender, EventArgs e)
        {
            if (entry.Contains("E"))
                return;
            entry += "E";
            operation = "power";
            display.Text = entry;
        }

        // used to use trig functions in terms of degrees;
        private void degreeButton_CheckedChanged(object sender, EventArgs e)
        {
            degreeSelected = true;
        }

        // used to use trig functions in terms of radians;
        private void radianButton_CheckedChanged(object sender, EventArgs e)
        {
            degreeSelected = false;
        }

        // used to display different functions
        private void secondButton_Click(object sender, EventArgs e)
        {
            sineButton.Visible = !sineButton.Visible;
            cosineButton.Visible = !cosineButton.Visible;
            tangentButton.Visible = !tangentButton.Visible;

            inverseSineButton.Visible = !inverseSineButton.Visible;
            inverseCosineButton.Visible = !inverseCosineButton.Visible;
            inverseTangentButton.Visible = !inverseTangentButton.Visible;
        }

        // used to shut down the program
        private void ZaculatorScientific_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
