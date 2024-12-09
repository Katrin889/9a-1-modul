using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Klukarka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете 1 буква от име ");
            var a = Console.ReadLine();
            switch (a)
            {
                case "Р": Console.WriteLine("Вечно блее в час"); break;
                case "Х": Console.WriteLine("Клюкарка"); break;
                case "М":
                case "С":
                case "Н":
                case "К":
                case "Ю":
                case "х": Console.WriteLine("Само те слушат"); break;
                default: Console.WriteLine("Няма други"); break;
            }
        }
    }
}
