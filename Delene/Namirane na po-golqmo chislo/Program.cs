using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namirane_na_po_golqmo_chislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи едно цяла число ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Въведи второ цяло число ");
            int b = int.Parse(Console.ReadLine());
            if (a >= b) 
            { 
                Console.WriteLine("По-голянато число е " + a);
                Console.WriteLine("А по-малкото число е " + b);
            }
            else 
            {
                Console.WriteLine("По - голянато число е " + b);
                Console.WriteLine("А по-малкото число е " + a);
            }
        }
    }
}
