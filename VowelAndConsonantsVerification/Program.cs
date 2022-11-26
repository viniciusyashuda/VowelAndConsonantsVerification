using System;
using System.Linq;

namespace VowelAndConsonantsVerification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vowels = 0, consonants = 0;
            string name;

            Console.Write("Enter your full name: ");
            name = Console.ReadLine();

            name = name.ToLower();
            name = name.Replace(" ", "");

            vowels = name.Count(
                letter => letter == 'a' || 
                letter == 'e' || 
                letter == 'i' || 
                letter == 'o' || 
                letter == 'u'
            );

            consonants = name.Length - vowels;

            Console.WriteLine("\nYour name has {0} vowels and {1} consonants", vowels, consonants);

            Console.ReadKey();
        }
    }
}
