using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public abstract class Elain
    {
        private string _elossa;
        private double _paino;

        protected Elain(string elossa, double paino)
        {
            Elossa = elossa;
            Paino = paino;
        }

        protected string Elossa
        {
            get { return _elossa; }
            set { _elossa = value; }
        }

        protected double Paino
        {
            get { return _paino; }
            set { _paino = value; }
        }

        public abstract void Syö();

        public abstract bool OnkoIso();

        public override string ToString()
        {
            return $"Elossa: {Elossa}\n" +
                   $"Paino: {Paino}\n" +
                   $"---------------\n";
        }
    }
}