using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i + " Bud ( for multiples of three)");

                if (i % 5 == 0)
                    Console.WriteLine(i + " Soft ( for the multiples of five)");

                if(i % 3 == 0 && i % 5 == 0)
                        Console.WriteLine(i + " BudSoft ( for numbers which are multiples of both three and five)");
            }

            Console.ReadKey();


        }
    }
}
