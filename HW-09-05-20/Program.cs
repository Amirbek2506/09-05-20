using System;
using System.Linq;

namespace HW_09_05_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача №1
            Console.ForegroundColor = ConsoleColor.Green;Console.WriteLine("\t\tЗадача №1");Console.ResetColor();
            var Number = 987654321.ToString().ToCharArray();
            foreach (var Digits in Number.Reverse())
                Console.Write($"{Digits}, ");
            Console.ReadKey();

            //Задача №2
            Console.ForegroundColor = ConsoleColor.Green;Console.WriteLine("\n\t\tЗадача №2");Console.ResetColor();
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

            //Задача №3
            Console.ForegroundColor = ConsoleColor.Green;Console.WriteLine("\n\t\tЗадача №3");Console.ResetColor();
            string[] NameClubArr = new string[] { "Истиклол", "Худжанд", "Регар-Тадаз", "Равшан", "Хайр", "Сарой-Камар" };
            Console.Write("Arrey(до сортировка):  ");
            foreach (string NameClub in NameClubArr) Console.Write($"{NameClub}, ");
            NameClubArr = NameClubArr.OrderBy(Name=>Name.Length).ToArray();
            Console.Write("\nArrey(после сортировка):  ");
            foreach (string NameClub in NameClubArr) Console.Write($"{NameClub}, ");
            Console.ReadKey();

            //Задача №4
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\n\t\tЗадача №4"); Console.ResetColor();
            int[] NumberArrey = new int[] { 1, 1, 1, 1, -5, 1, 1, 1 };
            Console.Write(" Массив: ");
            foreach (int Num in NumberArrey) Console.Write($"{Num}, ");
            int Max = NumberArrey.Max(); int Min = NumberArrey.Min();
            int UnikalElement= NumberArrey.Single(Numb=>NumberArrey.Count(N=>N==Max)==1 && Numb==Max || NumberArrey.Count(N => N == Min) == 1 && Numb == Min);
            Console.Write($"\n Уникалный елемент массив: {UnikalElement}");
            Console.ReadKey();
        }
    }
}
