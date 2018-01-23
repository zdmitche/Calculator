using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaculator.Engine
{
    class ProgrammerFunctions
    {
        public static string ConvertBase(string num, string preNumBase, string numBase)
        {
            string newNum = "";

            if (numBase == preNumBase)
                newNum = num;
            else if (numBase == "oct" && preNumBase == "bin")
                newNum = DecToOct(BinToDec(num));
            else if (numBase == "dec" && preNumBase == "bin")
                newNum = BinToDec(num);
            else if (numBase == "hex" && preNumBase == "bin")
                newNum = DecToHex(BinToDec(num));
            else if (numBase == "bin" && preNumBase == "oct")
                newNum = DecToBin(OctToDec(num));
            else if (numBase == "dec" && preNumBase == "oct")
                newNum = OctToDec(num);
            else if (numBase == "hex" && preNumBase == "oct")
                newNum = DecToHex(OctToDec(num));
            else if (numBase == "bin" && preNumBase == "dec")
                newNum = DecToBin(num);
            else if (numBase == "oct" && preNumBase == "dec")
                newNum = DecToOct(num);
            else if (numBase == "hex" && preNumBase == "dec")
                newNum = DecToHex(num);
            else if (numBase == "bin" && preNumBase == "hex")
                newNum = DecToBin(HexToDec(num));
            else if (numBase == "oct" && preNumBase == "hex")
                newNum = DecToOct(HexToDec(num));
            else if (numBase == "dec" && preNumBase == "hex")
                newNum = HexToDec(num);

            return newNum;
        }

        private static string BinToDec(string binNum)
        {
            int decNum = 0;
            for (int i = binNum.Length - 1; i >= 0; i--)
            {
                decNum += (int)Double.Parse(binNum.Substring(binNum.Length - 1 - i, 1)) * (int)Math.Pow(2, i);
            }                
            return "" + decNum;
        }

        private static string OctToDec(string octNum)
        {
            int decNum = 0;
            for (int i = octNum.Length - 1; i >= 0; i--)
            {
                decNum += (int)Double.Parse(octNum.Substring(octNum.Length - 1 - i, 1)) * (int)Math.Pow(8, i);
            }
            return "" + decNum;
        }

        private static string HexToDec(string hexNum)
        {
            int decNum = 0;
            for (int i = hexNum.Length - 1; i >= 0; i--)
            {
                string hexDigit = hexNum.Substring(hexNum.Length - 1 - i, 1);
                int hexNumDigit = getDecFromHexDigit(hexDigit);
                decNum += hexNumDigit * (int)Math.Pow(16, i);
            }
            return "" + decNum;
        }

        private static string DecToBin(string decNum)
        {
            int tempNum = (int)Double.Parse(decNum);
            string binNum = "";
            while (tempNum > 0)
            {
                binNum = tempNum % 2 + binNum;
                tempNum /= 2;
            }
            return binNum;
        }

        private static string DecToOct(string decNum)
        {
            int tempNum = (int)Double.Parse(decNum);
            string octNum = "";
            while (tempNum > 0)
            {
                octNum = tempNum % 8 + octNum;
                tempNum /= 8;
            }
            return octNum;
        }

        private static string DecToHex(string decNum)
        {
            int tempNum = (int)Double.Parse(decNum);
            string hexNum = "";
            while (tempNum > 0)
            {
                int hexNumDigit = tempNum % 16;
                string hexDigit = getHexDigitFromDec(hexNumDigit);
                hexNum = hexDigit + hexNum;
                tempNum /= 16;
            }
            return hexNum;
        }

        private static string getHexDigitFromDec(int num)
        {
            string hexSymbol = "";

            if (num == 10)
                hexSymbol = "A";
            else if (num == 11)
                hexSymbol = "B";
            else if (num == 12)
                hexSymbol = "C";
            else if (num == 13)
                hexSymbol = "D";
            else if (num == 14)
                hexSymbol = "E";
            else if (num == 15)
                hexSymbol = "F";
            else
                hexSymbol = "" + num;

            return hexSymbol;
        }

        private static int getDecFromHexDigit(string hexSymbol)
        {
            int num = 0;

            if (hexSymbol == "A")
                num = 10;
            else if (hexSymbol == "B")
                num = 11;
            else if (hexSymbol == "C")
                num = 12;
            else if (hexSymbol == "D")
                num = 13;
            else if (hexSymbol == "E")
                num = 14;
            else if (hexSymbol == "F")
                num = 15;
            else
                num = (int)Double.Parse(hexSymbol);

            return num;
        }
    }
}
