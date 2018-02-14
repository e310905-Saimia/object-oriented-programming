using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8_2
{
    interface IRobotti
    {
        //Tässä esitellään liittymän metodit.
        void Aloita();
        void Lopeta();

        //Tässä esitellään ominaisuus RobottiToiminnassa.
        bool RobottiToiminnassa
        {
            get;
        }
    }
}
