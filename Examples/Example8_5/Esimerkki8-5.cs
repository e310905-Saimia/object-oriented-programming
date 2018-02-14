using System;

//Seuraavassa m‰‰ritell‰‰n liittym‰ IAlustus.
public interface IAlustus
{
    //T‰ss‰ esitell‰‰n liittym‰n metodit.
    void AsetaAloitusPiste(int x, int y);
    void AsetaLopetusPiste(int x, int y);
}

//Seuraavassa m‰‰ritell‰‰n liittym‰ IPyori.
public interface IPyori
{
    void Pyori(double kulma);
}

//Seuraavassa m‰‰ritell‰‰n liittym‰ IRobotti, 
//joka perii liittym‰t IAlustus ja IPyori.
public interface IRobotti : IAlustus, IPyori
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

//Seuraavassa m‰‰ritell‰‰n luokka Robotti, joka perii 
//liittym‰n IRobotti. Huomaa, ett‰ koska IRobotti perii
//liittym‰n IPyori, luokan Robotti tulee toteuttaa myˆs
//liittym‰n IPyori metodit.   
public class Robotti : IRobotti
{
    //T‰ss‰ m‰‰ritell‰‰n kentt‰ robottiToiminnassa, jota
    //IRobotti-liittym‰n RobottiToiminnassa-property k‰ytt‰‰. 
    private bool robottiToiminnassa = false;

    //Seuraavassa m‰‰ritell‰‰n metodit AsetaAloitusPiste ja 
    //AsetaLopetusPiste, jotka ovat periytyneet 
    //liittym‰st‰ IAlustus.
    public void AsetaAloitusPiste(int x, int y)
    {
        Console.WriteLine("Aloituspiste on ({0},{1})", x, y);
    }

    public void AsetaLopetusPiste(int x, int y)
    {
        Console.WriteLine("Lopetuspiste on ({0},{1})", x, y);
    }

    //Seuraavassa toteutetaan metodi Pyori(), joka on 
    //peiytynyt liittym‰st‰ IPyori.    
    public void Pyori(double kulma)
    {
        //T‰ss‰ radiaanikulma muunnteaan asteeksi.
        double aste = (kulma / Math.PI) * 180;
        if (aste < 0)
            //Seuraavassa Math.Abs(aste) palauttaa luvun aste 
            //absoluuttisen arvon. 
            Console.WriteLine("Robotti pyorii " +
            Math.Abs(aste) + " astetta myˆt‰p‰iv‰‰n...");
        else if (aste == 0)
            Console.WriteLine("Robotin pyorimiskulma on " + aste
            + " astetta!");
        else
            Console.WriteLine("Robotti pyorii " + aste
            + " astetta vastap‰iv‰‰n...");
    }

    //Seuraavassa toteutetaan liittym‰n IRobotti metodit.
    public void Aloita()
    {
        robottiToiminnassa = true;
        Console.WriteLine("Robotti aloittaa toiminnan...");
    }

    public void Lopeta()
    {
        robottiToiminnassa = false;
        Console.WriteLine("Robotti lopettaa toiminnan...");
    }

    //Seuraavassa toteutetaan ominaisuus RobottiToiminnassa.
    public bool RobottiToiminnassa
    {
        get
        {
            return robottiToiminnassa;
        }
    }
}

