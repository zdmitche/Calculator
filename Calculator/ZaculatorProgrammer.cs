using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zaculator.Engine;

namespace Calculator
{
    public partial class ZaculatorProgrammer : Form
    {
        private Controller functions;

        public ZaculatorProgrammer()
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
            display.Text = functions.Entry;
            buttonEquals.Focus();
        }

        // adds a decimal
        /*private void buttonDecimal_Click(object sender, EventArgs e)
        {
            functions.AddDecimal();
            display.Text = functions.entry;
            buttonEquals.Focus();
        }*/

        // negates entry
        private void buttonNegate_Click(object sender, EventArgs e)
        {
            functions.Negate();
            display.Text = functions.Entry;
            buttonEquals.Focus();
        }

        // clears everything
        private void buttonClear_Click(object sender, EventArgs e)
        {
            functions.Clear();
            display.Text = functions.Entry;
            buttonEquals.Focus();
        }

        // clears only entry
        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            functions.ClearEntry();
            display.Text = functions.Entry;
            buttonEquals.Focus();
        }

        // takes away a character from the display unless the display
        // already has a lenth of 1
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            functions.Backspace();
            display.Text = functions.Entry;
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

            display.Text = functions.PreEntry;
            buttonEquals.Focus();
        }

        // finds new display based on what the previous operator was
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            functions.Equals();
            display.Text = functions.PreEntry;
            buttonEquals.Focus();
        }

        // used to find the reciprocal (1/x)
        /*private void buttonReciprocal_Click(object sender, EventArgs e)
        {
            functions.Reciprocal();
            display.Text = functions.entry;
            buttonEquals.Focus();
        }*/

        // used to find the square root
        /*private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            functions.Sqrt();
            display.Text = functions.entry;
            buttonEquals.Focus();
        }*/

        // calculates the percentage of the previous number (preEntry) mostly for
        // the purpose of adding and subtracting percents
        /*private void buttonPercent_Click(object sender, EventArgs e)
        {
            functions.Percent();
            display.Text = functions.entry;
            buttonEquals.Focus();
        }*/

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
                        display.Text = functions.Entry;
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
                        display.Text = functions.Entry;
                        break;
                    }
                case Keys.Enter:
                    {
                        functions.Equals();
                        display.Text = functions.Entry;
                        break;
                    }
            }
        }

        //----------------------------------------------------------------------------
        //--------------------------End of simple calculator--------------------------
        //----------------------------------------------------------------------------

        // used to calculate remainders
        private void ModuloButton_Click(object sender, EventArgs e)
        {
            functions.Mod();
            display.Text = functions.Entry;
            buttonEquals.Focus();
        }

        private void BinRadio_CheckedChanged(object sender, EventArgs e)
        {
            enableOct(false);
            enableDec(false);
            enableHex(false);

            functions.changeBase("bin");
            display.Text = functions.Entry;
        }

        private void OctRadio_CheckedChanged(object sender, EventArgs e)
        {
            enableOct(true);
            enableDec(false);
            enableHex(false);

            functions.changeBase("oct");
            display.Text = functions.Entry;
        }

        private void DecRadio_CheckedChanged(object sender, EventArgs e)
        {
            enableOct(true);
            enableDec(true);
            enableHex(false);

            functions.changeBase("dec");
            display.Text = functions.Entry;
        }

        private void HexRadio_CheckedChanged(object sender, EventArgs e)
        {
            enableOct(true);
            enableDec(true);
            enableHex(true);

            functions.changeBase("hex");
            display.Text = functions.Entry;
        }

        // helper method to enable/disable hex
        private void enableHex(bool enable)
        {
            AButton.Enabled = enable;
            BButton.Enabled = enable;
            CButton.Enabled = enable;
            DButton.Enabled = enable;
            EButton.Enabled = enable;
            FButton.Enabled = enable;
        }

        // helper method to enable/disable dec
        private void enableDec(bool enable)
        {
            buttonNum8.Enabled = enable;
            buttonNum9.Enabled = enable;
        }

        // helper method to enable/disable oct
        private void enableOct(bool enable)
        {
            buttonNum2.Enabled = enable;
            buttonNum3.Enabled = enable;
            buttonNum4.Enabled = enable;
            buttonNum5.Enabled = enable;
            buttonNum6.Enabled = enable;
            buttonNum7.Enabled = enable;
        }

        // used to switch to the standard calculator;
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zaculator z = new Zaculator();
            z.Show();
            z.Location = this.Location;
            this.Hide();
        }

        // used to switch to the scientific calculator;
        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZaculatorScientific z = new ZaculatorScientific();
            z.Show();
            z.Location = this.Location;
            this.Hide();
        }

        // used to shut down the program
        private void ZaculatorProgrammer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}