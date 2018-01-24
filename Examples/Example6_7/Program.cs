using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Example6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tässä luodaan asiakas-olio, joka on instanssi  
            //Sovellus.Kayttoliittyma.Asiakas-luokasta. Huomaa, 
            //että luokan nimi joudutaan merkitsemään 
            //nimiavaruuksien kautta. 

            Sovellus.Kayttoliittyma.Asiakas asiakas = new
                Sovellus.Kayttoliittyma.Asiakas("Sara");

            Console.WriteLine("\nSovellus.Kayttoliittyma.Asiakas.TarkistaAsiakas()-metodin tuloste:");

            //Tässä kutsutaan TarkistaAsiakas()-metodi.
            asiakas.TarkistaAsiakas("Susan");

            Console.WriteLine("\nSovellus.Kayttoliittyma.Asiakas.TarkistaAsiakas()-metodin tuloste:");

            //Tässä kutsutaan taas TarkistaAsiakas()-metodi 
            //uudella parametrin arvolla.
            asiakas.TarkistaAsiakas("Sara");

            Console.WriteLine("\nSovellus.Tietokantayhteys.AvaaYhteys-muodostimen tuloste:");

            //Tässä luodaan yhteys-olio, joka on instanssi 
            //Sovellus.Tietokantayhteys.AvaaYhteys-luokasta.
            Sovellus.Tietokantayhteys.AvaaYhteys yhteys = new
                Sovellus.Tietokantayhteys.AvaaYhteys();
        }
    }
}
