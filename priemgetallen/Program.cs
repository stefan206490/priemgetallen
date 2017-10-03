using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace priemgetallen
{
    /* 
   lucas numbers eerste filter
   1,3,4,7,11,18,29,47
   elk volgende lucas nummer is de som van de twee nummers die er direct voor staan.
   om te controleren of getal 'n' misschien een priemgetal is zoek ik het Lucasnummer
   dat op plaats 'n' in de serie staat. van dit getal haal ik 1 af.
   dan kijk ik of dit getal een veelvoud van 'n' is.
   als dit het geval is heb je te maken met een lucas pseudo prime.
    */
    //mochten de getallen te groot worden dan moet je long i.p.v. int gebruiken.
    class Program
    {
        public static int uitput;
        public static int intMax = 1000;
        public static int intMin = 2;
        public static int intA;
        public static bool prime = true;
        public static int Counter;
        public static int AutoLoad = 1;
        public static int intIn;
        static void Main(string[] args)
        {
            Console.WriteLine("wil je autoload gebruiken?");
            Console.WriteLine("1)ja / 0)nee");
            intIn = Convert.ToInt32(Console.ReadLine());
            if (intIn == 1)
            {
                AutoLoad = 1;
            } else
            {
                AutoLoad = 0;
            }
            Console.WriteLine("Wil je een startpunt instellen?");
            Console.WriteLine("1)ja / 0)nee");
            int Q1 = Convert.ToInt32(Console.ReadLine());
            if (Q1 == 1)
            {
                Console.WriteLine("welk getal heeft je startpunt");
                intMin = Convert.ToInt32(Console.ReadLine());
                intMax = intMin + 1000;
            }
            if (AutoLoad == 0)
            {
                Console.WriteLine("Vanaf welk getal wil je controleren?");
                intMin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Tot welk getal wil je controleren?");
                intMax = Convert.ToInt32(Console.ReadLine());
            }
            //intMum is het getal dat je gaat controleren of het priem is.
            do
            {
                for (intA = intMin; intA <= intMax; intA++)
                {
                    for (int c = 2; c <= (intA - 1); c++)
                    {
                        uitput = intA % c;
                        if (uitput == 0)
                        {
                            prime = false;
                            break;
                        }
                    }
                    if (prime == true)
                    {
                        Counter = Counter + 1;
                        if (Counter == 10000)
                        {
                            Console.Clear();
                        }
                        Console.WriteLine("{0} is een priemgetal.", intA);
                    }
                    prime = true;
                }
                Console.WriteLine("Dit was het laatste priemgetal");
                Console.WriteLine("Volgende serie wordt geladen...");
                intMin = intMax + 1;
                intMax = intMin + 1000;
                Console.WriteLine("Van {0} tot {1} is de volgende serie.", intMin, intMax);
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine("Van {0} tot {1} is de volgende serie.", intMin, intMax);
            } while (AutoLoad == 1);
        }  
    }
}