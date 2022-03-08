using System;

namespace VowelAndConsonantsVerification
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int vowels = 0, consonant = 0;

            Console.Write("Enter your full name: ");
            string name = Console.ReadLine();

            name = name.ToLower();
            name = name.Replace(" ", "");

            for (int i = 0; i < name.Length; i++)
            {

                if ((name[i] == 'a') || (name[i] == 'e') || (name[i] == 'i') || (name[i] == 'o') || (name[i] == 'u'))
                {

                    vowels++;

                }
                else
                {

                    consonant++;

                }
            }

            Console.WriteLine("\nYour name has {0} vowels and {1} consonants", vowels, consonant);

            Console.ReadLine();

        }
    }
}
