using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи едно цяла число");
            var a = Console.ReadLine();
            if (a == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wellcom");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }
    }
}
