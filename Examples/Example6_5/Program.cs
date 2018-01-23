using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JohtajaFirma;


namespace Example6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tässä määritellään jokuJohtaja-olio.
            Johtaja jokuJohtaja = new Johtaja("Johnny Logan",
                100000.0m);

            //Tässä määritellään ekaFirma-olio.
            Firma ekaFirma = new Firma("Soft Intelligenece",
                10000000, jokuJohtaja);

            //Tässä kutsutaan ekaFirma-olion FirmanTiedot()-metodi.
            ekaFirma.FirmanTiedot();


            //Tässä määritellään tokaFirma-olio. Huomaa, kuinka 
            //lennossa luodaan uusi Johtaja-olio oletusmuodostimella 
            //seuraavalla lauseella: new Johtaja().

            Firma tokaFirma = new Firma("Easy Money", 500000, new
                Johtaja());

            //Tässä kutsutaan tokaFirma-olion FirmanTiedot()-metodi.
            tokaFirma.FirmanTiedot();
        }
    }
}
