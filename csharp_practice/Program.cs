using System;
using System.Collections.Generic;

namespace csharp_practice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var names = new List<string> { "Melissa", "Pierce", "Jethro" };
            names.Add("Isaac");
            names.Remove("Jethro");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
