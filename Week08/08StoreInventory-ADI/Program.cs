using System;
using System.Collections.Generic;

namespace _08StoreInventory_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            string key = Console.ReadLine().ToLower();
            
            while(key != "x")
            {
                int value = Convert.ToInt32(Console.ReadLine());
                if (!inventory.ContainsKey(key)) //als het product nog niet in de dictionary zit
                {
                    inventory.Add(key, value);
                }
                else
                {
                    inventory[key] = value; //overwrite quantity
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