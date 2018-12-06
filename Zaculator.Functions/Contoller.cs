using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaculator.Engine
{
    public class Controller
    {
        /// <summary>
        /// The current entry in the calculator
        /// </summary>
        public string Entry { get; set; }

        /// <summary>
        /// The previous entry in the calculator
        /// </summary>
        public string PreEntry { get; set; }

        /// <summary>
        /// The string representing the current operation
        /// </summary>
        public string operation;

        /// <summary>
        /// Used for determining whether to use degrees or radians
        /// </summary>
        public bool DegreeSelected { get; set; }

        private bool first; // used for starting a chain of operations
        private bool overwrite; // used for ovewriting an entry after pressing equals
        private bool enteredNum; //checked to see if a number has been entered before applying an operator
        private string numBase; // used for determing which number base is being used
        private string preEntryBase;

        public Controller()
        {
            PreEntry = "0";
            Entry = "0";
            first = true;
            overwrite = false;
            DegreeSelected = true;
            enteredNum = false;
            numBase = "dec";
        }

        /// <summary>
        /// Adds number button to display
        /// </summary>
        /// <param name="buttonText"></param>
        public void AddDigit(string buttonText)
        {
            if (overwrite || Entry == "0")
            {
                Entry = buttonText;
                overwrite = false;
            }
            else
            {
                Entry = Entry + buttonText;
            }
            enteredNum = true;
        }

        // Adds a decimal to display
        public void AddDecimal()
        {
            if (Entry == "0" || overwrite)
            {
                Entry = "0.";
                overwrite = false;
            }
            else if (!Entry.Contains("."))
                Entry += ".";
        }

        /// <summary>
        /// Negates entry
        /// </summary>
        public void Negate()
        {
            if (Entry.Contains("-"))
                Entry = Entry.Substring(1, Entry.Length - 1);
            else
                Entry = "-" + Entry;
        }

        /// <summary>
        /// Clears the calculator
        /// </summary>
        public void Clear()
        {
            PreEntry = "0";
            Entry = "0";
            first = true;
            overwrite = false;
        }

        /// <summary>
        /// Clears only the entry
        /// </summary>
        public void ClearEntry()
        {
            Entry = "0";
        }

        /// <summary>
        /// Takes away a character from the display unless the display already has a lenth of 1
        /// </summary>
        public void Backspace()
        {
            if (Entry.Length == 1)
                return;
            Entry = Entry.Substring(0, Entry.Length - 1);
        }

        /// <summary>
        /// Applies an operator to preEntry and entry
        /// </summary>
        /// <param name="operationText">Text representing the operation</param>
        public void Operation(string operationText)
        {
            if (numBase != "dec")
            {
                Entry = ProgrammerFunctions.ConvertBase(Entry, numBase, "dec");
                PreEntry = ProgrammerFunctions.ConvertBase(PreEntry, preEntryBase, "dec");
            }

            if (enteredNum)
            {
                preEntryBase = numBase;
                if (first)
                {
                    PreEntry = Entry;
                }
                else
                {
                    if (operation == "+")
                    {
                        PreEntry = StandardFunctions.Add(PreEntry, Entry);
                    }
                    else if (operation == "-")
                    {
                        PreEntry = StandardFunctions.Subtract(PreEntry, Entry);
                    }
                    else if (operation == "*")
                    {
                        PreEntry = StandardFunctions.Multiply(PreEntry, Entry);
                    }
                    else if (operation == "/")
                    {
                        PreEntry = StandardFunctions.Divide(PreEntry, Entry);
                    }
                }
            }

            if (numBase != "dec")
            {
                PreEntry = ProgrammerFunctions.ConvertBase(PreEntry, "dec", numBase);
                //preEntryBase = numBase;
            }

            Entry = "0";
            operation = operationText;
            first = false;
            enteredNum = false;
        }

        /// <summary>
        /// Finds new display based on previous operator
        /// </summary>
        public void Equals()
        {
            if (numBase != "dec")
            {
                Entry = ProgrammerFunctions.ConvertBase(Entry, numBase, "dec");
                PreEntry = ProgrammerFunctions.ConvertBase(PreEntry, preEntryBase, "dec");
            }

            if (operation == "+")
                Entry = StandardFunctions.Add(PreEntry, Entry);
            else if (operation == "-")
                Entry = StandardFunctions.Subtract(PreEntry, Entry);
            else if (operation == "*")
                Entry = StandardFunctions.Multiply(PreEntry, Entry);
            else if (operation == "/")
                Entry = StandardFunctions.Divide(PreEntry, Entry);
            else if (operation == "exp")
                Entry = ScientificFunctions.GenericExponent(PreEntry, Entry);
            else if (operation == "root")
                Entry = ScientificFunctions.GenericRoot(PreEntry, Entry);
            else if (operation == "log")
                Entry = ScientificFunctions.GenericLog(PreEntry, Entry);
            else if (operation == "power")
                Entry = ScientificFunctions.ScientificNotation(Entry);
            else if (operation == "i")
                Entry = StandardFunctions.IntegerDivide(PreEntry, Entry);
            else if (operation == "mod")
                Entry = StandardFunctions.Mod(PreEntry, Entry);

            PreEntry = Entry;

            if (numBase != "dec")
            {
                Entry = ProgrammerFunctions.ConvertBase(Entry, "dec", numBase);
                PreEntry = ProgrammerFunctions.ConvertBase(PreEntry, "dec", numBase);
            }

            first = true;
            overwrite = true;
            operation = "";
            enteredNum = false;
        }

        /// <summary>
        /// The reciprocal of entry (1/x)
        /// </summary>
        public void Reciprocal()
        {
            Entry = StandardFunctions.Reciprocal(Entry);

            first = true;
            enteredNum = true;
            overwrite = true;
        }

        /// <summary>
        /// Sqrt of entry
        /// </summary>
        public void Sqrt()
        {
            Entry = StandardFunctions.Sqrt(Entry);

            first = true;
            enteredNum = true;
            overwrite = true;
        }

        /// <summary>
        /// Calculates the percentage of the previous number mostly for the purpose of adding 
        /// and subtracting percents
        /// </summary>
        public void Percent()
        {
            Entry = StandardFunctions.PercentOfNumber(PreEntry, Entry);

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

        /// <summary>
        /// Squares entry
        /// </summary>
        public void Square()
        {
            Entry = ScientificFunctions.Square(Entry);
            first = true;
            overwrite = true;
        }

        /// <summary>
        /// Cubes entry
        /// </summary>
        public void Cube()
        {
            Entry = ScientificFunctions.Cube(Entry);
            first = true;
            overwrite = true;
        }

        /// <summary>
        /// Raises the mathematical constant e to a number
        /// </summary>
        public void NaturalExponent()
        {
            Entry = "" + Math.Exp(Double.Parse(Entry));
            first = true;
            overwrite = true;
        }

        /// <summary>
        /// Raises x to the power of y
        /// </summary>
        public void GenericExponent()
        {
            PreEntry = Entry;
            Entry = "0";
            operation = "exp";
        }

        //--------------root---------------

        /// <summary>
        /// Cube root of entry
        /// </summary>
        public void CubeRoot()
        {
            Entry = "" + ScientificFunctions.CubedRoot(Entry);
            first = true;
            overwrite = true;
        }

        /// <summary>
        /// Takes the yth root of x
        /// </summary>
        public void GenericRoot()
        {
            PreEntry = Entry;
            Entry = "0";
            operation = "root";
        }

        //-----------logarithmic-----------

        /// <summary>
        /// Natural log of entry
        /// </summary>
        public void NaturalLog()
        {
            Entry = "" + ScientificFunctions.Ln(Entry);
            first = true;
            overwrite = true;
        }

        /// <summary>
        /// Log base x of y
        /// </summary>
        public void GenericLog()
        {
            PreEntry = Entry;
            Entry = "0";
            operation = "log";
        }

        //----------triginometric----------

        // takes the sine of the number in the selected angle units (rads/degrees)
        public void Sine()
        {
            Entry = ScientificFunctions.Sin(Entry, DegreeSelected);
            first = true;
            overwrite = true;
        }

        // takes the cossine of the number in the selected angle units (rads/degrees)
        public void Cosine()
        {
            Entry = ScientificFunctions.Cos(Entry, DegreeSelected);
            first = true;
            overwrite = true;
        }

        // takes the tangent of the number in the selected angle units (rads/degrees)
        public void Tangent()
        {
            Entry = ScientificFunctions.Tan(Entry, DegreeSelected);
            first = true;
            overwrite = true;
        }

        // takes the inverse sine of the number and returns it in the selected angle units (rads/degrees)
        public void InverseSine()
        {
            Entry = ScientificFunctions.Arcsin(Entry, DegreeSelected);
            first = true;
            overwrite = true;
        }

        // takes the inverse cosine of the number and returns it in the selected angle units (rads/degrees)
        public void InverseCosine()
        {
            Entry = ScientificFunctions.Arccos(Entry, DegreeSelected);
            first = true;
            overwrite = true;
        }

        // takes the inverse tangent of the number and returns it in the selected angle units (rads/degrees)
        public void InverseTangent()
        {
            Entry = ScientificFunctions.Arctan(Entry, DegreeSelected);
            first = true;
            overwrite = true;
        }

        //-----------hyperbolic------------

        // takes the hyperbolic sine of a number
        public void HyperbolicSine()
        {
            Entry = ScientificFunctions.Sinh(Entry);
            first = true;
            overwrite = true;
        }

        // takes the hyperbolic cosine of a number
        public void HyperbolicCosine()
        {
            Entry = ScientificFunctions.Cosh(Entry);
            first = true;
            overwrite = true;
        }

        // takes the hyperbolic tangent of a number
        public void HyperbolicTangent()
        {
            Entry = ScientificFunctions.Tanh(Entry);
            first = true;
            overwrite = true;
        }

        //------------constants------------

        // used to set entry equal to the mathematical constant pi
        public void PI()
        {
            Entry = "" + Math.PI;
            first = true;
            overwrite = true;
        }

        // used to set entry equal to the mathematical constant e
        public void E()
        {
            Entry = "" + Math.E;
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

            int num = (int)Double.Parse(Entry);
            int total = 1;
            for (int i = num; i > 1; i--)
            {
                total *= i;
            }

            Entry = "" + total;
            first = true;
            overwrite = true;
        }

        // used to express entry in scientific notation
        public void EXP()
        {
            if (Entry.Contains("E"))
                return;
            Entry += "E";
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

            Entry = ProgrammerFunctions.ConvertBase(Entry, preNumBase, numBase);

            first = true;
            enteredNum = true;
            overwrite = true;
        }
    }
}
