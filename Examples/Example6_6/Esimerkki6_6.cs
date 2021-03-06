  using System;
  
  //Seuraavassa määritellään Firma-luokka.
  public class Firma
  {
    //Seuraavassa määritellään luokan kentät.
    string firmanNimi;
    int liikeVaihto;

    //Seuraavassa määritellään johtaja-kenttä. Huomaa, 
    //että kentän tietotyyppi on Johtaja-luokka!
    Johtaja johtaja;
    
    
    //Seuraavassa määritellään luokan oletusmuodostin.
    public Firma()
    {
      firmanNimi = "Tuntematon"; 
      liikeVaihto = 0;
        
      //Tässä johtaja-olio alustetaan oletusmuodostimella.
      johtaja = new Johtaja();
        
    }

    //Seuraavassa määritellään muodostin kaikilla 
    //parametreilla.
    public Firma(string firmanNimi, int liikeVaihto, Johtaja 
    johtaja)
    {
      this.firmanNimi = firmanNimi;
      this.liikeVaihto = liikeVaihto;

      //Tässä johtaja-kenttä alustetaan parametrina olevalla 
      //johtaja-oliolla.
      this.johtaja = johtaja;
        
    }

    //Seuraavassa määritellään TulostaTiedot()-metodi.
    public void FirmanTiedot()
    {
      Console.WriteLine("-------------");
      Console.WriteLine("Firman nimi: {0}, liikevaihto: {1,0:c2} ", firmanNimi, liikeVaihto);
      
       //Seuraavassa kutsutaan kenttänä olevan johtja-olion 
       //JohtajanTiedot()-metodi, joka tulostaa johtajan 
       //tiedot. 
      johtaja.JohtajanTiedot();
    }

    //Seuraavassa määritellään Johtaja-luokka.
    public class Johtaja
    {
      //Seuraavassa määritellään luokan kentät.
      private readonly string nimi;
      decimal palkka;

        private static int luku;
        //public static string Nimi;

        
      //Seuraavassa määritellään luokan oletusmuodostin.
      public Johtaja()
      {
       Nimi = "Tuntematon";
       palkka = 0.0m;
            Firma xxx = new Firma();
          xxx.firmanNimi = "xxx";
      }

      //Seuraavassa määritellään luokan muodostin kaikilla 
      //parametreilla.
      public Johtaja(string nimi, decimal palkka)
      {
       this.Nimi = nimi;
       this.palkka = palkka;
      }

        public string Nimi
        {
            get { return nimi; }
            //set { nimi = value; }
        }

        //Seuraavassa määritellään luokan TulostaTiedot()-metodi.
      public void JohtajanTiedot()
      {
        Console.WriteLine("Johtaja: " + Nimi + ", palkka: " + palkka + ".");
      }
    } //Johtaja-luokan määrittely loppuu tähän.  
  } //Firma-luokan määrittely loppuu tähän. 