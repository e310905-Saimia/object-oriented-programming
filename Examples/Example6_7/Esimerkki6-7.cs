  using System;

  //Seuraavassa määritellään Sovellus-nimiavaruus.
  namespace Sovellus
  {
    //Seuraavassa määritellään Sovellus.Kayttoliittyma-
    //nimiavaruus.
    namespace Kayttoliittyma
    {
      //Seuraavassa määritellään 
      //Sovellus.Kayttoliittyma.Asiakas-luokka.
      class Asiakas
      {
        string nimi;
        
        //Seuraavassa määritellään Asiakas -luokan muuodostin.
        public Asiakas(string nimi)
        {
          this.nimi = nimi;
        }

        //Seuraavassa määritellään TarkistaAsiakas()-metodi, 
        //jolla asiakkaan nimeä verrataan parametrina olevaan 
        //nimeen ja sen perusteella ilmoitetaan onko asiakkaan 
        //nimi oikein vai ei.
        public void TarkistaAsiakas(string nimi)
        {
          //Tässä verrataan nimi-kentän ja nimi-parametrin 
          //arvoja sisäänrakennetulla Equals()-metodilla.
          if(this.nimi.Equals(nimi))
            Console.WriteLine(nimi + " on asiakkaan oikea nimi.");
          else
            Console.WriteLine(nimi + " ei ole asiakkaan oikea nimi!");
        }
      } // Sovellus.Kayttoliittyma.Asiakas-luokka loppuu tähän.
    } // Sovellus.Kayttoliittyma-nimiavaruus loppuu tähän.
  } //Sovellus-nimiavaruus loppuu tähän.
      
  //Seuraavassa määritellään Sovellus.Tietokantayhteys-
  //nimiavaruus.
  namespace Sovellus.Tietokantayhteys
  {
    //Seuraavassa määritellään 
    //Sovellus.Tietokantayhteys.AvaaYhteys-
    //luokka.
    class AvaaYhteys
    {
      public AvaaYhteys()
      {
        Console.WriteLine("Tietokantayhteys on avattu!");
      }
    } // Sovellus.Tietokantayhteys.AvaaYhteys-luokka loppuu 
     //tähän.
  } //Sovellus.Tietokantayhteys-nimiavaruus loppuu tähän.
  
  class Esimerkki6_7
  {
    static void Main(string[] args)
    {
      
    }
  }
