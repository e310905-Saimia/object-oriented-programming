  using System;

  //Seuraavassa m‰‰ritell‰‰n liittym‰ IRobotti.
  public interface IRobotti
  {
    //T‰ss‰ esitell‰‰n liittym‰n metodit.
    void Aloita();
    void Lopeta();

    //T‰ss‰ m‰‰ritell‰‰n ominaisuus RobottiToiminnassa.
    bool RobottiToiminnassa
    {
      get;
    }
  }

  //Seuraavassa m‰‰ritell‰‰n liittym‰ IAlustus.
  public interface IAlustus
  {
    //T‰ss‰ esitell‰‰n liittym‰n metodit
    void AsetaAloitusPiste(int x, int y);
    void AsetaLopetusPiste(int x, int y);
  }

  //Seuraavassa m‰‰ritell‰‰n luokka Matka.
  public class Matka
  {
    //T‰ss‰ esitell‰‰n muuttujat aloitus- ja lopetuspisteen 
    //x ja y koordinaatteja varten. Huomaa, ett‰ niiden 
    //saantim‰‰reeksi on asetettu protected periytymist‰ 
    //varten.
    protected int aloitusPisteX, aloitusPisteY;
    protected int lopetusPisteX, lopetusPisteY;

    //T‰ss‰ m‰‰ritell‰‰n Laskematka()-metodi, joka laskee 
    //matkan aloitus- ja lopetuspisteiden perusteella.
    public double Laskematka()
    {
      //T‰ss‰ lasketaan kahden pisteen v‰linen matka. Matkan 
      //laskemiseksi k‰ytet‰‰n C#:n Math luokan kuuluvia 
      //Sqrt() ja Pow() metodeja. 
      return Math.Sqrt(Math.Pow((lopetusPisteX - 
      aloitusPisteX), 2.0) + Math.Pow((lopetusPisteY -
      aloitusPisteY), 2.0));
     }
  }

  //Seuraavassa m‰‰ritell‰‰n luokka Robotti, joka perii 
  //Matka-luokkaa ja toteuttaa liittym‰t IAlustus ja IRobotti.  
  public class Robotti : Matka, IAlustus, IRobotti 
  {
    //T‰ss‰ m‰‰ritell‰‰n robottiToiminnassa-kentt‰, jota
    //IRobotti-liittym‰n RobottiToiminnassa-property k‰ytt‰‰. 
    private bool robottiToiminnassa = false;

    //Seuraavassa m‰‰ritell‰‰n liittym‰n IAlustus metodit.
    public void AsetaAloitusPiste(int x, int y)
    {
      aloitusPisteX = x;
      aloitusPisteY = y;
    }

    public void AsetaLopetusPiste(int x, int y)
    {
      lopetusPisteX = x;
      lopetusPisteY = y;
    }

    //Seuraavassa m‰‰ritell‰‰n liittym‰n IRobotti metodit.
    //Huomaa, ett‰ metodin s‰‰ntim‰‰reen pit‰‰ olla public! 
    public void Aloita()
    {
      robottiToiminnassa = true;
      Console.WriteLine("Robotti aloittaa pisteest‰ (" + 
      aloitusPisteX + "," + aloitusPisteY + ")");
    }
    
    public void Lopeta()
    {
      robottiToiminnassa = false;
      
      Console.WriteLine("Robotti pys‰htyy pisteeseen: (" + 
      lopetusPisteX + "," + lopetusPisteY + ")");
    }

    //Seuraavassa toteutetaan RobottiToiminnassa property.  
    //Huomaa, ett‰ property:n saantim‰‰reen pit‰‰ olla public!
    public bool RobottiToiminnassa
    {
      get
      {
         return robottiToiminnassa;
      }
    }
  }