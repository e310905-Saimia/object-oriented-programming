using System;

class Asiakas
{
    //Seuraavassa määritellään luokan kentät.
    protected string nimi;
    protected int id;

    //Seuraavassa määritellään oletusmuodostin.
    public Asiakas()
    {
        nimi = "Tuntematon";
        id = 0;
    }

    //Seuraavassa määritellään muodostin kaikilla 
    //attribuuteilla.
    public Asiakas(string nimi, int id)
    {
        this.nimi = nimi;
        this.id = id;
    }

    //Seuraavassa määritellään LaskeBonus()-metodi. Huomaa, 
    //kuinka metodia merkitään valmiiksi ylikirjoitettavaksi 
    //virtual-määreellä.
    public virtual decimal LaskeBonus()
    {
        //Asiakas ei saa bonusta koska se ei ole etuasiakas!
        return 0.0m;
    }

    //Seuraavassa määritellään TulostaTiedot()-metodi, jota 
    //myös merkitään valmiiksi ylikirjoitettavaksi virtual-
    //määreellä.
    public virtual void TulostaTiedot()
    {
        Console.WriteLine($"Asiakkaan tiedot: {nimi} {id}");
    }
}

//Seuraavassa määritellään HopeaEtuAsiakas-luokka, joka perii 
//Asiakas-luokkaa.
class HopeaEtuAsiakas : Asiakas
{
    //Seuraavassa määritellään ostot-kenttä 
    //HopeaEtuAsiakas-luokalle.
    decimal ostot;

    //Seuraavassa määritellään HopeaEtuAsiakas-luokan 
    //oletusmuodostin. Huomaa, etää base-määreellä kentät 
    //alustetaan niin kuin yliluokan oletusmuodostimessa 
    //määrätty. 
    public HopeaEtuAsiakas()
        : base()
    {
        ostot = 0m;
    }

    //Seuraavassa määritellään HopeaEtuAsiakas-luokan 
    //muodostin kaikilla attribuuteilla. Huomaa, että base-
    //määreellä osa parametreista alustetaan yliluokan 
    //muodostimella.
    public HopeaEtuAsiakas(string nimi, int id, decimal ostot)
        : base(nimi, id)
    {
        //Tässä alustetaan HopeaEtuAsiakas-luokan ostot-kenttä.
        this.ostot = ostot;
    }

    //Seuraavassa ylikirjoitetaan LaskeBonus()-metodi, joka 
    //periytyy Asiakas-luokasta.
    public override decimal LaskeBonus()
    {
        //Seuraavassa lasketaan bonuksen määrä, joka on 10% 
        //ostojen määrästä.
        return 0.1m * ostot;
    }

    //Seuraavassa ylikirjoitetaan TulostaTiedot()-metodi,
    //joka periytyy Asiakas-luokasta.
    public override void TulostaTiedot()
    {
        Console.WriteLine($"HopeaEtuAsiakkaan tiedot: {nimi} {id} Ostot={ostot:c2}");
    }
}

//Seuraavassa määritellään KultaEtuAsiakas-luokka, joka 
//perii Asiakas-luokkaa.
class KultaEtuAsiakas : Asiakas
{
    //Seuraavassa määritellään ostot- ja korvaus-kentät 
    //KultaEtuAsiakas-luokalle. 
    decimal ostot;
    decimal korvaus;

    //Seuraavassa määritellään KultaEtuAsiakas-luokan 
    //oletusmuodostin. 
    public KultaEtuAsiakas()
        : base()
    {
        ostot = 0m;
        korvaus = 0m;
    }

    //Seuraavassa määritellään KultaEtuAsiakas-luokan 
    //muodostin kaikilla attribuuteilla. 
    public KultaEtuAsiakas(string nimi, int id, decimal ostot)
        : base(nimi, id)
    {
        //Seuraavassa alustetaan KultaEtuAsiakas-luokan 
        //ostot- ja korvaus-kentät.
        this.ostot = ostot;
        this.korvaus = 0.02m * ostot;
    }

    //Seuraavassa ylikirjoitetaan LaskeBonus()-metodi, joka 
    //periytyy Asiakas-luokasta.
    public override decimal LaskeBonus()
    {
        //Seuraavassa lasketaan bonuksen määrä, joka on 15% 
        //ostojen määrästä.
        return 0.15m * ostot;
    }

    //Seuraavassa ylikirjoitetaan TulostaTiedot()-metodi, joka 
    //periytyy Asiakas-luokasta.
    public override void TulostaTiedot()
    {
        Console.WriteLine($"KultaEtuAsiakkaan tiedot: {nimi} {id} " +
                          $"Ostot={ostot:c2} " +
                          $"Korvaus={korvaus:c2}");
    }
}