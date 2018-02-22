using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public abstract class Nisakas : Elain
    {
        private bool _turkillinen;

        protected bool Turkillinen
        {
            get { return _turkillinen; }
            set { _turkillinen = value; }
        }


        //Toteutetut metodit
        public override void Syö()
        {
            Console.WriteLine("Syön kuin nisäkäs...");
        }

        public override bool OnkoIso()
        {
            return false;
        }

        protected Nisakas(string elossa, double paino, bool turkillinen) : base(elossa, paino)
        {
            Elossa = elossa;
            Paino = paino;
            Turkillinen = turkillinen;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" + 
                   $"Turkillinen: {Turkillinen}\n" +
                   $"==================";
        }
    }
}