using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class Prijenos : Transakcija
    {
        public int BrojOdredisnogRacuna { get; set; }
        public int BrojPolaznogRacuna { get; set; }

        public override void IzvrsiTransakciju()
        {
            Console.WriteLine("Izvršen je prijenos sa računa broj: "+BrojPolaznogRacuna+" na racun broj "+BrojOdredisnogRacuna+"\n");
        }
    }
}
