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
        public static long uitput;
        public static long lngTest;
        public static long lngWortel;
        public static bool prime = true;
        public static int n;
        static void Main(string[] args)
        {
            //lngTest is het getal dat zal worden getest of het priem is.
            lngTest = 1;
            do
            {
                lngTest++;
                lngWortel = Convert.ToInt64((Math.Round(Math.Sqrt(Convert.ToDouble(lngTest)))+1));
                for (int c = 2; c < lngWortel; c++)
                {
                    uitput = lngTest % c;
                    if (uitput == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime == true)
                {
                    n = n + 1;
                    Console.WriteLine("{0} : {1} is priem.", n, lngTest);
                }
                prime = true;
            } while (true);
        }  
    }
}