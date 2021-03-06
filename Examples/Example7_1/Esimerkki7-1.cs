using System;

//Seuraavassa määritellään Asiakas-luokka.
class Asiakas
{
    //Seuraavassa määritellään luokan kentät. Huomaa, että 
    //jäsenten saantimääreet eivät saa olla private jos ne 
    //halutaan perittäviksi! 
    protected string nimi;
    protected int id;

    //Seuraavassa määritellään oletusmuodostin.
    public Asiakas()
    {
        nimi = "Tuntematon";
        id = 0;
    }

    //Seuraavassa määritellään muodostin kaikilla 
    //parametreilla.
    public Asiakas(string nimi, int id)
    {
        this.nimi = nimi;
        this.id = id;
    }

    //Seuraavassa määritellään property-kenttä asiakkaan 
    //tietojen selvittämiseksi. Huomaa, että paluuarvoksi on    
    //asetettu string ja return-lauseen yhteydessä 
    //nimestä, välilyönnistä ja id:stä muodostetaan 
    //palautettava merkkijono.  
    public string AsiakkaanTiedot
    {
        get
        {
            return $"{nimi} {id}"; // nimi + " " + id;
        }
    }
}

//Seuraavassa määritellään EtuAsiakas-luokka, joka perii 
//Asiakas-luokkaa.
class EtuAsiakas : Asiakas
{
    //Seuraavassa määritellään ostot-kenttä EtuAsiakas-
    //luokalle. Huomaa, että periytymisen myötä luokkaan 
    //automaattisesti kopioituu yläluokan kaikki jäsenet, 
    //joiden saantimääreet eivät ole private!
    decimal ostot;

    //Seuraavassa määritellään EtuAsiakas-luokan 
    //oletusmuodostin. Yläluokasta periytyvien attribuuttien
    //alustamiseksi kutsutaan yläluokan vastaava muodostin 
    //base()-määreellä ja paikallinen muuttuja ostot 
    //alustetaan itse.
    public EtuAsiakas() : base()
    {
        //Tässä ostot-kentän oletusarvoksi laitetaan 0.
        ostot = 0m;
    }

    //Seuraavassa määritellään EtuAsiakas-luokan muodostin 
    //kaikilla parametreilla. Luokkien yhteiset kentät 
    //alustetaan kätevästi kutsumalla yläluokan sopiva
    //muodostin base-määreellä ja paikallinen muuttuja ostot 
    //alustetaan itse.
    public EtuAsiakas(string nimi, int id, decimal ostot) :
    base(nimi, id)
    {
        //Tässä alustetaan EtuAsiakas-luokan ostot-kenttä.
        this.ostot = ostot;
    }

    //Seuraavassa määritellään LaskeBonus()-metodi EtuAsiakas-
    //luokalle.
    public decimal LaskeBonus()
    {
        //Seuraavassa lasketaan bonuksen määrä ostojen 
        //perusteella.
        if (ostot >= 500 && ostot < 1000)
            return 0.03m * ostot;
        else if (ostot >= 1000 && ostot < 1500)
            return 0.04m * ostot;
        else if (ostot >= 1500)
            return 0.05m * ostot;
        else
            return 0.0m;
    }
}
