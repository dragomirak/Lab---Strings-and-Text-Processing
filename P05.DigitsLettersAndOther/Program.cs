﻿using System.Diagnostics;
using System.Text;

namespace P05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digits.Append(input[i]);
                }
                else if (char.IsLetter(input[i])) 
                { 
                    letters.Append(input[i]); 
                }
                else
                {
                    other.Append(input[i]);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);

        }
    }
}