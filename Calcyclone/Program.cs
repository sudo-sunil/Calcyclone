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
            Program p = new Program();
            p.sub();
            p.div();
            p.add();
            p.sumSquare();
            p.cube();
            Console.ReadLine();
        }

        public void sub()
        {
            int x = 20;
            int y = 4;
            int result = x - y;
            Console.WriteLine("Subtraction is : {0}", result);
        }
        public void div()
        {
            Console.WriteLine("Enter 1st no:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no:");
            int y = int.Parse(Console.ReadLine());
            int result = x / y;
            Console.WriteLine("Div: " + result);

        }

        public void add()
        {
            Console.WriteLine("Enter 1st no:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no:");
            int y = int.Parse(Console.ReadLine());
            int result = x + y;
            Console.WriteLine("Add: " + result);
        }

        public void mul()
        {
            Console.WriteLine("Enter 1st no:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no:");
            int y = int.Parse(Console.ReadLine());
            int result = x * y;
            Console.WriteLine("Add: " + result);

        }
        public void sumSquare()
        {
            Console.WriteLine("Enter 1st no:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no:");
            int y = int.Parse(Console.ReadLine());
            int result = (x * x) + (y * y);
            Console.WriteLine("Add: " + result);

        }

        public void cube()
        {
            Console.WriteLine("Enter a number to be cubed:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Cube of the number is : {0}",x*x*x);
        }
    }
}
