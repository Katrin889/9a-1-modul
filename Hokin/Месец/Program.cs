using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Месец
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи мессец ");
            var a = Console.ReadLine();
            var b = int.Parse(Console.ReadLine());
            switch (a)
            {
                case "2":
                case "1":
                case "12": Console.WriteLine("zima"); break;
               // case "3":
               //     if (b < 29) { Console.WriteLine("Високосна година"); }
                case "4":
                case "5": Console.WriteLine("Пролет"); break;
                case "6":
                case "7":
                case "8": Console.WriteLine("Лято"); break;
                case "9":
                case "10":
                case "11": Console.WriteLine("Есен"); break;
                default: Console.WriteLine("Ne e mesec"); break;
            }
        }
    }
}
