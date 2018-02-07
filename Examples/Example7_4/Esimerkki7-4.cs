  using System;
  
  //Seuraavassa määritellään Asiakas-abstraktiluokka.
  abstract class Asiakas
  {
    //Seuraavassa määritellään luokan kentät. 
    protected string nimi;
    protected int id;
    
    //Seuraavassa määritellään oletusmuodostin.
    public Asiakas()
    {
      nimi = "Tuntematon asiakas";
      id = 0;
    }
  
    //Seuraavassa määritellään muodostin kaikilla 
    //attribuuteilla.
    public Asiakas(string nimi, int id)
    {
      this.nimi = nimi;
      this.id = id;
    }
    
    //Seuraavassa esitellään LaskeBonus()-abstraktimetodi. 
    //Huomaa, että abstraktimetodin esittely loppuu 
    //puolipisteeseen.
    abstract public decimal LaskeBonus();
  
    //Seuraavassa esitellään LaskeKorvaus()-abstraktimetodi.
    public abstract void LaskeKorvaus();
  }
  
  //Seuraavassa määritellään HopeaEtuAsiakas-luokka, 
  //joka perii Asiakas-abstraktiluokkaa.
  class HopeaEtuAsiakas : Asiakas
  {
    //Tässä esitellään HopeaEtuAsiakas-luokan ostot-kenttä. 
    decimal ostot;
  
    //Tässä määritellään oletusmuodostin. 
    public HopeaEtuAsiakas(): base()
    {
      ostot=0m;
    }
  
    //Tässä määritellään muodostin kaikilla attribuuteilla. 
    public HopeaEtuAsiakas(string nimi, int id, decimal ostot)
    : base(nimi, id)
    {
      //Tässä alustetaan ostot-kenttä.
      this.ostot = ostot;
    }
    
    //Seuraavassa ylikirjoitetaan LaskeBonus()-
    //abstraktimetodi, joka periytyy Asiakas-luokasta. Huomaa,  
    //että abstraktimetodin ylikirjoittaminen aliluokassa on 
    //pakollinen.
    public override decimal LaskeBonus()
    {
      return 0.1m * ostot;
    }
  
    //Seuraavassa ylikirjoitetaan LaskeKorvaus()-
    //abstraktimetodi. Huomaa, että tässä suoritetaan 
    //tyhjä ylikirjoitus. Kääntäjälle riittä jos metodille
    //laitetaan {}-merkkiyhdistelmä.
    public override void LaskeKorvaus() {}
  
    //Seuraavassa määritellään HopeaEtuAsiakas-luokalle
    //oma TulostaTiedot()-metodi.
    public void TulostaTiedot()
    {
      Console.WriteLine("HopeaEtuAsiakkaan tiedot: " + 
      nimi + " " + id + " Ostot={0,0:c2}", ostot);
    }
  }
  
  class Esimerkki7_4
  {
    static void Main(string[] args)
    {
      //Tässä määritellään hopeaEtuAsiakas-olio.
      HopeaEtuAsiakas hopeaEtuAsiakas = new 
      HopeaEtuAsiakas("Emanuel", 2000, 5430.85m);
  
      //Tässä tulostetaan hopeaEtuAsiakas-olion tiedot.
      hopeaEtuAsiakas.TulostaTiedot();
  
      //Tässä asiakkaan bonus tulostetaan näytölle.
      Console.WriteLine("HopeaEtuAsiakkaan bonus on: {0,0:c2}", hopeaEtuAsiakas.LaskeBonus());
      
      //Tässä kutsutaan LaskeKorvaus()-metodi. Huomaa, että 
      //koska se ei sisällä mitään koodia, se ei suorita eikä 
      //tulosta mitään!
      hopeaEtuAsiakas.LaskeKorvaus();
    }
  }