using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal interface IBankovniRacun
    {
        void IzvrsiUplatu(float i);
        void Nadopuni(float i);
    }
}
