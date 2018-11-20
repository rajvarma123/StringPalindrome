using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
   public class Program
    {
        public void palindrome()
        {
            Console.WriteLine("the string is palindrome");
        }
        public void invalid()
        {
            Console.WriteLine("the string is not palindrome");
        }
        static void Main(string[] args)
        {
            string s;
           Console.WriteLine(" Enter string");
            s = Console.ReadLine();
            Program program = new Program();
            int i = s.Length;
            int j = 0;
            while (i > 0)
            {
                    if (s[j++] == s[i- 1])
                    {
                        i--;
                    }
                    else
                    {
                        program.invalid();
                        break;
                    }

            }
            program.palindrome();

            Console.ReadKey();
        }
    }
}