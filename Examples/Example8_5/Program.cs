using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tässä luodaan robotti-olio.
            Robotti robotti = new Robotti();

            //Tässä määritellään robotin pyörimiskulma.
            double pyorimisKulma = -Math.PI / 4;

            int aloitusPisteX = 10, aloitusPisteY = 30;
            int lopetusPisteX = 450, lopetusPisteY = 320;

            robotti.Aloita();

            //Tässä kutsutaan IAlustus-liittymän 
            //metodi AsetaAloitusPiste(), joka periytyy 
            //luokkaan Robotti liittymän IRobotti kautta.
            robotti.AsetaAloitusPiste(aloitusPisteX,
                aloitusPisteY);

            //Tässä kutsutaan liittymän IPyori metodi Pyori(),
            //joka periytyy luokkaan Robotti liittymän IRobotti
            //kautta.
            robotti.Pyori(pyorimisKulma);

            //Tässä kutsutaan liittymän IAlustus 
            //metodi AsetaLopetusPiste(), joka periytyy luokkaan 
            //Robotti liittymän IRobotti kautta.
            robotti.AsetaLopetusPiste(lopetusPisteX,
                lopetusPisteY);

            robotti.Lopeta();
        }
    }
}
