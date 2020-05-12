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
            foreach (var Digits in 987654321.ToString().ToCharArray().Reverse()) Console.Write($"{Digits}, ");
            Console.ReadKey();

            //Задача №2
            Console.ForegroundColor = ConsoleColor.Green;Console.WriteLine("\n\t\tЗадача №2");Console.ResetColor();
            int[] InputArr= new int[] { 1, 2, 3, 4, 5, -1, -2, -3, -14, -5 };
            int[] OutputArr = new int[2];
            OutputArr[0] = InputArr.Where(Num=>Num>0).Count();OutputArr[1] = InputArr.Where(Num => Num < 0).Sum();
            Console.Write("InputArrey = ");foreach (int Num in InputArr)Console.Write($"{Num}, ");
            Console.Write("\nOutputArrey = ");foreach (int Num in OutputArr) Console.Write($"{Num}, ");
            Console.ReadKey();
           
            //Задача №3
            Console.ForegroundColor = ConsoleColor.Green;Console.WriteLine("\n\t\tЗадача №3");Console.ResetColor();
            string[] NameClubArr = new string[] { "Истиклол", "Худжанд", "Регар-Тадаз", "Равшан", "Хайр", "Сарой-Камар" };
            Console.Write("Arrey(до сортировка):  ");
            foreach (string NameClub in NameClubArr) Console.Write($"{NameClub}, ");
            Console.Write("\nArrey(после сортировка):  ");
            foreach (string NameClub in NameClubArr.OrderBy(Name => Name.Length).ToArray()) Console.Write($"{NameClub}, ");
            Console.ReadKey();
            
            //Задача №4
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\n\t\tЗадача №4"); Console.ResetColor();
            int[] NumberArrey = new int[] { 1, 1, 1, 1, -5, 1, 1, 1 };
            Console.Write(" Массив: ");
            foreach (int Num in NumberArrey) Console.Write($"{Num}, ");
            Console.Write($"\n Уникалный елемент массив: {NumberArrey.Single(Numb => NumberArrey.Count(N => N == NumberArrey.Max()) == 1 && Numb == NumberArrey.Max() || NumberArrey.Count(N => N == NumberArrey.Min()) == 1 && Numb == NumberArrey.Min())}");
            Console.ReadKey();
        }
    }
}
