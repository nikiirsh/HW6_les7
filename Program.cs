using System;
using System.Reflection.Metadata.Ecma335;

namespace HW6_les7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Letters, Symbols, Numbers, Punctuation;
            string str = "My name is Nika and my email is - nk08@gmail.com";
            string str1, str2;

            Console.WriteLine("Input first row:");
            str1 = Console.ReadLine();

            Console.WriteLine("Input second row:");
            str2 = Console.ReadLine();

            Console.WriteLine($"These strings are equal: {Compar(str1, str2)}");

            Console.WriteLine(str);
            Analyze(str, out Letters, out Symbols, out Numbers, out Punctuation);

            Console.WriteLine($"Letterst in alphabetical order 'nskasjsu': {Sorting("nskasjsu")}");

            Console.WriteLine("Array of characters that are duplicated in both of first and second strings:");
            Console.WriteLine(DublicateChar(str1,str2));

        }

        static bool Compar(string str1, string str2)
        {
            if (str1 == null && str2 == null) return true;
            if (str1 == null || str2 == null || str1.Length != str2.Length) return false;
            for (int i = 0; i < str1.Length; i++)
            {

                if (str1[i] != str2[i]) return false;

            }
            return true;
        }

        static void Analyze(string str, out int Letters, out int Symbols, out int Numbers, out int Punctuation)
        {

            Letters = 0;
            Symbols = 0;
            Numbers = 0;
            Punctuation = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                    Letters++;
                else if (Char.IsDigit(str[i]))
                    Numbers++;
                else if (Char.IsSymbol(str[i]))
                    Symbols++;
                else if (Char.IsPunctuation(str[i]))
                    Punctuation++;
            }

            Console.WriteLine($"In this string are {Letters} letters, {Symbols} symbols, {Numbers} numbers and {Punctuation} chars of punctuation");
        }

        static string Sorting(string ForSortSTR)
        {
            
            char[] chars = ForSortSTR.ToArray();
            Array.Sort(chars);
            return new string(chars);
        }

        static char[] DublicateChar(string str1, string str2)
        {
            char[] c1 = str1.ToArray();
            char[] c2 = str2.ToArray();
            char[] same = c1.Intersect(c2).ToArray();
            return same;
        }

    }

}