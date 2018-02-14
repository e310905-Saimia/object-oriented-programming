using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tässä luodaan robotti-olio.
            Robotti robotti = new Robotti();

            //Tässä kutsutaan RobottiToiminnassa-property.
            Console.WriteLine("Robotti toiminnassa: " +
                              robotti.RobottiToiminnassa);

            //Seuraavassa kutsutaan olion metodit.
            robotti.Aloita();

            //Tässä kutsutaan RobottiToiminnassa-property.
            Console.WriteLine("Robotti toiminnassa: " +
                              robotti.RobottiToiminnassa);

            robotti.Lopeta();

            //Tässä kutsutaan RobottiToiminnassa-property.
            Console.WriteLine("Robotti toiminnassa: " +
                              robotti.RobottiToiminnassa);
        }
    }
}
