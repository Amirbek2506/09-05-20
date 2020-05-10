using System;
using System.Linq;

namespace HW_09_05_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача №1
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\tЗадача №1");
            Console.ResetColor();
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
            //Задача №2
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\tЗадача №2");
            Console.ResetColor();
            int[] InputArr= new int[] { 1, 2, 3, 4, 5, -1, -2, -3, -14, -5 };
            int[] OutputArr = new int[2];
            OutputArr[0] = InputArr.Where(Num=>Num>0).Count();
            OutputArr[1] = InputArr.Where(Num => Num < 0).Sum();
            //вводим на экран
            Console.Write("InputArrey = ");
            foreach (int Num in InputArr)Console.Write($"{Num}, ");
            Console.Write("\nOutputArrey = ");
            foreach (int Num in OutputArr) Console.Write($"{Num}, ");
            Console.ReadKey();
        }
    }
}
