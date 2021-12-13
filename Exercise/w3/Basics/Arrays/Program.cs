using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* STORE 10 NUMBERS IN AN ARRAY AND PRINT THEM */
            int[] arr = new int[10];
            // Console.WriteLine("Input 10 elements in the array");

            // for (int i = 0; i < 10; i++)
            // {
            //     arr[i] = int.Parse(Console.ReadLine());
            // }
            // Console.WriteLine("Elements in the array are: ");
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.Write($"{arr[i]} ");
            // }

            Console.Write("Input the number of elements to store in the array :");
            int len = int.Parse(Console.ReadLine());
            int[] arr2 = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write($"element - {i} : ");
                arr2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nThe values store into the array are: ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine("The values store into the array in reverse are: ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(arr2[len - 1 - i] + " ");
            }

            /* COPY THE ARRAY TO ANOTHER ONE */
            Console.WriteLine();
            int[] arr3 = new int[len];
            // arr3 = (int[])arr2.Clone();
            arr2.CopyTo(arr3, 0);
            for (int i = 0; i < len; i++)
            {
                Console.Write(arr3[i] + " ");
            }

            /* COUNT THE DUPLICATE ELEMENTS */
            
        }
    }
}
