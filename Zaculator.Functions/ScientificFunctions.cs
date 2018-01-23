using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaculator.Engine
{
    class ScientificFunctions
    {
        //-----------exponential-----------

        // used to square an entry
        public static string Square(string entry)
        {
            entry = StandardFunctions.Multiply(entry, entry);
            return entry;
        }

        // used to cube an entry
        public static string Cube(string entry)
        {
            entry = "" + Math.Pow(Double.Parse(entry), 3);
            return entry;
        }

        // raises the mathematical constant e to a number
        public static string NaturalExponent(string entry)
        {
            entry = "" + Math.Exp(Double.Parse(entry));
            return entry;
        }

        // raises x to the power of y
        public static string GenericExponent(string preEntry, string entry)
        {
            entry = "" + Math.Pow(Double.Parse(preEntry), Double.Parse(entry));
            return entry;
        }

        // used to represent scientific notation
        public static string ScientificNotation(string entry)
        {
            int eLocation = entry.IndexOf("E");
            string num1 = entry.Substring(0, eLocation);
            string num2 = entry.Substring(eLocation + 1, entry.Length - num1.Length - 1);
            entry = "" + (Double.Parse(num1) * Math.Pow(10, Double.Parse(num2)));
            return entry;
        }

        //--------------root---------------

        // takes the cubed root of a number
        public static string CubedRoot(string entry)
        {
            entry = "" + Math.Pow(Double.Parse(entry), 1 / 3.0);
            return entry;
        }

        // takes the preEntryth root of entry
        public static string GenericRoot(string preEntry, string entry)
        {
            entry = "" + Math.Pow(Double.Parse(preEntry), 1 / Double.Parse(entry));
            return entry;
        }

        //-----------logarithmic-----------

        // takes the natural log of a number
        public static string Ln(string entry)
        {
            entry = "" + Math.Log(Double.Parse(entry));
            return entry;
        }

        // takes log base x of y
        public static string GenericLog(string preEntry, string entry)
        {
            entry = "" + Math.Log(Double.Parse(entry), Double.Parse(preEntry));
            return entry;
        }

        //----------triginometric----------

        // takes the sine of the number in the selected angle units (rads/degrees)
        public static string Sin(string entry, bool degrees)
        {
            double num = Double.Parse(entry);
            if (degrees)
                num *= Math.PI / 180;
            entry = "" + Math.Sin(num);
            return entry;
        }

        // takes the cossine of the number in the selected angle units (rads/degrees)
        public static string Cos(string entry, bool degrees)
        {
            double num = Double.Parse(entry);
            if (degrees)
                num *= Math.PI / 180;
            entry = "" + Math.Cos(num);
            return entry;
        }

        // takes the tangent of the number in the selected angle units (rads/degrees)
        public static string Tan(string entry, bool degrees)
        {
            double num = Double.Parse(entry);
            if (degrees)
                num *= Math.PI / 180;
            entry = "" + Math.Tan(num);
            return entry;
        }

        // takes the inverse sine of the number and returns it in the selected angle units (rads/degrees)
        public static string Arcsin(string entry, bool degrees)
        {
            double num = Math.Asin(Double.Parse(entry));
            if (degrees)
                num *= 180 / Math.PI;
            entry = "" + num;
            return entry;
        }

        // takes the inverse cosine of the number and returns it in the selected angle units (rads/degrees)
        public static string Arccos(string entry, bool degrees)
        {
            double num = Math.Acos(Double.Parse(entry));
            if (degrees)
                num *= 180 / Math.PI;
            entry = "" + num;
            return entry;
        }

        // takes the inverse tangent of the number and returns it in the selected angle units (rads/degrees)
        public static string Arctan(string entry, bool degrees)
        {
            double num = Math.Atan(Double.Parse(entry));
            if (degrees)
                num *= 180 / Math.PI;
            entry = "" + num;
            return entry;
        }

        //-----------hyperbolic------------

        // takes the hyperbolic sine of a number
        public static string Sinh(string entry)
        {
            entry = "" + Math.Sinh(Double.Parse(entry));
            return entry;
        }

        // takes the hyperbolic cosine of a number
        public static string Cosh(string entry)
        {
            entry = "" + Math.Cosh(Double.Parse(entry));
            return entry;
        }

        // takes the hyperbolic tangent of a number
        public static string Tanh(string entry)
        {
            entry = "" + Math.Tanh(Double.Parse(entry));
            return entry;
        }
    }
}