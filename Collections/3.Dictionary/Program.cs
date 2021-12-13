using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> plates = new Dictionary<int, string>();
            plates.Add(34 , "İstanbul");
            plates.Add(35, "İzmir");
            plates.Add(45, "Manisa");

            Dictionary<int, string> numbers = new Dictionary<int, string>()
            {
                {1, "One"},
                {2, "Two"},
                {3, "Three"}
            };
            Console.WriteLine("With foreach\n");
            foreach (var item in plates)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.WriteLine();
            /*foreach (KeyValuePair<int, string> item in plates)
            {
                Console.WriteLine($"{item.Key} {item.Value}")
            }*/
            Console.WriteLine("\nWith for\n");
            for (int i = 0; i < plates.Count; i++)
            {
                Console.WriteLine($"{plates.Keys.ElementAt(i)} {plates[plates.Keys.ElementAt(i)]}");
            }
            Console.WriteLine("\nContainsKey&Contains");
            Console.WriteLine(plates.ContainsKey(34));
            Console.WriteLine(plates.ContainsKey(44));
            Console.WriteLine(plates.Contains(new KeyValuePair<int,string>(44, "Malatya")));

            /* */
            Hashtable ht = new Hashtable() // takes objects as argument
            {
                {1, "John"},
                {2, "Cathy"},
                {"3", "Max"}
            };
            ht.Add(4, "Nick");
        }
    }
}
