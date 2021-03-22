using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcyclone
{
    class Program
    {
        public static void Main(string[] args)
        {
            void div()
            {
                Console.WriteLine("Enter 1st no:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd no:");
                int y = int.Parse(Console.ReadLine());

                int result = x / y;
                Console.WriteLine("Div: " + result);

            }
               
        }
    }
}
