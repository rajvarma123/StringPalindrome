using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
  
    public class Program
    { 
        static void Main(string[] args)
        {
            string s;
           Console.WriteLine(" Enter string");
            s = Console.ReadLine();
            if(isPalindrome(s))
            {
                Console.WriteLine("Given string is palindrome");
            } else
            {
                Console.WriteLine("Given string is not palindrome");

            }
            Console.ReadLine();
        }

        public static bool isPalindrome(string input)
        {
            for (int i = 0; i < input.Length/2; i++)
            {
                if(input[i] != input[input.Length-1 -i])
                {
                    return false;
                }
            }
            return true;
        }
    }


}