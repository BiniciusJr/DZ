using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class Korisnik : Osoba, IBankovniRacun
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int BrojRacuna { get; set; }
        public float BalansRacuna { get; set; }


        public void IzvrsiUplatu(float iznos)
        {
            Console.WriteLine("Račun "+BrojRacuna+" je izvršio uplatu");
            BalansRacuna -= iznos;
        }
        public void Nadopuni(float iznos)
        {
            Console.WriteLine("Račun "+BrojRacuna+" je nadopunjen iznosom od "+iznos);
            BalansRacuna += iznos;
        }

        public void PrikazBalansa()
        {
            Console.WriteLine("Na računu broj: " + BrojRacuna + " balans je " + BalansRacuna+" eura\n");
        }
        
    }
}
