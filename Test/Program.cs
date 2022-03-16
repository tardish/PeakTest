using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            string[] list = { "dad", "bill", "radar", "motor", "anna", "best" };
            var firstResult = FindPalindrome(list);

            Console.WriteLine("First result");
            foreach(var item in firstResult)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question 2
            var secondResult = FindListFactorial("s");

            Console.WriteLine("\nSecond result");
            foreach (var item in secondResult)
            {
                Console.WriteLine(item);
            }
            #endregion
        }

        public static string[] FindPalindrome(string[] arr)
        {
            List<string> palindrome = new List<string>();
            string[] result;
            foreach (var item in arr)
            {
                if (item == ReverseString(item))
                {
                    palindrome.Add(item);
                }
            }
            result = palindrome.ToArray();
            return result;
        }
        public static string ReverseString(string myStr)
        {
            char[] myArr = myStr.ToCharArray();
            Array.Reverse(myArr);
            return new string(myArr);
        }
        public static List<long> FindListFactorial(string str)
        {
            List<string> alphabetArray = new List<string>() { string.Empty, "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int index = alphabetArray.IndexOf(str.ToUpper());
            List<long> result = new List<long>();
            long sumFact = 0;
            for (var i = 1; i <= index; i++)
            {
                if (i == 1)
                {
                    sumFact = 1;
                    result.Add(1);
                }
                else
                {
                    sumFact = i * sumFact;
                    result.Add(sumFact);
                }
            }
            return result;
        }

    }
}
