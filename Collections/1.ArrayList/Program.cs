using System;
using System.Collections;
namespace _1.ArrayListt
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add(10);
            myList.Add("10");
            myList.Add("abc");
            myList.Add(10.5);

            ArrayList myList2 = new ArrayList(){10, "10", "abc", 10.5};

            //Console.WriteLine(myList[0]);
            int number = (int)myList[0];
            Console.WriteLine("INSERT");
            myList.Insert(1 ,20);

            foreach (var item in myList) // thx to GetEnumerator
            {
                Console.WriteLine(item);
            }
            
            myList.InsertRange(3, myList2); // adds myList2 to myList1 starting from index3.
            foreach (var item in myList) // thx to GetEnumerator
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("REMOVE");
            myList.Remove(10); // removes the first integer 10, not string one.
            myList.RemoveAt(2);
            myList.RemoveRange(0,2); // removes 2 elements starting from 0.
            foreach (var item in myList) // thx to GetEnumerator
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(myList.Contains(10));

            ArrayList numbers = new ArrayList(){10, 5, 4, 60};
            numbers.Sort(); // has to content same types.
            
        
        }
    }
}
