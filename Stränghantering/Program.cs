using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stränghantering
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Övn 1
            Console.WriteLine("\u0056\u00E4\u0072\u006D\u0064\u00F6\u0020\u0047\u0079\u006D\u006E\u0061\u0073\u0069\u0075\u006D");
            */

            /*
            //Övn 2
            Console.WriteLine("\u0022Hallo World\u0022");
            */

            /*
            //Övn 3a
            string text = "Hallo World";
            text = text.ToUpper();
            Console.WriteLine(text);

            //Övn 3b
            text = text.ToLower();
            Console.WriteLine(text);
            */

            /*
            //Övn 4
            string text = "Hallo World";
            Console.WriteLine("Texten " + text + " innehåller " + text.Length + "st tecken");
            */

            //Övn 5
            Console.Write("Mata in en text: ");
            string inmatat = Console.ReadLine();

            for (int i = inmatat.Length - 1; i >= 0; i--)
            {
     
                Console.WriteLine(inmatat[i]);
            }

        }
    }
}
