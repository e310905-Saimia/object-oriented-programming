using System;

class Opiskelija
{
    //Seuraavassa esitellään opiskelijan attribuutit.
    public string Nimi;
    private int _id;
    private string puhelin;

    //Tässä määritellään LisaaTiedot()-metodi luokan 
    //kaikilla attribuuteilla.
    public void LisaaTiedot(string nimi, int id,
    string puhelin)
    {
        this.Nimi = nimi;
        this._id = id;
        this.puhelin = puhelin;
    }

    //Seuraavassa LisaaTiedot()-metodi määritellään siten, 
    //että muuttuja puhelin puuttuu parametriluettelosta.    
    public void LisaaTiedot(string nimi, int id)
    {
        this.Nimi = nimi;
        this._id = id;

        //Koska muuttujan puhelin arvoa ei ole tiedossa,
        //se alustetaan omalla oletusarvoilla.
        this.puhelin = "Ei tiedossa!";
    }

    //Seuraavassa LisaaTiedot()-metodi määritellään siten, 
    //että muuttujat puhelin ja id puuttuvat 
    //parametriluettelosta.
    public void LisaaTiedot(string nimi)
    {
        this.Nimi = nimi;

        //Koska muuttujien arvosana, lapaissyt, puhelin 
        //ja id arvot ei ole tiedossa, ne alustetaan 
        //omilla oletusarvoilla.     
        this._id = 0;
        this.puhelin = "Ei tiedossa!";
    }

    //Seuraavassa LisaaTiedot()-metodi määritellään ilman 
    //parametreja.
    public void LisaaTiedot()
    {
        //Seuraavassa kaikki attribuutit alustetaan omilla 
        //oletusarvoilla. 
        this.Nimi = "Ei tiedossa!";
        this._id = 0;
        this.puhelin = "Ei tiedossa!";
    }

    //Tässä määritellään TulostaTiedot()-metodi, joka
    //tulostaa olion tiedot näytölle.
    public void TulostaTiedot()
    {
        Console.WriteLine("Opiskelijan tiedot:");
        Console.WriteLine("Nimi: " + Nimi);
        Console.WriteLine("ID: " + _id);
        Console.WriteLine("Puhelin: " + puhelin);
        Console.WriteLine("----------------");
    }
}

class Esimerkki5_6
{
    static void Main(string[] args)
    {
        //Tässä Opiskelija-luokkaa instansioidaan.
        Opiskelija opiskelija = new Opiskelija();
        
        //Tässä metodi LisaaTiedot() kutsutaan kaikilla 
        //parametreilla.
        opiskelija.LisaaTiedot("Mari Kuri", 1000, "044-12345");

        opiskelija.TulostaTiedot();

        //Tässä LisaaTiedot()-metodi kutsutaan ilman 
        //muuttujaa puhelin.
        opiskelija.LisaaTiedot("Mari Kuri", 1000);

        opiskelija.TulostaTiedot();

        //Tässä  LisaaTiedot()-metodi kutsutaan ilman 
        //muuttuija puhelin ja id.
        opiskelija.LisaaTiedot("Mari Kuri");

        opiskelija.TulostaTiedot();

        //Tässä LisaaTiedot()-metodi kutsutaan ilman parametreja.
        opiskelija.LisaaTiedot();

        opiskelija.TulostaTiedot();
        
    }
}