using System;
using System.Transactions;

namespace UsingOperators // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 90;
            int bonusHealth = 10;
            Console.WriteLine($"You have {health} heath.");
            health += bonusHealth;
            Console.WriteLine($"You now have {health} health (+{bonusHealth}).");
            Console.ReadKey(true);
        }
    }
}