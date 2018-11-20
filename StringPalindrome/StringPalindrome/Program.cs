using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s; 
     
            Console.WriteLine(" Enter string");
            s = Console.ReadLine();

            if (s[0] == s[s.Length - 1] ||s[0+1]==s[s.Length-2])
                
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }
            Console.ReadKey();

        }
    }
}
