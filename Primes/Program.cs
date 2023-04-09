using System;

namespace Primes
{
    public class Program
    {
        static void Main(string[] args)
        {
            float num;
            string response;
            Console.WriteLine("Enter a number: ");
            response = Console.ReadLine();
            num = int.Parse(response);
            if (IsPrime(num))
            {
                Console.WriteLine(num + ": is prime");
            }
            else
            {
                Console.WriteLine(num + ": is not prime");
            }
        }
        public static bool IsPrime(float number)
        {
            if(number <= 1)
                return false;
            if (number == 2)
                return true;
            for(int i = 2; i < number / 2; i++){
                if (number % i == 0)
                {
                    return false;
                }
                    
            }
            //TODO
            return true;
        }
    }
}
