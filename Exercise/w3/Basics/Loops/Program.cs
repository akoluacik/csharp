using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /* FIND SUM AND AVERAGE OF GIVEN 10 NUMBERS */
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
               Console.Write($"Enter the {i + 1}th number: ");
               sum += Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine($"The sum of the 10 number is: {sum}\nThe Average is: {sum / 10.0}");

            /* BUILDING MULTIPLICATION TABLE */
            int number;
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }

            /* MULTIPLICATION TABLE FROM 1 TO 8 */
            Console.WriteLine();
            for (int i = 1; i < 8; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i} X {j} = {i*j} {((j == 10) ? "\n" : ",")}");
                }
            }

            Console.WriteLine();
            /* RIGHT ANGLE PATTERN */
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write($"{j + 1}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            /* RIGHT ANGLE PATTERN */
            Console.Write("Give a number: ");
            number = int.Parse(Console.ReadLine());
            int counter = 1;
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{counter++} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            /* PYRAMID PATTERN */
            Console.Write("Give a number: ");
            number = int.Parse(Console.ReadLine());
            counter = 1;
            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j < number - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{counter++} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            /* SUMMATION OF 9 + 99 + 999 + 9999 + ... */
            sum = 0;
            int addedNumber = 9;
            Console.Write("Give a number: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{addedNumber} ");
                sum += addedNumber;
                addedNumber = addedNumber * 10 + 9;
            }
            Console.WriteLine($"\nThe sum of the series is: {sum}");

            Console.WriteLine();
            /* FLOYD'S TRIANGLE */
            Console.Write("Give a değth for triangle: ");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                number = i % 2 == 0 ? 1 : 0;
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write($"{number}");
                    number = number == 1 ? 0 : 1;
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();
            /* SUM OF x - x^3 + x^5 - x^7 + ... */
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter number of terms: ");
            length = int.Parse(Console.ReadLine());
            double Sum = 0.0;
            int Multiplier = 1;
            for (int i = 1; i < 2 * length + 1; i+= 2)
            {
                Sum = Sum + Multiplier * Math.Pow(2, i);
                Multiplier *= -1;
            }
            Console.WriteLine($"Sum is : {Sum}");

            Console.WriteLine();
            /* CHECK IF A NUMBER IS PERFECT */
            sum = 0;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("The positive divisors are: ");
            for (int i = 1; i <= number / 2; i++)
            {
                if( number % i == 0)
                {
                    Console.Write($"{i} ");
                    sum += i;
                }
            }
            Console.WriteLine($"\nThe number is{(sum == number ? "" : " not")} perfect");

            /* PERFECT NUMBERS WITHIN A GIVEN RANGE */
            Console.Write("Give the starting range or number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Give the ending range or number: ");
            int end = int.Parse(Console.ReadLine());
            Console.Write("The perfect numbers within the given range are: ");
            for (int i = start; i <= end; i++)
            {
                sum = 0;
                for (int j = 1; j <= i / 2; j++)
                {
                    sum = (i % j == 0) ? sum + j : sum + 0;
                }
                if( sum == i)
                {
                    Console.Write(i + " ");
                }
            }

            /* DIAMOND PATTERN */
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = length; i >= 1 ; i--)
            {
                for (int j = 1; j < length - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 2 * i - 1; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            /* Q-36 in w3resources */
            /* Each row starts and ends with 1, the center of a row is the that row number */
            Console.Write("Enter the length of the pyramid: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < 5 - i; j++) // puts whitespace.
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++) // Puts the number till center
                {
                    Console.Write(j);
                }
                for (int j = i - 1; j >= 1; j--) // Fills the remaining columns of current row
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            /* Q-37 in w3resources */
            Console.Write("Enter the length of the pyramid: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write((char)(j + 65) + " ");
                }
                for (int j = i - 1; j >= 0; j--)
                {
                    Console.Write((char)(j + 65) + " ");
                }
                Console.WriteLine();
            }

            /* DECIMAL TO BINARY */
            int multiplicand = 1;
            int bin = 0;
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            for (int i = number; i > 0; i /= 2)
            {
                int rem = i % 2;
                bin = bin + multiplicand * rem;
                Console.WriteLine($"rem : {rem} multiplicand: {multiplicand} multiplicand * bin: {multiplicand * rem} ");
                multiplicand *= 10;
            }
            Console.WriteLine($"The binary of {number} is {bin}");

            /*BINARY TO DECIMAL */
            int digit = 1;
            Console.Write("Enter the binary number: ");
            int dec = 0;
            number = int.Parse(Console.ReadLine());
            for (int i = number; i > 0; i /= 10)
            {
                int rem = i % 10;
                dec = dec + rem * digit;
                digit *= 2;
            }
            Console.WriteLine(dec);
            
            /* BINARY TO DECIMAL USING MATH CLASS */
            Console.Write("Enter a number in base 2:");
            var strNumber = Console.ReadLine();
            number = Convert.ToInt32(strNumber, 2);
            Console.WriteLine($"{strNumber}_2 = {number}_10");
            
            /* DECIMAL TO HEXADECIMAL USING ENUM */
            Console.Write("Enter a number in base 10: ");
            number = Convert.ToInt32(Console.ReadLine());
            string hexNumber = "";
            for (int i = number; i > 0; i /= 16)
            {
                hexNumber = hexNumber + ((i%16 >= 10) ? ((Hex)(i%16)).ToString() : (i%16).ToString());
            }

            char[] numberArray = hexNumber.ToCharArray();
            Array.Reverse(numberArray);
            hexNumber = new string (numberArray);
            Console.WriteLine($"{number} in hex is : {hexNumber}");

            /* EXPRESS A NUMBER AS SUM OF TWO PRIME NUMBERS */
            Console.WriteLine("Give a number: ");
            number = int.Parse(Console.ReadLine());
            bool flag1 = true, flag2 = true;
            for (int i = 3; i <= number / 2; i++)
            {
                flag1 = true; flag2 = true;
                for (int j = 2; j < i; j++)
                {
                    if(i % j == 0) 
                    {
                        flag1 = false;
                        j = i;
                    }
                }
                for (int j = 2; j < number - i; j++)
                {
                    if((number-i) % j == 0)
                    {
                        flag2 = false;
                        j = number - i;
                    }
                }
                if(flag1 && flag2) Console.WriteLine($"{number} + {i} = {number-i}");
            }
            if(!flag1 || !flag2) Console.WriteLine($"{number} cannot be expressed as two prime numbers!");

            



        }
        enum Hex
        {
            A = 10,
            B,
            C,
            D,
            E,
            F
        }
    }
}