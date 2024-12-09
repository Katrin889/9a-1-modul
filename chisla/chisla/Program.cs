using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*   *     *    *********** *    *");
            Console.WriteLine("*  *     * *        *      *   **");
            Console.WriteLine("**      *****       *      *  * *");
            Console.WriteLine("*  *   *     *      *      * *  *");
            Console.WriteLine("*   * *       *     *      **   *");

            Console.Write("Kak se kazvah?");
            string name = Console.ReadLine();
            Console.WriteLine($"sdravej, {name}!");
            Console.Write("Kak e imeto na nomer 17?");
            string name1 = Console.ReadLine();
            Console.WriteLine($"Moje bi, {name1} shte se opita da zavyrshi");
        }
    }
}
