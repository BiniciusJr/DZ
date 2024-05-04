using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal abstract class Transakcija : ITransakcija
    {
        public float Iznos { get; set; }

        public abstract void IzvrsiTransakciju();
       
    }
}
