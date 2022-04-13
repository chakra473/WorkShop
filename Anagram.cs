using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShop
{
    internal class Anagram
    {
        public void anagramCheck()
        {
            Console.WriteLine("enter the string 1");
            string string1=Console.ReadLine();
            Console.WriteLine("enter the string 2");
            string string2=Console.ReadLine();
            char[] ch1=string1.ToLower().ToCharArray();
            char[] ch2=string2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string res1=new string(ch1);
            string res2=new string(ch2);
            if(res1==res2)
            {
                Console.WriteLine("both the strings are ANAGRAM");
            }
            else
            {
                Console.WriteLine("both the strings are not ANAGRAM");
            }
        }
    }
}
