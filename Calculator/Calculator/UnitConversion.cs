using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class UnitConversion : UserControl
    {
        private bool first;

        public UnitConversion()
        {
            InitializeComponent();
            first = true;
        }

        private void unitTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fromUnitComboBox.Items.Clear();
            string currentText = ((ComboBox)sender).SelectedItem.ToString();

            if (currentText == "Angle")
            {
                fromUnitComboBox.Items.Add("Degree");
                fromUnitComboBox.Items.Add("Gradian");
                fromUnitComboBox.Items.Add("Radian");

                toUnitComboBox.Items.Add("Degree");
                toUnitComboBox.Items.Add("Gradian");
                toUnitComboBox.Items.Add("Radian");
            }
            else if (currentText == "Area")
            {
                fromUnitComboBox.Items.Add("Acres");
                fromUnitComboBox.Items.Add("Hectares");
                fromUnitComboBox.Items.Add("Square centimeter");
                fromUnitComboBox.Items.Add("Square feet");
                fromUnitComboBox.Items.Add("Square inch");
                fromUnitComboBox.Items.Add("Square kilometers");
                fromUnitComboBox.Items.Add("Square meters");
                fromUnitComboBox.Items.Add("Square mile");
                fromUnitComboBox.Items.Add("Square millimeter");
                fromUnitComboBox.Items.Add("Square yard");

                toUnitComboBox.Items.Add("Acres");
                toUnitComboBox.Items.Add("Hectares");
                toUnitComboBox.Items.Add("Square centimeter");
                toUnitComboBox.Items.Add("Square feet");
                toUnitComboBox.Items.Add("Square inch");
                toUnitComboBox.Items.Add("Square kilometers");
                toUnitComboBox.Items.Add("Square meters");
                toUnitComboBox.Items.Add("Square mile");
                toUnitComboBox.Items.Add("Square millimeter");
                toUnitComboBox.Items.Add("Square yard");
            }
            else if (currentText == "Energy")
            {
                fromUnitComboBox.Items.Add("British Thermal Unit");
                fromUnitComboBox.Items.Add("Calorie");
                fromUnitComboBox.Items.Add("Electron-Volts");
                fromUnitComboBox.Items.Add("Foot-Pound");
                fromUnitComboBox.Items.Add("Joule");
                fromUnitComboBox.Items.Add("Kilocalorie");
                fromUnitComboBox.Items.Add("Kilojoule");

                toUnitComboBox.Items.Add("British Thermal Unit");
                toUnitComboBox.Items.Add("Calorie");
                toUnitComboBox.Items.Add("Electron-Volts");
                toUnitComboBox.Items.Add("Foot-Pound");
                toUnitComboBox.Items.Add("Joule");
                toUnitComboBox.Items.Add("Kilocalorie");
                toUnitComboBox.Items.Add("Kilojoule");
            }
            else if (currentText == "Length")
            {
                fromUnitComboBox.Items.Add("Angstrom");
                fromUnitComboBox.Items.Add("Centimeters");
                fromUnitComboBox.Items.Add("Chain");
                fromUnitComboBox.Items.Add("Fathom");
                fromUnitComboBox.Items.Add("Feet");
                fromUnitComboBox.Items.Add("Hand");
                fromUnitComboBox.Items.Add("Inch");
                fromUnitComboBox.Items.Add("Kilometers");
                fromUnitComboBox.Items.Add("Link");
                fromUnitComboBox.Items.Add("Meter");
                fromUnitComboBox.Items.Add("Microns");
                fromUnitComboBox.Items.Add("Mile");
                fromUnitComboBox.Items.Add("Millimeters");
                fromUnitComboBox.Items.Add("Nanometer");
                fromUnitComboBox.Items.Add("Nautical Miles");
                fromUnitComboBox.Items.Add("PICA");
                fromUnitComboBox.Items.Add("Rods");
                fromUnitComboBox.Items.Add("Span");
                fromUnitComboBox.Items.Add("Yard");

                toUnitComboBox.Items.Add("Angstrom");
                toUnitComboBox.Items.Add("Centimeters");
                toUnitComboBox.Items.Add("Chain");
                toUnitComboBox.Items.Add("Fathom");
                toUnitComboBox.Items.Add("Feet");
                toUnitComboBox.Items.Add("Hand");
                toUnitComboBox.Items.Add("Inch");
                toUnitComboBox.Items.Add("Kilometers");
                toUnitComboBox.Items.Add("Link");
                toUnitComboBox.Items.Add("Meter");
                toUnitComboBox.Items.Add("Microns");
                toUnitComboBox.Items.Add("Mile");
                toUnitComboBox.Items.Add("Millimeters");
                toUnitComboBox.Items.Add("Nanometer");
                toUnitComboBox.Items.Add("Nautical Miles");
                toUnitComboBox.Items.Add("PICA");
                toUnitComboBox.Items.Add("Rods");
                toUnitComboBox.Items.Add("Span");
                toUnitComboBox.Items.Add("Yard");
            }
            else if (currentText == "Power")
            {
                fromUnitComboBox.Items.Add("BTU/minute");
                fromUnitComboBox.Items.Add("Foot-Pound/minute");
                fromUnitComboBox.Items.Add("Horsepower");
                fromUnitComboBox.Items.Add("Kilowatt");
                fromUnitComboBox.Items.Add("Watt");

                toUnitComboBox.Items.Add("BTU/minute");
                toUnitComboBox.Items.Add("Foot-Pound/minute");
                toUnitComboBox.Items.Add("Horsepower");
                toUnitComboBox.Items.Add("Kilowatt");
                toUnitComboBox.Items.Add("Watt");
            }
            else if (currentText == "Pressure")
            {
                fromUnitComboBox.Items.Add("Atmosphere");
                fromUnitComboBox.Items.Add("Bar");
                fromUnitComboBox.Items.Add("Kilo Pascal");
                fromUnitComboBox.Items.Add("Millimeter of mercury");
                fromUnitComboBox.Items.Add("Pascal");
                fromUnitComboBox.Items.Add("Pound per square inch (PSI)");

                toUnitComboBox.Items.Add("Atmosphere");
                toUnitComboBox.Items.Add("Bar");
                toUnitComboBox.Items.Add("Kilo Pascal");
                toUnitComboBox.Items.Add("Millimeter of mercury");
                toUnitComboBox.Items.Add("Pascal");
                toUnitComboBox.Items.Add("Pound per square inch (PSI)");
            }
            else if (currentText == "Temperature")
            {
                fromUnitComboBox.Items.Add("Degrees Celsius");
                fromUnitComboBox.Items.Add("Degrees Fahrenheit");
                fromUnitComboBox.Items.Add("Kelvin");

                toUnitComboBox.Items.Add("Degrees Celsius");
                toUnitComboBox.Items.Add("Degrees Fahrenheit");
                toUnitComboBox.Items.Add("Kelvin");
            }
            else if (currentText == "Time")
            {
                fromUnitComboBox.Items.Add("Day");
                fromUnitComboBox.Items.Add("Hour");
                fromUnitComboBox.Items.Add("Microsecond");
                fromUnitComboBox.Items.Add("Millisecond");
                fromUnitComboBox.Items.Add("Minute");
                fromUnitComboBox.Items.Add("Second");
                fromUnitComboBox.Items.Add("Week");

                toUnitComboBox.Items.Add("Day");
                toUnitComboBox.Items.Add("Hour");
                toUnitComboBox.Items.Add("Microsecond");
                toUnitComboBox.Items.Add("Millisecond");
                toUnitComboBox.Items.Add("Minute");
                toUnitComboBox.Items.Add("Second");
                toUnitComboBox.Items.Add("Week");

            }
            else if (currentText == "Velocity")
            {
                fromUnitComboBox.Items.Add("Centimeter per second");
                fromUnitComboBox.Items.Add("Feet per second");
                fromUnitComboBox.Items.Add("Kilometer per hour");
                fromUnitComboBox.Items.Add("Knots");
                fromUnitComboBox.Items.Add("Mach (at std. atm)");
                fromUnitComboBox.Items.Add("Meters per second");
                fromUnitComboBox.Items.Add("Miles per hour");

                toUnitComboBox.Items.Add("Centimeter per second");
                toUnitComboBox.Items.Add("Feet per second");
                toUnitComboBox.Items.Add("Kilometer per hour");
                toUnitComboBox.Items.Add("Knots");
                toUnitComboBox.Items.Add("Mach (at std. atm)");
                toUnitComboBox.Items.Add("Meters per second");
                toUnitComboBox.Items.Add("Miles per hour");
            }
            else if (currentText == "Volume")
            {
                fromUnitComboBox.Items.Add("Cubic centimeter");
                fromUnitComboBox.Items.Add("Cubic feet");
                fromUnitComboBox.Items.Add("Cubic inch");
                fromUnitComboBox.Items.Add("Cubic meter");
                fromUnitComboBox.Items.Add("Cubic yard");
                fromUnitComboBox.Items.Add("Fluid ounce (UK)");
                fromUnitComboBox.Items.Add("Fluid ounce (US)");
                fromUnitComboBox.Items.Add("Gallon (UK)");
                fromUnitComboBox.Items.Add("Gallon (US)");
                fromUnitComboBox.Items.Add("Liter");
                fromUnitComboBox.Items.Add("Pint (UK)");
                fromUnitComboBox.Items.Add("Pint (US)");
                fromUnitComboBox.Items.Add("Quart (UK)");
                fromUnitComboBox.Items.Add("Quart (US)");

                toUnitComboBox.Items.Add("Cubic centimeter");
                toUnitComboBox.Items.Add("Cubic feet");
                toUnitComboBox.Items.Add("Cubic inch");
                toUnitComboBox.Items.Add("Cubic meter");
                toUnitComboBox.Items.Add("Cubic yard");
                toUnitComboBox.Items.Add("Fluid ounce (UK)");
                toUnitComboBox.Items.Add("Fluid ounce (US)");
                toUnitComboBox.Items.Add("Gallon (UK)");
                toUnitComboBox.Items.Add("Gallon (US)");
                toUnitComboBox.Items.Add("Liter");
                toUnitComboBox.Items.Add("Pint (UK)");
                toUnitComboBox.Items.Add("Pint (US)");
                toUnitComboBox.Items.Add("Quart (UK)");
                toUnitComboBox.Items.Add("Quart (US)");
            }
            else if (currentText == "Weight/Mass")
            {
                fromUnitComboBox.Items.Add("Carat");
                fromUnitComboBox.Items.Add("Centigram");
                fromUnitComboBox.Items.Add("Decigram");
                fromUnitComboBox.Items.Add("Dekagram");
                fromUnitComboBox.Items.Add("Gram");
                fromUnitComboBox.Items.Add("Hectogram");
                fromUnitComboBox.Items.Add("Kilogram");
                fromUnitComboBox.Items.Add("Long ton");
                fromUnitComboBox.Items.Add("Milligram");
                fromUnitComboBox.Items.Add("Ounce");
                fromUnitComboBox.Items.Add("Pound");
                fromUnitComboBox.Items.Add("Short ton");
                fromUnitComboBox.Items.Add("Stone");
                fromUnitComboBox.Items.Add("Tonne");

                toUnitComboBox.Items.Add("Carat");
                toUnitComboBox.Items.Add("Centigram");
                toUnitComboBox.Items.Add("Decigram");
                toUnitComboBox.Items.Add("Dekagram");
                toUnitComboBox.Items.Add("Gram");
                toUnitComboBox.Items.Add("Hectogram");
                toUnitComboBox.Items.Add("Kilogram");
                toUnitComboBox.Items.Add("Long ton");
                toUnitComboBox.Items.Add("Milligram");
                toUnitComboBox.Items.Add("Ounce");
                toUnitComboBox.Items.Add("Pound");
                toUnitComboBox.Items.Add("Short ton");
                toUnitComboBox.Items.Add("Stone");
                toUnitComboBox.Items.Add("Tonne");
            }
        }

        // used to reset the font in the fromValueTextBox
        private void fromValueTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!first)
            {
                return;
            }
            TextBox thisTextBox = (TextBox)sender;
            thisTextBox.Text = "";
            thisTextBox.ForeColor = Color.Black;
            thisTextBox.Font = new Font("Microsoft Sans Serif", 8);
            first = false;
        }

        // used to ensure that the entry is valid
        private void fromValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // used to convert units
        private void convertButton_Click(object sender, EventArgs e)
        {
            double value = Double.Parse(fromValueTextBox.Text);
            string fromUnit = fromUnitComboBox.Text;
            string toUnit = toUnitComboBox.Text;

            double newValue = 0;
            string unitType = unitTypeComboBox.SelectedItem.ToString();
            switch (unitType)
            {
                case "Angle":
                    {
                        if (fromUnit == "Degree" && toUnit == "Gradian")
                            toValueTextBox.Text = "" + value * 9.0 / 10;
                        else if (fromUnit == "Degree" && toUnit == "Radian")
                            toValueTextBox.Text = "" + value * Math.PI / 180;
                        else if (fromUnit == "Gradian" && toUnit == "Radian")
                            toValueTextBox.Text = "" + value * Math.PI / 200;
                        else if (fromUnit == "Gradian" && toUnit == "Degree")
                            toValueTextBox.Text = "" + value * 10.0 / 9;
                        else if (fromUnit == "Radian" && toUnit == "Degree")
                            toValueTextBox.Text = "" + value * 180 / Math.PI;
                        else if (fromUnit == "Radian" && toUnit == "Gradian")
                            toValueTextBox.Text = "" + value * 200 / Math.PI;
                        else
                            newValue = value;
                        break;
                    }
                case "Area":
                    {

                        break;
                    }
                case "Energy":
                    break;
                case "Length":
                    break;
                case "Power":
                    break;
                case "Pressure":
                    break;
                case "Temperature":
                    break;
                case "Time":
                    break;
                case "Velocity":
                    break;
                case "Volume":
                    break;
                case "Weight/Mass":
                    break;
            }
            toValueTextBox.Text = ""+ newValue;
        }

    }
}
