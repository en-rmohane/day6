using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class perfectnumber
    {
        
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPerfectNumber(number))
            {
                Console.WriteLine(number + " is a perfect number.");
            }
            else
            {
                Console.WriteLine(number + " is not a perfect number.");
            }
        }

        static bool IsPerfectNumber(int number)
        {
            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum == number;
        }
    }

}

