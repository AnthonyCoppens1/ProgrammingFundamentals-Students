using System;
using System.Collections.Generic;

namespace _08StoreInventory_DSPS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            string key = Console.ReadLine().ToLower();

            while (key != "x")
            {
                int value = Convert.ToInt32(Console.ReadLine());
                if (!inventory.ContainsKey(key)) //if it doesn't exist in DIC
                {
                    inventory.Add(key, value);
                }
                else
                {
                    inventory[key] = value; //overwrite the value
                }
                key = Console.ReadLine().ToLower();
            }

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine(inventory.ElementAt(i));
            }
        }
    }
}