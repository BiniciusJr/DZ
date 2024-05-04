using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class Banka
    {
        public string Ime { get; set; }
        public List<Korisnik> korisnici;
        public List<Transakcija> transakcijas;

        public Banka()
        {
            korisnici = new List<Korisnik>();
            transakcijas = new List<Transakcija>();
        }

        public void Add(Korisnik korisnik)
        {
            korisnici.Add(korisnik);
        }

        public void Remove(Korisnik korisnik)
        {
            korisnici.Remove(korisnik);
        }

        public void Plati(Transakcija transakcija)
        {
            transakcija.IzvrsiTransakciju();
            transakcijas.Add(transakcija);
        }
    }
}
