using System;
using System.Linq;

namespace HW_09_05_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача №1
            var Number = new Random().Next(10, 100000000).ToString();
            int[] ArrDigits = new int[Number.Length];
            Console.WriteLine(Number);
            for (int i = 0; i < Number.Length; i++)
            {
                ArrDigits[i] = int.Parse((Number.Skip(i).Take(1)).First().ToString());
            }
            foreach (int Digits in ArrDigits.Reverse())
                Console.Write($"{Digits}, ");
            Console.ReadKey();
        }
    }
}
