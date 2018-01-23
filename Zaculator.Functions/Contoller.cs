using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaculator.Engine
{
    public class Controller
    {
        // public so it can be called by Zaculator/ScientificZaculator
        public string entry;
        public string preEntry;
        public string operation;
        public bool degreeSelected; //used for determining whether to use degrees or radians

        // private because they're not needed by Zaculator
        private bool first; //used for starting a chain of operations
        private bool overwrite; //used for ovewriting an entry after pressing equals
        private bool enteredNum; //checked to see if a number has been entered before applying an operator
        public string numBase; // used for determing which number base is being used
        private string preEntryBase;

        public Controller()
        {
            preEntry = "0";
            entry = "0";
            first = true;
            overwrite = false;
            degreeSelected = true;
            enteredNum = false;
            numBase = "dec";
        }

        //----------------------------------------------------------------------------
        //-------------------------Start of simple calculator-------------------------
        //----------------------------------------------------------------------------

        // adds current number button to display
        public void AddDigit(string buttonText)
        {
            if (overwrite || entry == "0")
            {
                entry = buttonText;
                overwrite = false;
            }
            else
            {
                entry = entry + buttonText;
            }
            enteredNum = true;
        }

        // adds a decimal
        public void AddDecimal()
        {
            if (entry == "0" || overwrite)
            {
                entry = "0.";
                overwrite = false;
            }
            else if (!entry.Contains("."))
                entry += ".";
        }

        // negates entry
        public void Negate()
        {
            if (entry.Contains("-"))
                entry = entry.Substring(1, entry.Length - 1);
            else
                entry = "-" + entry;
        }

        // clears everything
        public void Clear()
        {
            preEntry = "0";
            entry = "0";
            first = true;
            overwrite = false;
        }

        // clears only entry
        public void ClearEntry()
        {
            entry = "0";
        }

        // takes away a character from the display unless the display
        // already has a lenth of 1
        public void Backspace()
        {
            if (entry.Length == 1)
                return;
            entry = entry.Substring(0, entry.Length - 1);
        }

        // applies an operator to preEntry and entry
        public void Operation(string operationText)
        {
            if (numBase != "dec")
            {
                entry = ProgrammerFunctions.ConvertBase(entry, numBase, "dec");
                preEntry = ProgrammerFunctions.ConvertBase(preEntry, preEntryBase, "dec");
            }

            if (enteredNum)
            {
                preEntryBase = numBase;
                if (first)
                {
                    preEntry = entry;
                }
                else
                {
                    if (operation == "+")
                    {
                        preEntry = StandardFunctions.Add(preEntry, entry);
                    }
                    else if (operation == "-")
                    {
                        preEntry = StandardFunctions.Subtract(preEntry, entry);
                    }
                    else if (operation == "*")
                    {
                        preEntry = StandardFunctions.Multiply(preEntry, entry);
                    }
                    else if (operation == "/")
                    {
                        preEntry = StandardFunctions.Divide(preEntry, entry);
                    }
                }
            }

            if (numBase != "dec")
            {
                preEntry = ProgrammerFunctions.ConvertBase(preEntry, "dec", numBase);
                //preEntryBase = numBase;
            }

            entry = "0";
            operation = operationText;
            first = false;
            enteredNum = false;
        }

        // finds new display based on what the previous operator was
        public void Equals()
        {
            if (numBase != "dec")
            {
                entry = ProgrammerFunctions.ConvertBase(entry, numBase, "dec");
                preEntry = ProgrammerFunctions.ConvertBase(preEntry, preEntryBase, "dec");
            }

            if (operation == "+")
                entry = StandardFunctions.Add(preEntry, entry);
            else if (operation == "-")
                entry = StandardFunctions.Subtract(preEntry, entry);
            else if (operation == "*")
                entry = StandardFunctions.Multiply(preEntry, entry);
            else if (operation == "/")
                entry = StandardFunctions.Divide(preEntry, entry);
            else if (operation == "exp")
                entry = ScientificFunctions.GenericExponent(preEntry, entry);
            else if (operation == "root")
                entry = ScientificFunctions.GenericRoot(preEntry, entry);
            else if (operation == "log")
                entry = ScientificFunctions.GenericLog(preEntry, entry);
            else if (operation == "power")
                entry = ScientificFunctions.ScientificNotation(entry);
            else if (operation == "i")
                entry = StandardFunctions.IntegerDivide(preEntry, entry);
            else if (operation == "mod")
                entry = StandardFunctions.Mod(preEntry, entry);

            preEntry = entry;

            if (numBase != "dec")
            {
                entry = ProgrammerFunctions.ConvertBase(entry, "dec", numBase);
                preEntry = ProgrammerFunctions.ConvertBase(preEntry, "dec", numBase);
            }

            first = true;
            overwrite = true;
            operation = "";
            enteredNum = false;
        }

        // used to find the reciprocal (1/x)
        public void Reciprocal()
        {
            entry = StandardFunctions.Reciprocal(entry);

            first = true;
            enteredNum = true;
            overwrite = true;
        }

        // used to find the square root
        public void Sqrt()
        {
            entry = StandardFunctions.Sqrt(entry);

            first = true;
            enteredNum = true;
            overwrite = true;
        }

        // calculates the percentage of the previous number (preEntry) mostly for
        // the purpose of adding and subtracting percents
        public void Percent()
        {
            entry = StandardFunctions.PercentOfNumber(preEntry, entry);

            first = true;
            enteredNum = true;

            overwrite = true;
        }

        //----------------------------------------------------------------------------
        //--------------------------End of simple calculator--------------------------
        //----------------------------------------------------------------------------

        //----------------------------------------------------------------------------
        //--------------------------Start of scientific calculator--------------------
        //----------------------------------------------------------------------------


        //-----------exponential-----------

        // used to square an entry
        public void Square()
        {
            entry = ScientificFunctions.Square(entry);
            first = true;
            overwrite = true;
        }

        // used to cube an entry
        public void Cube()
        {
            entry = ScientificFunctions.Cube(entry);
            first = true;
            overwrite = true;
        }

        // raises the mathematical constant e to a number
        public void NaturalExponent()
        {
            entry = "" + Math.Exp(Double.Parse(entry));
            first = true;
            overwrite = true;
        }

        // raises x to the power of y
        public void GenericExponent()
        {
            preEntry = entry;
            entry = "0";
            operation = "exp";
        }

        //--------------root---------------

        // takes the cubed root of a number
        public void CubeRoot()
        {
            entry = "" + ScientificFunctions.CubedRoot(entry);
            first = true;
            overwrite = true;
        }

        // takes the yth root of x
        public void GenericRoot()
        {
            preEntry = entry;
            entry = "0";
            operation = "root";
        }

        //-----------logarithmic-----------

        // takes the natural log of a number
        public void NaturalLog()
        {
            entry = "" + ScientificFunctions.Ln(entry);
            first = true;
            overwrite = true;
        }

        // takes log base x of y
        public void GenericLog()
        {
            preEntry = entry;
            entry = "0";
            operation = "log";
        }

        //----------triginometric----------

        // takes the sine of the number in the selected angle units (rads/degrees)
        public void Sine()
        {
            entry = ScientificFunctions.Sin(entry, degreeSelected);
            first = true;
            overwrite = true;
        }

        // takes the cossine of the number in the selected angle units (rads/degrees)
        public void Cosine()
        {
            entry = ScientificFunctions.Cos(entry, degreeSelected);
            first = true;
            overwrite = true;
        }

        // takes the tangent of the number in the selected angle units (rads/degrees)
        public void Tangent()
        {
            entry = ScientificFunctions.Tan(entry, degreeSelected);
            first = true;
            overwrite = true;
        }

        // takes the inverse sine of the number and returns it in the selected angle units (rads/degrees)
        public void InverseSine()
        {
            entry = ScientificFunctions.Arcsin(entry, degreeSelected);
            first = true;
            overwrite = true;
        }

        // takes the inverse cosine of the number and returns it in the selected angle units (rads/degrees)
        public void InverseCosine()
        {
            entry = ScientificFunctions.Arccos(entry, degreeSelected);
            first = true;
            overwrite = true;
        }

        // takes the inverse tangent of the number and returns it in the selected angle units (rads/degrees)
        public void InverseTangent()
        {
            entry = ScientificFunctions.Arctan(entry, degreeSelected);
            first = true;
            overwrite = true;
        }

        //-----------hyperbolic------------

        // takes the hyperbolic sine of a number
        public void HyperbolicSine()
        {
            entry = ScientificFunctions.Sinh(entry);
            first = true;
            overwrite = true;
        }

        // takes the hyperbolic cosine of a number
        public void HyperbolicCosine()
        {
            entry = ScientificFunctions.Cosh(entry);
            first = true;
            overwrite = true;
        }

        // takes the hyperbolic tangent of a number
        public void HyperbolicTangent()
        {
            entry = ScientificFunctions.Tanh(entry);
            first = true;
            overwrite = true;
        }

        //------------constants------------

        // used to set entry equal to the mathematical constant pi
        public void PI()
        {
            entry = "" + Math.PI;
            first = true;
            overwrite = true;
        }

        // used to set entry equal to the mathematical constant e
        public void E()
        {
            entry = "" + Math.E;
            first = true;
            overwrite = true;
        }

        //--------------other--------------

        // finds the factorial of a number
        public void Factorial()
        {
            //if (entry.Contains("-") || Double.Parse(entry) % 1 != 0)
            //{
                //display.Text = "Error";
                //entry = "0";
                //return;
            //}

            int num = (int)Double.Parse(entry);
            int total = 1;
            for (int i = num; i > 1; i--)
            {
                total *= i;
            }

            entry = "" + total;
            first = true;
            overwrite = true;
        }

        // used to express entry in scientific notation
        public void EXP()
        {
            if (entry.Contains("E"))
                return;
            entry += "E";
            operation = "power";
        }

        public void Mod()
        {
            operation = "mod";

            first = true;
            enteredNum = true;
            overwrite = true;
        }

        //----------------------------------------------------------------------------
        //--------------------------End of scientific calculator----------------------
        //----------------------------------------------------------------------------

        //----------------------------------------------------------------------------
        //--------------------------Start of Programmer calculator--------------------
        //----------------------------------------------------------------------------

        public void changeBase(string newBase)
        {
            string preNumBase = numBase;
            numBase = newBase;

            entry = ProgrammerFunctions.ConvertBase(entry, preNumBase, numBase);

            first = true;
            enteredNum = true;
            overwrite = true;
        }
    }
}
