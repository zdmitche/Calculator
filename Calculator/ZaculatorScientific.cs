using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Zaculator.Engine;

namespace Calculator
{
    public partial class ZaculatorScientific : Form
    {
        private Controller functions;
        
        public ZaculatorScientific()
        {
            InitializeComponent();
            functions = new Controller();
        }

        //----------------------------------------------------------------------------
        //-------------------------Start of simple calculator-------------------------
        //----------------------------------------------------------------------------

        // adds current number button to display
        private void buttonNum_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            functions.AddDigit(currentButton.Text);
            display.Text = functions.entry;
            buttonEquals.Focus();
        }

        // adds a decimal
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            functions.AddDecimal();
            display.Text = functions.entry;
            buttonEquals.Focus();
        }

        // negates entry
        private void buttonNegate_Click(object sender, EventArgs e)
        {
            functions.Negate();
            display.Text = functions.entry;
            buttonEquals.Focus();
        }

        // clears everything
        private void buttonClear_Click(object sender, EventArgs e)
        {
            functions.Clear();
            display.Text = functions.entry;
            buttonEquals.Focus();
        }

        // clears only entry
        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            functions.ClearEntry();
            display.Text = functions.entry;
            buttonEquals.Focus();
        }

        // takes away a character from the display unless the display
        // already has a lenth of 1
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            functions.Backspace();
            display.Text = functions.entry;
            buttonEquals.Focus();
        }

        // applies an operator to preEntry and entry
        private void operatorClick(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            string operationText = "";

            // formats the text of the button into a string variable
            if (currentButton.Text == "−") operationText = "-";
            else if (currentButton.Text == "×") operationText = "*";
            else if (currentButton.Text == "÷") operationText = "/";
            else operationText = currentButton.Text;

            functions.Operation(operationText);

            display.Text = functions.preEntry;
            buttonEquals.Focus();
        }

        // finds new display based on what the previous operator was
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            functions.Equals();
            display.Text = functions.preEntry;
            buttonEquals.Focus();
        }

        // used to find the reciprocal (1/x)
        private void buttonReciprocal_Click(object sender, EventArgs e)
        {
            functions.Reciprocal();
            display.Text = functions.entry;
            buttonEquals.Focus();
        }

        // used to find the square root
        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            functions.Sqrt();
            display.Text = functions.entry;
            buttonEquals.Focus();
        }

        // calculates the percentage of the previous number (preEntry) mostly for
        // the purpose of adding and subtracting percents
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            functions.Percent();
            display.Text = functions.entry;
            buttonEquals.Focus();
        }

        // used to display the author
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Zach", "About Zaculator");
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

        // used to enable keys to interact with the program
        private void Zaculator_KeyDown(object sender, KeyEventArgs e)
        {
            Button b = new Button();

            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    {
                        b.Text = "1";
                        buttonNum_Click(b, null);
                        break;
                    }
                case Keys.NumPad2:
                    {
                        b.Text = "2";
                        buttonNum_Click(b, null);
                        break;
                    }
                case Keys.NumPad3:
                    {
                        b.Text = "3";
                        buttonNum_Click(b, null);
                        break;
                    }
                case Keys.NumPad4:
                    {
                        b.Text = "4";
                        buttonNum_Click(b, null);
                        break;
                    }
                case Keys.NumPad5:
                    {
                        b.Text = "5";
                        buttonNum_Click(b, null);
                        break;
                    }
                case Keys.NumPad6:
                    {
                        b.Text = "6";
                        buttonNum_Click(b, null);
                        break;
                    }
                case Keys.NumPad7:
                    {
                        b.Text = "7";
                        buttonNum_Click(b, null);
                        break;
                    }
                case Keys.NumPad8:
                    {
                        b.Text = "8";
                        buttonNum_Click(b, null);
                        break;
                    }
                case Keys.NumPad9:
                    {
                        b.Text = "9";
                        buttonNum_Click(b, null);
                        break;
                    }
                case Keys.NumPad0:
                    {
                        b.Text = "0";
                        buttonNum_Click(b, null);
                        break;
                    }
                case Keys.Decimal:
                    {
                        functions.AddDecimal();
                        display.Text = functions.entry;
                        break;
                    }
                case Keys.Add:
                    {
                        b.Text = "+";
                        operatorClick(b, null);
                        break;
                    }
                case Keys.Subtract:
                    {
                        b.Text = "-";
                        operatorClick(b, null);
                        break;
                    }
                case Keys.Multiply:
                    {
                        b.Text = "*";
                        operatorClick(b, null);
                        break;
                    }
                case Keys.Divide:
                    {
                        b.Text = "/";
                        operatorClick(b, null);
                        break;
                    }
                case Keys.Back:
                    {
                        functions.Backspace();
                        display.Text = functions.entry;
                        break;
                    }
                case Keys.Enter:
                    {
                        functions.Equals();
                        display.Text = functions.entry;
                        break;
                    }
            }
        }

        //----------------------------------------------------------------------------
        //--------------------------End of simple calculator--------------------------
        //----------------------------------------------------------------------------



        //-----------exponential-----------

        // used to square an entry
        private void squaredButton_Click(object sender, EventArgs e)
        {
            functions.Square();
            display.Text = functions.entry;
        }

        // used to cube an entry
        private void cubedButton_Click(object sender, EventArgs e)
        {
            functions.Cube();
            display.Text = functions.entry;
        }

        // raises the mathematical constant e to a number
        private void naturalExponentialButton_Click(object sender, EventArgs e)
        {
            functions.NaturalExponent();
            display.Text = functions.entry;
        }

        // raises x to the power of y
        private void genericExponentButton_Click(object sender, EventArgs e)
        {
            functions.GenericExponent();
        }

        //--------------root---------------

        // takes the cubed root of a number
        private void cubedRootButton_Click(object sender, EventArgs e)
        {
            functions.CubeRoot();
            display.Text = functions.entry;
        }

        // takes the yth root of x
        private void genericRootButton_Click(object sender, EventArgs e)
        {
            functions.GenericRoot();
        }

        //-----------logarithmic-----------

        // takes the natural log of a number
        private void naturalLogButton_Click(object sender, EventArgs e)
        {
            functions.NaturalLog();
            display.Text = functions.entry;
        }

        // takes log base x of y
        private void genericLogButton_Click(object sender, EventArgs e)
        {
            functions.GenericLog();
        }

        //----------triginometric----------

        // takes the sine of the number in the selected angle units (rads/degrees)
        private void sineButton_Click(object sender, EventArgs e)
        {
            functions.Sine();
            display.Text = functions.entry;
        }

        // takes the cossine of the number in the selected angle units (rads/degrees)
        private void cosineButton_Click(object sender, EventArgs e)
        {
            functions.Cosine();
            display.Text = functions.entry;
        }

        // takes the tangent of the number in the selected angle units (rads/degrees)
        private void tangentButton_Click(object sender, EventArgs e)
        {
            functions.Tangent();
            display.Text = functions.entry;
        }

        // takes the inverse sine of the number and returns it in the selected angle units (rads/degrees)
        private void inverseSineButton_Click(object sender, EventArgs e)
        {
            functions.InverseSine();
            display.Text = functions.entry;
        }

        // takes the inverse cosine of the number and returns it in the selected angle units (rads/degrees)
        private void inverseCosineButton_Click(object sender, EventArgs e)
        {
            functions.InverseCosine();
            display.Text = functions.entry;
        }

        // takes the inverse tangent of the number and returns it in the selected angle units (rads/degrees)
        private void inverseTangentButton_Click(object sender, EventArgs e)
        {
            functions.InverseTangent();
            display.Text = functions.entry;
        }

        //-----------hyperbolic------------

        // takes the hyperbolic sine of a number
        private void hyperbolicSineButton_Click(object sender, EventArgs e)
        {
            functions.HyperbolicSine();
            display.Text = functions.entry;
        }

        // takes the hyperbolic cosine of a number
        private void hyperbolicCosineButton_Click(object sender, EventArgs e)
        {
            functions.HyperbolicCosine();
            display.Text = functions.entry;
        }

        // takes the hyperbolic tangent of a number
        private void hyperbolicTangent_Click(object sender, EventArgs e)
        {
            functions.HyperbolicTangent();
            display.Text = functions.entry;
        }

        //------------constants------------

        // used to set entry equal to the mathematical constant pi
        private void piButton_Click(object sender, EventArgs e)
        {
            functions.PI();
            display.Text = functions.entry;
        }

        // used to set entry equal to the mathematical constant e
        private void eButton_Click(object sender, EventArgs e)
        {
            functions.E();
            display.Text = functions.entry;
        }

        //--------------other--------------

        // finds the factorial of a number
        private void factorialButton_Click(object sender, EventArgs e)
        {
            functions.Factorial();
            display.Text = functions.entry;
        }

        // used to express entry in scientific notation
        private void exponentButton_Click(object sender, EventArgs e)
        {
            functions.EXP();
            display.Text = functions.entry;
        }

        // used to use trig functions in terms of degrees;
        private void degreeButton_CheckedChanged(object sender, EventArgs e)
        {
            functions.degreeSelected = true;
            display.Text = functions.entry;
        }

        // used to use trig functions in terms of radians;
        private void radianButton_CheckedChanged(object sender, EventArgs e)
        {
            functions.degreeSelected = false;
            display.Text = functions.entry;
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

        // used to switch to the standard calculator;
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zaculator z = new Zaculator();
            z.Show();
            z.Location = this.Location;
            this.Hide();
        }

        // used to swith to the programming calculator
        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZaculatorProgrammer z = new ZaculatorProgrammer();
            z.Show();
            z.Location = this.Location;
            this.Hide();
        }

        // used to shut down the program
        private void ZaculatorScientific_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
