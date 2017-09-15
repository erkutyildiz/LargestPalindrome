using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindrome
{

//A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//Find the largest palindrome made from the product of two 3-digit numbers.
    class Program
    {
        static void Main(string[] args)
        {
            var max = 0;
            for (var i = 999; i > 100; i--)
            {
                for (var j = 999; j > 100; j--)
                {
                    var mul = j * i;
                    if (IsPalin(Convert.ToString(mul)) && mul > max)
                    {
                        max = i * j;
                    }
                }
            }

            Console.WriteLine("Largest Palindrome is : {0} ", max);
            Console.ReadLine();

        }

        public static bool IsPalin(string number)
        {
            char[] reverse = number.ToCharArray();
            Array.Reverse(reverse);
            string palindrome = new string(reverse);

            if (palindrome == number)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
