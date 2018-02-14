using System;

//Seuraavassa m‰‰ritell‰‰n liittym‰ IRobotti.
public interface IRobotti
{
    //T‰ss‰ esitell‰‰n liittym‰n metodit
    void Aloita();
    void Lopeta();

    //T‰ss‰ esitell‰‰n ominaisuus RobottiToiminnassa.
    bool RobottiToiminnassa
    {
        get;
    }
}

//Seuraavassa m‰‰ritell‰‰n luokka Robotti.
public class Robotti : IRobotti
{
    //T‰ss‰ m‰‰ritell‰‰n robottiToiminnassa-kentt‰, jota
    //liittym‰n RobottiToiminnassa-property k‰ytt‰‰. 
    private bool robottiToiminnassa = false;

    //Seuraavassa toteutetaan liittym‰n Aloita()-metodi.
    //Huomaa, ett‰ metodin saantim‰‰reen pit‰‰ olla public. 
    public void Aloita()
    {
        robottiToiminnassa = true;
        Console.WriteLine("Robotti aloittaa toiminnan...");
    }

    //Seuraavassa toteutetaan liittym‰n Lopeta()-metodi. 
    //Huomaa, ett‰ metodin saantim‰‰reen pit‰‰ olla public! 
    public void Lopeta()
    {
        Console.WriteLine("Robotti lopettaa toiminnan...");
        robottiToiminnassa = false;
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
}
