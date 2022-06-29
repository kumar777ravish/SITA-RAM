using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHILEEVENINCREMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 10;
            int x;
            Console.WriteLine("user should print all even numbers between 10 to 50");
            x = Convert.ToInt32(Console.ReadLine());
            while (i <= x)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}


