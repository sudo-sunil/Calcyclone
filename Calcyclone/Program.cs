using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcyclone
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.sub();
            Console.ReadLine();
        }
        
        public void sub()
        {
            int x = 20;
            int y = 4;
            int result = x - y;
            Console.WriteLine("Subtraction is : {0}", result);
        }
    }
}
