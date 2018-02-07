using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tässä määritellään hopeaEtuAsiakas-olio.
            HopeaEtuAsiakas hopeaEtuAsiakas = new
                HopeaEtuAsiakas("Emanuel", 2000, 5430.85m);

            //Tässä tulostetaan hopeaEtuAsiakas-olion tiedot.
            hopeaEtuAsiakas.TulostaTiedot();

            //Tässä asiakkaan bonus tulostetaan näytölle.
            Console.WriteLine("HopeaEtuAsiakkaan bonus on: {0,0:c2}", hopeaEtuAsiakas.LaskeBonus());

            //Tässä kutsutaan LaskeKorvaus()-metodi. Huomaa, että 
            //koska se ei sisällä mitään koodia, se ei suorita eikä 
            //tulosta mitään!
            hopeaEtuAsiakas.LaskeKorvaus();
        }
    }
}
