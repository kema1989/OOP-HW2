using System;
using System.Collections.Generic;

namespace OOP_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Helicopter helicopter = new Helicopter();
            //Console.WriteLine(FindVariant("Абдрашид"));
            try
            {
                Helicopter.Greetings();
                Console.WriteLine("Купить вертолет: новый - 1, б/у - 2, суперстарый - 3");
                
                switch (Console.ReadLine())
                {
                    case "1":
                        Helicopter heli1 = new Helicopter(OOP_HW2.Type.New);
                        heli1.Start();
                        break;
                    case "2":
                        Helicopter heli2 = new Helicopter(OOP_HW2.Type.Used);
                        heli2.Start();
                        break;
                    case "3":
                        Helicopter heli3 = new Helicopter(OOP_HW2.Type.New);
                        heli3.Start();
                        break;
                    default:
                        Console.WriteLine("Вы нормально даже не смогли сделать выбор...(((");
                        break;
                }
                
            }
            catch(Exception)
            {

            }
        }

        public static int FindVariant(string line)
        {
            var dictionary = new Dictionary<char, int>();
            foreach (var letter in line)
            {
                if (dictionary.ContainsKey(letter))
                {
                    dictionary[letter] = dictionary[letter] + 1;
                }
                else
                {
                    dictionary.Add(letter, 1);
                }
            }
            double number = 0;
            foreach (var letter in dictionary)
            {
                number += Math.Pow((int)letter.Key, letter.Value);
            }

            return (int)number % 8;
        }
    }
}
