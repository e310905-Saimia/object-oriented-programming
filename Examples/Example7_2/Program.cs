using System;


namespace Example7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Tässä määritellään asiakas-olio.
            Asiakas asiakas = new Asiakas("Amanda", 1000);

            //Tässä tulostetaan asiakkaan tiedot kutsumalla 
            //TulostaTiedot()-metodi.
            asiakas.TulostaTiedot();

            //Tässä määritellään hopeaEtuAsiakas-olio.
            HopeaEtuAsiakas hopeaEtuAsiakas = new
                HopeaEtuAsiakas("Emanuel", 2000, 5430.85m);

            //Tässä tulostetaan hopeaEtuAsiakas-olion tiedot.
            hopeaEtuAsiakas.TulostaTiedot();

            //Tässä määritellään kultaEtuAsiakas-olio.
            KultaEtuAsiakas kultaEtuAsiakas = new
                KultaEtuAsiakas("Emiliano", 3000, 15430.85m);

            //Tässä tulostetaan kultaEtuAsiakas-olion tiedot.
            kultaEtuAsiakas.TulostaTiedot();
        }
    }
}
