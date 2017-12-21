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
        
            account.MakeWithdrawl(1950, DateTime.Now, "Rent Payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(3000, DateTime.Now, "Got Paid");
            Console.WriteLine(account.Balance);

            // Test that initial balance must be positive
            //try {
            //    var invalidAccount = new BankAccount("invalid", -55);
            //} catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            //// Test for a negative balance
            //try {
            //    account.MakeWithdrawl(9000000, DateTime.Now, "Attempt to overdraw");
            //} catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}

            Console.WriteLine(account.GetAccountHistory());
        
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
