using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasLatter("kenan",'0'));
            Console.ReadLine();
        }
        static bool HasLatter(string text,char letter)
        {
            for (int i = 0; i <text.Length; i++)
            {
                if (text[i] == letter)
                {
                    return true;
                }
            }
            return false;

        } 
    }
}
