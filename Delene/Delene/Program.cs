using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи едно цяла число");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0) 
            {
                Console.WriteLine("Числото е четно и то е " + a);
            }
            else
            {
                Console.WriteLine("Числото е нечетно, защото е " + a);
            }
        }
    }
}
