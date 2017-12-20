using System;
using System.Collections.Generic;

namespace csharp_practice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // WorkingWithStringArrays();
            // FibonacciNumbers();
            var account = new BankAccount("Pierce", 8000000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        }

        public static void FibonacciNumbers()
        {
            List<int> fibonacciNumbers = new List<int> { 1, 1 };


            while (fibonacciNumbers.Count < 20)
            {
                int previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                int previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }  
        }

        public static void WorkingWithStringArrays()
        {
            var names = new List<string> { "Melissa", "Pierce", "Jethro" };
            names.Add("Isaac");
            names.Remove("Jethro");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine("My name is {0}", names[1]);
            Console.WriteLine("I have added {0} and {1} to the list.", names[0], names[2]);
            Console.WriteLine($"The list has {names.Count} people in it");

            int index = names.IndexOf("Pierce");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
			}
        }
    }
}
