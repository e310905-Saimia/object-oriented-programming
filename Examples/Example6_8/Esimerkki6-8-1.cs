//Seuraavassa on esimerkki6-8-1.cs-tiedoston sisältö.
using System;

class Esimerkki6_8
{
    static void Main(string[] args)
    {
        //Tässä luodaan asiakas-olio, joka on instanssi  
        //Sovellus.Kayttoliittyma.Asiakas-luokasta. Huomaa, 
        //että luokan nimi joudutaan merkitsemään 
        //nimiavaruuksien kautta. 
        
        Sovellus.Kayttoliittyma.Asiakas asiakas = new
        Sovellus.Kayttoliittyma.Asiakas("Sara");

        //Tässä kutsutaan TarkistaAsiakas()-metodi.
        asiakas.TarkistaAsiakas("Susan");

        //Tässä kutsutaan taas TarkistaAsiakas()-metodi uudella 
        //parametrin arvolla.
        asiakas.TarkistaAsiakas("Sara");

        //Tässä luodaan yhteys-olio, joka on instanssi 
        //Sovellus.Tietokantayhteys.AvaaYhteys-luokasta.
        Sovellus.Tietokantayhteys.AvaaYhteys yhteys = new
        Sovellus.Tietokantayhteys.AvaaYhteys();
    }
}
