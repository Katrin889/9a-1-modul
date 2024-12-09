using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formuli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете стойности за x и y");
            Console.Write("x=");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            double y = double.Parse(Console.ReadLine());
            var Z =2 * x + 3 * y * y + 4 * x * y + 5 / (20 * x * y * y * y);
            Console.WriteLine("Z=" + Z);
            Console.WriteLine(Math.Round(Z, 4));
            Console.WriteLine(Math.Ceiling(Z));
            Console.WriteLine(Math.Floor(Z));
        }
    }
}
