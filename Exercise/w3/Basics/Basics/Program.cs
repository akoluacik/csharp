using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, John");
            
            // int x = 3, y = 5;
            // Console.WriteLine($"{x} + {y} = {x + y}");

            // x = 7; y = 4;
            // Console.WriteLine("{0} / {1} = {2}", x, y, x/y);

            // /* SWAPPING 2 NUMBERS */
            // int number1, number2, temp;
            // Console.Write("Enter the first number: ");
            // number1 = int.Parse(Console.ReadLine());
            // Console.Write("Enter the first number: ");
            // number2 = int.Parse(Console.ReadLine());

            // temp = number1;
            // number1 = number2;
            // number2 = temp;

            // Console.WriteLine($"number1:{number1}, number2:{number2}");

            // /*4 BASICS MATH OPERATIONS WITH THE 2 NUMBERS ENTERED BY USER*/
            // Console.Write("Enter the first number: ");
            // number1 = int.Parse(Console.ReadLine());
            // Console.Write("Enter the first number: ");
            // number2 = int.Parse(Console.ReadLine());

            // Console.WriteLine($"{number1} + {number2} = {number1+number2}");
            // Console.WriteLine($"{number1} - {number2} = {number1-number2}");
            // Console.WriteLine($"{number1} * {number2} = {number1*number2}");
            // Console.WriteLine($"{number1} / {number2} = {number1/number2}");
            // Console.WriteLine($"mod({number1},{number2}) = {number1%number2}");

            // /* AVERAGE OF FOUR INPUT NUMBERS*/
            // Console.WriteLine("Enter 4 numbers: ");
            // x = int.Parse(Console.ReadLine());
            // y = int.Parse(Console.ReadLine());
            // number1 = int.Parse(Console.ReadLine());
            // number2 = int.Parse(Console.ReadLine());
            // Console.WriteLine($"The average of {x},{y},{number1},{number2} is : {(x+y+number1+number2)/4}");

            // /* CELCIUS TO FAHRENHEIT AND TO KELVIN*/
            // Console.Write("Enter temperature in terms of celcius degree: "); 
            // double temperature = int.Parse(Console.ReadLine());

            // double fahrenheit = (9/5.0) * (temperature + 32);
            // double kelvin = temperature + 273.0;

            // Console.WriteLine($"{temperature} celcius degree is {fahrenheit} fahrenheit degree and {kelvin} kelvin degree");

            // /* REMOVE SPECIFIED CHAR OF A STRING WITH INDEX NUMBER */
            // Console.Write("Give a string: ");
            // string str = Console.ReadLine();
            // Console.Write("Give the index of the char to be removed: ");
            // int idx = int.Parse(Console.ReadLine());
            // str = str.Remove(idx, 1);
            // Console.WriteLine($"After removing, {str}");

            // /* FIRST AND LAST CHARS WILL BE REPLACED */
            // Console.Write("Give a string: ");
            // str = Console.ReadLine();
            // str = str[str.Length - 1] + str.Substring(1, str.Length - 2) + str[0];
            // Console.WriteLine(str);

            // /* 
            // TRUE IF ONE OF THE TWO INPUT NUMBERS ARE POSITIVE AND THE OTHER IS POSITIVE
            // OR VICE-VERSA, OTHERWISE, FALSE
            // */
            // Console.Write("Give a number: ");
            // number1 = Convert.ToInt16(Console.ReadLine());
            // Console.Write("Give a number: ");
            // number2 = Convert.ToInt16(Console.ReadLine());

            // Console.WriteLine((number1*number2 < 0) ? "True" : "False");
            // // Console.WriteLine((number1 < 0 && number2 > 0) || (number1 < 0 && number2 > 0));

            // /* RETURN DOBULE THE ABS. VALUE IF THE FIRST VALUE IS GREATER THAN THE SECOND */
            // Console.Write("Give a number: ");
            // number1 = Convert.ToInt16(Console.ReadLine());
            // Console.Write("Give a number: ");
            // number2 = Convert.ToInt16(Console.ReadLine());
            // int difference = (number1 > number2) ? 2*(Math.Abs(number1 - number2)) : Math.Abs(number1 - number2);
            // Console.WriteLine($"The abs. difference is: {difference}");

            // /* RETURN true IF ONE OF THE INPUT NUMBER OR SUM OF THE TWO INPUT NUMBERS IS 20*/
            // Console.Write("Give a number: ");
            // number1 = Convert.ToInt16(Console.ReadLine());
            // Console.Write("Give a number: ");
            // number2 = Convert.ToInt16(Console.ReadLine());
            // Console.WriteLine((number1 + number2 == 20) || number2 == 20 || number1 == 20);

            // /* CREATING A STRING FROM AN INPUT STRING, IF LENGTH OF THE STRING IS LESS THAN 3, THEN PRINT THE ORIGINAL ONE */
            // Console.Write("Give a string: ");
            // str = Console.ReadLine();
            // Console.WriteLine(str.Substring(str.Length - 4, 4) + str.Substring(str.Length - 4, 4) + str.Substring(str.Length - 4, 4) + str.Substring(str.Length - 4, 4));

            // Console.Write("Give a string: ");
            // str = Console.ReadLine();

            // Console.WriteLine(((str.IndexOf("HP") == 1) ? "" : "HP") + str.Substring(2));

            // /* CHECK IF A GIVEN STRING STARTS WITH C# */
            // Console.Write("Give a string: ");
            // str = Console.ReadLine();
            // Console.WriteLine(str.ToLower().StartsWith("c#"));

            // /* CHECK WHETHER A TWO INPUT NUMBERS ARE IN THE RANGE BETWEEN 20 AND 50, INCLUSIVE. IF SO, RETURN true. */
            // Console.Write("Enter the first number: ");
            // number1 = Convert.ToInt16(Console.ReadLine());
            // Console.Write("Enter the second number: ");
            // number2 = Convert.ToInt16(Console.ReadLine());
            
            // Console.WriteLine((number1 >= 20 && number1 <= 50) ^ (number2 >= 20 && number2 <= 50));
            
            // Console.Write("Give a string: ");
            // str = Console.ReadLine();
            // str = str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
            // Console.WriteLine(str);
            
            // /* REMOVING THE SPECIFIED CHAR AND PUT IT AT THE BEGINNING AND THE END OF THE STRING */
            // Console.Write("Give a string: ");
            // str = Console.ReadLine();
            // Console.Write("Give the removed char: ");
            // char c = Console.ReadLine()[0];
            // str = str.Replace(c, '\0');
            // str = c + str + c;
            // Console.WriteLine(str);

            /* DISPLAYING THE SPEED IN DIFFERENT CONVENTIONS */
            Console.Write("Give the distane: ");
            int distance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Give time in hours: ");
            int hours = Convert.ToInt16(Console.ReadLine());
            Console.Write("Give time in minutes: ");
            int minutes = Convert.ToInt16(Console.ReadLine());
            Console.Write("Give time in seconds: ");
            int seconds = Convert.ToInt16(Console.ReadLine());

            double time = hours*3600.0 + minutes*60.0 + seconds;
            double mps = distance / time; // meter per second
            double kmph = mps*36.0/10.0; // kilometer per hour and note that 36km/h = 10m/s
            double mileph = kmph * 0.6213711922;

            Console.WriteLine($"Your speed in metres/sec is : {mps}");
            Console.WriteLine($"Your speed in km/hour is : {kmph}");
            Console.WriteLine($"Your speed in mile/hour is : {mileph}");

        }
    }
}
