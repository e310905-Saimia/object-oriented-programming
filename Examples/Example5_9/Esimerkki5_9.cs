  using System;

  class Polkkupyora
  {
    //Seuraavsaa esitellään luokan attribuutit.
    string merkki;
    int koko;
    float hinta;

    //Seuraavsaa määrietllään muodostin kaikilla parametreilla.
    public Polkkupyora(string merkki, int koko, float hinta)
    {
      this.merkki = merkki;
      this.koko = koko;
      this.hinta = hinta;
    }

    //Seuraavsaa määrietllään oletusmuodotin.
    public Polkkupyora()
    {
      this.merkki = "Ei ole tiedossa!";
      this.koko = 0;
      this.hinta = 0.0f;
    }

    //Seuraavsaa määritellään hajotin.
    ~Polkkupyora()
    {
      Console.WriteLine("Seuraava polkkupyörä merkitään valmiiksi tuhottavaksi: ");
      Console.WriteLine("Polkupyörän merkki: " + merkki);
      Console.WriteLine("Polkupyörän koko: " + koko);
      Console.WriteLine("Polkupyörän hinta {0, 0:f2}: ", 
      hinta);
      Console.WriteLine("--------------------");
    }
  }
  
  class Esimerkki5_9
  {
    static void Main()
    {
      //Tässä luodaan polkkupyora1-olio kaikilla parametreilla.
      Polkkupyora polkkupyora1 = new Polkkupyora("Crescent", 
      26, 399.50f);
        
        Polkkupyora pp = new Polkkupyora();
      //Tässä luodaan polkkupyora2-olio oletusparametreilla.
      Polkkupyora polkkupyora2 = new Polkkupyora();
      
      //Huomaa, että tässä ei tarvita kutsua hajotinta koska 
      //se kutsutaan automaattisesti ennen kuin poistutaan 
      //Main()-metodista.
    }
  }