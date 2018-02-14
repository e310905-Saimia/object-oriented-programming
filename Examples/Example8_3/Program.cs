using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tässä luodaan robotti-olio.
            Robotti robotti = new Robotti();

            //Seuraavassa alustetaan robotti-olio.
            robotti.AsetaAloitusPiste(0, 0);
            robotti.AsetaLopetusPiste(30, 45);

            //Tässä kutsutaan RobottiToiminnassa property
            Console.WriteLine("Robotti on toiminnassa: " +
                              robotti.RobottiToiminnassa);

            robotti.Aloita();

            Console.WriteLine("Robotti on toiminnassa: " +
                              robotti.RobottiToiminnassa);

            robotti.Lopeta();

            Console.WriteLine("Robotti on toiminnassa: " +
                              robotti.RobottiToiminnassa);

            //Tässä kutsutaan Laskematka(), joka on periytynyt 
            //Matka luokasta.
            Console.WriteLine("Robotin kuljettama matka: {0,7:f2} cm ", robotti.Laskematka());
        }
    }
}
