using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* USER DEFINED GREETING */
            // UserDefinedGreeting();
            // Console.Write("Enter a name: ");

            /* USER DEFINED GREETING WITH PARAMETER */
            // string name = Console.ReadLine();
            // UserDefinedGreeting(name);

            /* METHODS COUNTS NUMBER OF SPACES IN A STRING */
            // Console.Write("Please enter a string: ");
            // string testStr = Console.ReadLine();
            // Console.WriteLine(SpaceNumber(testStr));

            /* SUM OF ARRAY ELEMENTS */
            // int[] arr = ArrayCreator(10); // helps creating arrays
            // Console.WriteLine($"The sum of the array elements is : {SumofArrayElements(arr)}");

            /* SWAPPING */
            // int number1, number2;
            // Console.Write("Enter the first and second numbers respectively:");
            // number1 = int.Parse(Console.ReadLine()); number2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Before swapping: number1:{0} number2:{1}", number1, number2);
            // Swap(ref number1, ref number2);
            // Console.WriteLine("Before swapping: number1:{0} number2:{1}", number1, number2);

            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine((isPrime(number) ? "" : "Not ") + "Prime");
        }

        /* HELPER FUNCTIONS STARTS */
        static int[] ArrayCreator(int len)
        {
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write($"Enter the {i + 1}th element: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        /* HELPER FUNCTIONS ENDS */

        static void UserDefinedGreeting()
        {
            Console.WriteLine("Hello Friends!");
            Console.WriteLine("Have a nice day!");
        }

        static void UserDefinedGreeting(string name)
        {
            Console.WriteLine("Welcome Friend {0}", name);
            Console.WriteLine($"Have a nice day, {name}");
        }

        static int SpaceNumber(string str)
        {
            int count = 0;
            foreach (var c in str)
            {
                if(c.Equals(' '))
                {
                    ++count;
                }
            }
            return count;
        }
        static int SumofArrayElements(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static bool isPrime(int number)
        {
            if(number == 2) return true;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if(number % i == 0) return false;
            }
            return true;
        }
    }
}
