using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banka banka1 = new Banka();
            
            Korisnik korisnik1 = new Korisnik();
            korisnik1.Ime = "Domagoj";
            korisnik1.Prezime = "Vranješ";
            korisnik1.Adresa = "Nova Dalmacija 6, Josipovac";
            korisnik1.OIB = 123456789;
            korisnik1.BrojRacuna = 123321;
            korisnik1.BalansRacuna = 50;

            Korisnik korisnik2 = new Korisnik();
            korisnik2.Ime = "Patrik";
            korisnik2.Prezime = "Vranješ";
            korisnik2.Adresa = "Nova Dalmacija 6, Višnjevac";
            korisnik2.OIB = 109876543;
            korisnik2.BrojRacuna = 987789;
            korisnik2.BalansRacuna = 25;

            banka1.Add(korisnik2);
            banka1.Add(korisnik1);

            korisnik1.PrikazBalansa();
            korisnik2.PrikazBalansa();
            

            Prijenos prijenos1 = new Prijenos();
            prijenos1.Iznos = 5;
            prijenos1.BrojPolaznogRacuna = korisnik1.BrojRacuna;
            prijenos1.BrojOdredisnogRacuna = korisnik2.BrojRacuna;

            banka1.Plati(prijenos1);

            korisnik1.BalansRacuna -= prijenos1.Iznos;
            korisnik2.BalansRacuna += prijenos1.Iznos;


            korisnik1.PrikazBalansa();
            korisnik2.PrikazBalansa();
            Console.ReadKey();
        }
    }
}
