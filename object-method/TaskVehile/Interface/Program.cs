using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Nisakas nisse = new Kissa("Kyllä", 20,true, "viirukas", "tuuhea");
            nisse.Syö();
            nisse.OnkoIso();
            
            Console.WriteLine(nisse.ToString()); 

            Elain elain = new Kissa("Kyllä", 15,true,"Musta", "lyhyt");
            
            Console.WriteLine(elain.ToString());

            Kissa vili = new Kissa("Kyllä", 25,false,"vaalea","karvaton");
            
            vili.Kehrää();
            vili.Syö();
            vili.Ääntelee();
            vili.Moikkaa();
            vili.OnkoIso();
            Console.WriteLine(vili.ToString());


        }
    }
}
