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
            p.add(45.6f, 54.7f);

            Console.ReadLine();

        }
        public void add(float x, float y)
        {
            Console.WriteLine("Addition is : "+(x+y));
        }
    }
}
