using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8_2
{
    class Robotti: IAlusta, IMatka, IRobotti
    {
        //Tässä esitellään muuttujat aloitus- ja lopetuspisteen 
        //x ja y koordinaatteja varten.
        private int aloitusPisteX, aloitusPisteY;
        private int lopetusPisteX, lopetusPisteY;

        //Tässä määritellään robottiToiminnassa-kenttä, jota
        //IRobotti-liittymän RobottiToiminnassa-property käyttää. 
        private bool robottiToiminnassa = false;

        //Tässä määritellään matka-kenttä, jota
        //IMatka-liittymän Matka-property käyttää. 
        private double matka = 0.0;

        //Seuraavassa määritellään liittymän IAlustus metodit.
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

        //Seuraavassa määritellään liittymän IRobotti metodit.
        //Huomaa, että metodien saantimääreiden pitää olla public! 
        public void Aloita()
        {
            robottiToiminnassa = true;
            Console.WriteLine("Robotti aloittaa pisteestä (" +
                              aloitusPisteX + "," + aloitusPisteY + ")");
        }

        public void Lopeta()
        {
            robottiToiminnassa = false;

            Console.WriteLine("Robotti pysähtyy pisteeseen: ("
                              + lopetusPisteX + "," + lopetusPisteY + ")");

            //Tässä lasketaan robotin kuljettama matka. Matkan 
            //laskemiseksi käytetään C#:n Math-luokan kuuluvia 
            //Sqrt() ja Pow() metodeja. 
            matka = Math.Sqrt(Math.Pow((lopetusPisteX -
                                        aloitusPisteX), 2.0) + Math.Pow((lopetusPisteY -
                                                                         aloitusPisteY), 2.0));
        }

        //Seuraavassa toteutetaan RobottiToiminnassa-property.  
        //Huomaa, että property:n saantimääreen pitää olla public!
        public bool RobottiToiminnassa
        {
            get
            {
                return robottiToiminnassa;
            }
        }

        //Seuraavassa määritellään IMatka-liittymän Matka 
        //-property.
        public double Matka
        {
            get
            {
                return matka;
            }
        }
    }
}
