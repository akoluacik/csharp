using System;
using System.Linq;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* STORE 10 NUMBERS IN AN ARRAY AND PRINT THEM */
            // int[] arr = new int[10];
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

            // Console.Write("Input the number of elements to store in the array :");
            // int len = int.Parse(Console.ReadLine());
            // int[] arr2 = new int[len];
            // for (int i = 0; i < len; i++)
            // {
            //     Console.Write($"element - {i} : ");
            //     arr2[i] = int.Parse(Console.ReadLine());
            // }
            // Console.WriteLine("\nThe values store into the array are: ");
            // for (int i = 0; i < len; i++)
            // {
            //     Console.Write(arr2[i] + " ");
            // }
            // Console.WriteLine("The values store into the array in reverse are: ");
            // for (int i = 0; i < len; i++)
            // {
            //     Console.Write(arr2[len - 1 - i] + " ");
            // }

            /* COPY THE ARRAY TO ANOTHER ONE */
            // Console.WriteLine();
            // int[] arr3 = new int[len];
            // arr3 = (int[])arr2.Clone();
            // arr2.CopyTo(arr3, 0);
            // for (int i = 0; i < len; i++)
            // {
            //     Console.Write(arr3[i] + " ");
            // }

            /* COUNT THE DUPLICATE ELEMENTS */
            // int cnt = 0, dupCounter = 0;
            // int[] arr4 = new int[10] {1, 1, 2, 7, 4, 4, 4, 2, 7, 2};
            // for (int i = 0; i < arr4.Length; i++)
            // {
            //     for (int j = 0; j < arr4.Length; j++)
            //     {
            //         if(arr4[i] == arr4[j])
            //         {
            //             if (i > j) break; else ++cnt;
                        // if i > j, break because we've already counted it.
            //         }
            //     }
            //     if(cnt == 2) ++dupCounter; // if that number appears twice, it is duplicate.
            //     cnt = 0;
            // }
            // Console.WriteLine($"Total number of duplicate elements found in the array is : {dupCounter}");

            /* MERGE TWO ARRAYS IN ASCENDING ORDER */
            // int[] arr5 = {0, 1, 2};
            // int[] arr6 = {0, 1, 2};
            // int[] combined = arr5.Concat(arr6).ToArray();
            // int temp;
            // for (int i = 0; i < combined.Length - 1; i++)
            // {
            //     for (int j = i + 1; j < combined.Length; j++)
            //     {
            //         if(combined[i] > combined[j])
            //         {
            //             temp = combined[i];
            //             combined[i] = combined[j];
            //             combined[j] = temp;
            //         }
            //     }
            // }
            // for (int i = 0; i < combined.Length; i++)
            // {
            //     Console.Write($"{combined[i]} ");
            // }

            /* REMOVE DUPLICATES IN AN OBJECT LIST */
            object[] list = new Object[8] {25, "Anna", false, 25, System.DateTime.Now, 112.22, "Anna", false};
            int length = list.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    Console.Write($"list[{j}]={list[j]} ");
                    if(list[i].Equals(list[j]))
                    {
                        Console.Write($" --> list[{j}]={list[j]} ");
                        for (int k = j; k < length - 1; k++)
                        {
                            list[k] = list[k + 1];
                        }
                        --length;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(length);
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{list[i]} ");
            }
        }
    }
}
