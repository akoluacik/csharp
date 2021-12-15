using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Length of a string */
            // Console.Write("Enter a string: ");
            // string str;
            // str = Console.ReadLine();
            // Console.WriteLine(Len(str));

            // /* String comparing */
            // Console.Write("Enter the first string: ");
            // string str1 = Console.ReadLine();
            // Console.Write("Enter the second string: ");
            // string str2 = Console.ReadLine();
            // Console.WriteLine((isEqual(str1, str2) ? "" : "Not ") + "Equal");

            // /* Number of digits, letters and special chars. */
            // Console.Write("Enter the string: ");
            // str = Console.ReadLine();
            // Console.WriteLine($"Number of letters is: {numberOfLetters(str)}");
            // Console.WriteLine($"Number of digits is: {numberOfDigits(str)}");
            // Console.WriteLine($"Number of special chars is: {numberOfSpecials(str)}");
            
            string[] strArray = new string[3];
            for (int i = 0; i < 3; i++)
            {
                strArray[i] = Console.ReadLine();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(strArray[i] + " ");
            }
        }

        /* FIND THE LENGTH OF STR */
        static int Len(string str)
        {
            int len = 0;
            foreach (var c in str)
            {
                ++len;
            }
            return len;
        }

        /* EQUALITY CHECK METHOD */
        static bool isEqual(string str1, string str2)
        {
            if(Len(str1) != Len(str2)) return false;
            for (int i = 0; i < Len(str1); i++)
            {
                if(str1[i] != str2[i])
                    return false;
            }
            return true;
        }
        /* Number of Letters, digits and special chars calculators */
        static int numberOfLetters(string str)
        {
            
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if((str[i] >= 65 && str[i] <= 90) || (str[i] >= 95 && str[i] <= 122))
                    ++count;
            }
            return count;
        }

        static int numberOfDigits(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if((str[i] >= 48 && str[i] <= 57))
                    ++count;
            }
            return count;
        }
        
        static int numberOfSpecials(string str)
        {
            return (Len(str) - (numberOfDigits(str) + numberOfLetters(str)));
        }
        /* Number of Letters, digits and special chars calculators */

        static int VowelCount(string str)
        {
            char[] Vowels = new char[]{'a', 'e', 'i', 'o', 'u'};
            int count = 0;
            foreach (var ch in str)
            {
                for (int i = 0; i < Vowels.Length; i++)
                {
                    if(ch == Vowels[i])
                        ++count;
                }
            }
            return count;
        }
    }
}
