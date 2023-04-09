using System;
using System.Collections.Generic;

namespace DNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your DNI/NIF number (Without the letter):");
            int number = int.Parse(Console.ReadLine());
            int letra = number / 23;
            Console.WriteLine("Your complete DNI/NIF is: " + number + LetterNIF(number));

        }

        /// <summary>
        /// This 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static char LetterNIF(int number)
        {
            List<char> letras = new List<char>()
            {
               'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' 
            };

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
