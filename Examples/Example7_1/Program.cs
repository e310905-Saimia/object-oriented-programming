using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Example7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Tässä määritellään asiakas1-olio oletusmuodostimella.
            Asiakas asiakas1 = new Asiakas();

            //Tässä tulostetaan asiakas1-olion tiedot kutsumalla 
            //AsiakkaanTiedot-property.
            System.Console.WriteLine("Asiakkaan tiedot: " +
            asiakas1.AsiakkaanTiedot);

            //Tässä tulostetaan tyhjä rivi.
            System.Console.WriteLine();

            //Tässä määritellään asiakas2-olio parametrillisella 
            //muodostimella.
            Asiakas asiakas2 = new Asiakas("Dorothy", 100);

            //Tässä tulostetaan asiakas2-olion tiedot kutsumalla 
            //AsiakkaanTiedot-property.
            System.Console.WriteLine("Asiakkaan tiedot: " +
            asiakas2.AsiakkaanTiedot);

            //Tässä tulostetaan tyhjä rivi.
            System.Console.WriteLine();

            //Tässä määritellään etuasiakas1-olio
            //oletusmuodostimella.
            EtuAsiakas etuAsiakas1 = new EtuAsiakas();


            //Seuraavassa tulostetaan etuAsiakas1-olion tiedot 
            //kutsumalla AsiakkaanTiedot-property. Huomaa, kuinka 
            //AsiakkaanTiedot-property on kopioitunut EtuAsiakas-
            //luokalle.

            System.Console.WriteLine("Etuasiakkaan tiedot: " +
            etuAsiakas1.AsiakkaanTiedot);

            //Tässä tulostetaan etuAsiakas1-olion bonus kutsumalla 
            //LaskeBonus()-metodi.
            System.Console.WriteLine("Etuasiakkaan bonus on: {0, 0:c2}", etuAsiakas1.LaskeBonus());

            //Tässä tulostetaan tyhjä rivi.
            System.Console.WriteLine();

            //Tässä määritellään etuAsiakas2-olio parametrillisella 
            //muodostimella.
            EtuAsiakas etuAsiakas2 = new EtuAsiakas("Alfred", 200,
            1456.40m);

            //Tässä tulostetaan etuAsiakas2-olion tiedot kutsumalla 
            //AsiakkaanTiedot-property.
            System.Console.WriteLine("Etuasiakkaan tiedot: " +
            etuAsiakas2.AsiakkaanTiedot);

            //Tässä tulostetaan etuAsiakas2-olion bonus kutsumalla 
            //LaskeBonus()-metodi.
            System.Console.WriteLine("Etuasiakkaan bonus on: {0, 0:c2}", etuAsiakas2.LaskeBonus());
        }
    }
}
