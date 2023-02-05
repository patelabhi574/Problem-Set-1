using System;
using System.Linq;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q2 a)
            string str1 = "Supercalifragilisticexpialidocious";
            Console.WriteLine(str1.Length);

            // Q2 b)
            string str2 = "ice";
            Console.WriteLine(str1.Contains(str2));

            // Q2 c)
            string s1 = "Supercalifragilisticexpialidocious";
            string s2 = "Honorificabilitudinitatibus";
            string s3 = "Bababadalgharaghtakamminarronnkonn";

            Console.WriteLine("The longest string is: ");
            if (s1.Length >= s2.Length && s2.Length >= s3.Length)
            {
                Console.WriteLine(s1);
            }
            else if (s2.Length >= s1.Length && s2.Length >= s3.Length)
            {
                Console.WriteLine(s2);
            }
            else
            {
                Console.WriteLine(s3);
            }

            // Q2 d)
             string[] words = {"Berlioz", "Borodin", "Brian", 
            "Bartok", "Bellini", "Buxtehude", "Bernstein"};

            Array.Sort(words);

            Console.WriteLine(words[0]);
        }
    }
}