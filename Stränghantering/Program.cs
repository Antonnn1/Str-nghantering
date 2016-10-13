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

            /*
            //Övn 5
            Console.Write("Mata in en text: ");
            string inmatat = Console.ReadLine();

            for (int i = inmatat.Length - 1; i >= 0; i--)
            {
     
                Console.WriteLine(inmatat[i]);
            }
            */

            /*
            //Övn 6
            string text = "{0} elefant{1} balanserade på en liten liten spindeltråååd.\n" + "Det tyckte {2} var så intressant,\n" + "så {2} gick och hämtade en annan elefant.\n";
            string klartext = string.Format(text, "En", "", "han");
            Console.WriteLine(klartext);

            for (int i = 2; i < 10; i++)
            {
                klartext = string.Format(text, i, "er", "de");
                Console.WriteLine(klartext);
            }
            string sistatext = "{0} elefant{1} balanserade på en liten liten spindeltråååd.\n" + "Det tyckte {2} var så intressant,\n" + "Men nu fanns det inte någon mera elefant";
            klartext = string.Format(sistatext, "10", "er", "de");
            Console.WriteLine(klartext);
            */

            /*
            //Övn 7
            Console.WriteLine("Decimaler:\t3\t2\t1");
            string format = "\t\t{0:0.000}\t{0:0.00}\t{0:0.0}";
            string text = string.Format(format, Math.E);
            Console.WriteLine(text);
            */

            //Övn 8
            Console.WriteLine("Mata in ett ord");
            string inmatat = Console.ReadLine();

            for (int i = 0; i < inmatat.Length; i++)
            {
                if (inmatat[i] != inmatat[inmatat.Length - 1 - i])
                {
                    Console.WriteLine(inmatat + " är inte ett palidrom");
                    break;
                }
                else
                {
                    Console.WriteLine(inmatat + " är ett palidrom");
                    break;
                }
            }

        }
    }
}
