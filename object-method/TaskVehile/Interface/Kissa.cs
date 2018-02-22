using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public class Kissa : Nisakas, ITervehtiva
    {
        private string _väri;
        private string _häntä;


        // Konstruktori
        public Kissa(string elossa, double paino, bool turkillinen, string väri, string häntä) : base(elossa, paino, turkillinen)
        {
            _väri = väri;
            _häntä = häntä;
        }

        public Kissa(string elossa, double paino, bool turkillinen) : base(elossa, paino, turkillinen)
        {
        }


        // Aksessorit
        public string Väri
        {
            get { return _väri; }
            set { _väri = value; }
        }

        public string Häntä
        {
            get { return _häntä; }
            set { _häntä = value; }
        }

        // Metodit
        public void Ääntelee()
        {
            Console.WriteLine("Miau, miau ...");
        }

        public void Kehrää()
        {
            Console.WriteLine("Murr, murr....");
        }

        // Korvatut metodit
        public override void Syö()
        {
            Console.WriteLine("Syön kuin kissa ...");
            Kehrää();
        }

        public override bool OnkoIso()
        {
            return Paino > 10;
        }

        // 
        public void Moikkaa()
        {
            Console.WriteLine("Miu! Pusken jalkaa...");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"Väri: {Väri}\n" +
                   $"Häntä: {Häntä}\n" +
                   $"xxxxxxxxxxxxxxxxxx\n";
        }
    }
}