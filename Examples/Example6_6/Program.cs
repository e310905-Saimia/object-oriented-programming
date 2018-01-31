using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tässä määritellään jokuJohtaja-olio.
            Firma.Johtaja jokuJohtaja = new Firma.Johtaja("Johnny Logan", 100000.0m);

            //Tässä määritellään ekaFirma-olio.
            Firma ekaFirma = new Firma("Soft Intelligenece",
                10000000, jokuJohtaja);

            //Tässä kutsutaan ekaFirma-olion FirmanTiedot()-metodi.
            ekaFirma.FirmanTiedot();

            //Tässä määritellään tokaFirma-olio. Huomaa, kuinka 
            //lennossa luodaan uusi Johtaja-olio oletusmuodostimella 
            //seuraavalla lauseella: new Firma.Johtaja().

            Firma tokaFirma = new Firma("Easy Money", 500000, new
                Firma.Johtaja());

            //Tässä kutsutaan tokaFirma-olion FirmanTiedot()-metodi.
            tokaFirma.FirmanTiedot();

            //Tässä määritellään kolmasFirma-olio 
            //oletusmuodostimella.
            Firma kolmasFirma = new Firma();

            //Tässä kutsutaan kolmasFirma-olion FirmanTiedot()-
            //metodi.
            kolmasFirma.FirmanTiedot();
        }
    }
}
