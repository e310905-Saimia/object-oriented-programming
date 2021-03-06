using System;
using System.Runtime.InteropServices;

namespace Example6_1
{
    class Auto
    {
        //Seuraavassa esitellään luokan kentät. Saantimääreiden 
        //puuttuessa kaikkien kenttien saantimääreet ovat 
        //oletusarvoisesti private. 
        string merkki;

        string tyyppi;
        int vuosiMalli;
        decimal moottorinKoko;
        int hinta;

        //Tässä määritellään staattinen muuttuja autoLaskuri, 
        //joka on tyyppiä int.
        static int autoLaskuri = 0;

        //Seuraavassa määritellään luokalle oletusmuodostin ja 
        //kentät alustetaan oletusarvoilla. 
        public Auto()
        {
            this.merkki = "Toyota";
            this.tyyppi = "RAV4";
            this.vuosiMalli = 2008;
            this.moottorinKoko = 1.9m;
            this.hinta = 35000;

            //Tässä muuttujan autoLaskuri arvoa korotetaan yhdellä. 
            autoLaskuri++;
        }

        //Seuraavassa määritellään muodostin kaikilla 
        //parametreilla.
        public Auto(string merkki, string tyyppi, int vuosiMalli,
            decimal moottorinKoko, int hinta)
        {
            this.merkki = merkki;
            this.tyyppi = tyyppi;
            this.vuosiMalli = vuosiMalli;
            this.moottorinKoko = moottorinKoko;
            this.hinta = hinta;

            //Tässä muuttujan autoLaskuri arvoa korotetaan yhdellä. 
            autoLaskuri++;
        }


        //Seuraavassa määritellään kopiointimuodostin, joka saa 
        //parametrina Auto-olion. Muodostimessa tehdään niin, että 
        //moottorinKoko-kentän arvoa 0.3:lla ja hinta-kentän arvoa 
        //5000:lla lisätään. Muiden kenttien arvot kopioidaan
        //suoraan.

        public Auto(Auto auto)
        {
            this.merkki = auto.merkki;
            this.tyyppi = auto.tyyppi;
            this.vuosiMalli = auto.vuosiMalli;

            //Seuraavassa lisätään moottorin kokoa 0.3:lla ja hintaa 
            //5000:lla. 
            this.moottorinKoko = auto.moottorinKoko + 0.3m;
            this.hinta = auto.hinta + 5000;

            //Tässä muuttujan autoLaskuri arvoa korotetaan yhdellä. 
            autoLaskuri++;
        }


        //Seuraavassa määritellään staattinen metodi 
        //AutojenLukumaara(), joka tulostaa olioiden lukumäärän 
        //näytölle. Muista, että staattinen metodi pystyy 
        //käsittelemään vain staattisia kenttiä.

        public static void AutojenLukumaara()
        {
            Console.WriteLine("Varastossa olevien autojen lukumäärä: " + autoLaskuri);
        }

        //Seuraavassa määritellään luokalle hajotin.
        ~Auto()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Poistetaan " + autoLaskuri + ". auto ...");
            Console.WriteLine("Nyt poistetaan: " + merkki + " "
                              + tyyppi + " " + vuosiMalli + " " + moottorinKoko + " " +
                              hinta);

            //Tässä ennen poistumista hajottimesta autojen lukumäärää 
            //lasketaan yhdellä. 
            autoLaskuri--;
        }
    }
}
