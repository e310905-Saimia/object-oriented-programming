using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tässä luodaan auto1-olio oletusmuodostimella.
            
            Auto auto1 = new Auto();
           
            //Tässä kutsutaan staattinen metodi AutojenLukumaara() 
            //suoraan luokan nimen kautta.
            Auto.AutojenLukumaara();

            //Tässä luodaan auto2-olio kaikilla parametreilla.
            Auto auto2 = new Auto("Ford", "Focus", 1999, 1.6m, 5800);

            //Tässä kutsutaan staattinen metodi AutojenLukumaara() 
            //suoraan luokan nimen kautta.
            Auto.AutojenLukumaara();

            //Tässä luodaan auto3-olio kopiointimuodostimella.
            Auto auto3 = new Auto(auto2);

            //Tässä kutsutaan staattinen metodi AutojenLukumaara() 
            //suoraan luokan nimen kautta.
            Auto.AutojenLukumaara();
        }
    }
}
