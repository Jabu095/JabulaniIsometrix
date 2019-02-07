using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JabulaniIsoMetrix_Ass
{
    public class ResourceFile
    {
        public static string NegativeValue = "Negative number not allowed";
    }
    public class Calculator
    {
        public static int Add(string num)
        {
            if (string.IsNullOrEmpty(num))
                return 0;

            var numArray = num.Replace('\n', ',').Split(',');
            // check for nagative values
            numArray = GetNumDefaultDelimeter(numArray);
            //remove empty array
            numArray = numArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            checkNegativeNumbers(numArray);

            return numArray.Where(x => int.Parse(x) < 1000)
                .Sum(x => int.Parse(x));

        }

        private static string[] GetNumDefaultDelimeter(string[] numArray)
        {

            if (!numArray[0].StartsWith("//"))
                return numArray;

            var customDeli = ',';
            var delimiter = numArray[0].Remove(0, 2).Distinct();
            foreach (var deli in delimiter)
            {
                numArray[1] = numArray[1].Replace(deli, customDeli);
            }

            numArray = numArray[1].Split(customDeli);
            return numArray;
        }

        private static void checkNegativeNumbers(string[] numArray)
        {
            if (numArray.Any(x => int.Parse(x) < 0))
                throw new Exception($"{ResourceFile.NegativeValue} {string.Join(" ", numArray.Where(x => int.Parse(x) < 0))}");
        }
    }
}
