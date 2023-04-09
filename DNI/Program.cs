using System;
using System.Collections.Generic;

namespace DNI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char letraDNI;
            Console.WriteLine("Write your DNI/NIF number (Without the letter):");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Your complete DNI/NIF is: " + number + LetterNIF(letraDNI));
        }

        /// <summary>
        /// This 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static char LetterNIF(char )
        {
            List<char> letras = new List<char>()
            {
               'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' 
            };
            int letra = number / 23;
            for (int i = 0; i <23;i++ )
            {
                if(letra == letras[i])
                {
                    return letras[i];
                }
            }
           
        }
    }
}
