  using System;

  //Seuraavassa m‰‰ritell‰‰n liittym‰ IRobotti.
  public interface IRobotti
  {
    //T‰ss‰ esitell‰‰n liittym‰n metodit.
    void Aloita();
    void Lopeta();

    //T‰ss‰ esitell‰‰n ominaisuus RobottiToiminnassa.
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

  //Seuraavassa m‰‰ritell‰‰n liittym‰ IMatka.
  public interface IMatka
  {
    //T‰ss‰ esitell‰‰n liittym‰n Matka-property.
    double Matka
    {
      get;
    }
  }

  //Seuraavassa m‰‰ritell‰‰n luokka Robotti.
  public class Robotti : IAlustus, IRobotti, IMatka
  {
    //T‰ss‰ esitell‰‰n muuttujat aloitus- ja lopetuspisteen 
    //x ja y koordinaatteja varten.
    private int aloitusPisteX, aloitusPisteY;
    private int lopetusPisteX, lopetusPisteY;

    //T‰ss‰ m‰‰ritell‰‰n robottiToiminnassa-kentt‰, jota
    //IRobotti-liittym‰n RobottiToiminnassa-property k‰ytt‰‰. 
    private bool robottiToiminnassa = false;

    //T‰ss‰ m‰‰ritell‰‰n matka-kentt‰, jota
    //IMatka-liittym‰n Matka-property k‰ytt‰‰. 
    private double matka = 0.0;

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
    //Huomaa, ett‰ metodien saantim‰‰reiden pit‰‰ olla public! 
    public void Aloita()
    {
     robottiToiminnassa = true;
     Console.WriteLine("Robotti aloittaa pisteest‰ (" + 
     aloitusPisteX + "," + aloitusPisteY + ")");
    }
    
    public void Lopeta()
    {
     robottiToiminnassa = false;

     Console.WriteLine("Robotti pys‰htyy pisteeseen: (" 
     + lopetusPisteX + "," + lopetusPisteY + ")");
  
     //T‰ss‰ lasketaan robotin kuljettama matka. Matkan 
     //laskemiseksi k‰ytet‰‰n C#:n Math-luokan kuuluvia 
     //Sqrt() ja Pow() metodeja. 
     matka = Math.Sqrt(Math.Pow((lopetusPisteX - 
     aloitusPisteX), 2.0) + Math.Pow((lopetusPisteY - 
     aloitusPisteY), 2.0));
    }
  
    //Seuraavassa toteutetaan RobottiToiminnassa-property.  
    //Huomaa, ett‰ property:n saantim‰‰reen pit‰‰ olla public!
    public bool RobottiToiminnassa
    {
     get
     {
       return robottiToiminnassa;
     }
    }
  
    //Seuraavassa m‰‰ritell‰‰n IMatka-liittym‰n Matka 
    //-property.
    public double Matka
    {
     get
     {
       return matka;
     }
    }
  }
