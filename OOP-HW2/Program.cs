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
