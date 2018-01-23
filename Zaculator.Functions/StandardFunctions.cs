using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaculator.Engine
{
    class StandardFunctions
    {
        // helper method for adding two strings
        public static string Add(string preEntry, string entry)
        {
            string value = "" + (Double.Parse(preEntry) + Double.Parse(entry));
            return value;
        }

        // helper method for subtracting two strings
        public static string Subtract(string preEntry, string entry)
        {
            string value = "" + (Double.Parse(preEntry) - Double.Parse(entry));
            return value;
        }

        // helper method for multiplying two strings
        public static string Multiply(string preEntry, string entry)
        {
            string value = "" + (Double.Parse(preEntry) * Double.Parse(entry));
            return value;
        }

        // helper method for dividing two strings
        public static string Divide(string preEntry, string entry)
        {
            string value = "" + (Double.Parse(preEntry) / Double.Parse(entry));
            return value;
        }

        // helper method for integer dividision between two strings
        public static string IntegerDivide(string preEntry, string entry)
        {
            string value = "" + ((int)Double.Parse(preEntry) / (int)Double.Parse(entry));
            return value;
        }

        // negates entry
        public static string Negate(string entry)
        {
            if (entry.Contains("-"))
                entry = entry.Substring(1, entry.Length - 1);
            else
                entry = "-" + entry;
            return entry;
        }

        // used to find the reciprocal (1/x)
        public static string Reciprocal(string entry)
        {
            entry = "" + (1.0 / Double.Parse(entry));

            return entry;
        }

        // used to find the square root
        public static string Sqrt(string entry)
        {
            entry = "" + (Math.Sqrt(Double.Parse(entry)));

            return entry;
        }

        // calculates the percentage of the previous number (preEntry) mostly for
        // the purpose of adding and subtracting percents
        public static string PercentOfNumber(string preEntry, string entry)
        {
            entry = "" + (Double.Parse(preEntry) * Double.Parse(entry) / 100);

            return entry;
        }

        // used to find the modulo
        public static string Mod(string preEntry, string entry)
        {
            entry = "" + ((Double.Parse(preEntry) % Double.Parse(entry)));

            return entry;
        }
    }
}
