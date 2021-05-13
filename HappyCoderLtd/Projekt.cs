using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoderLtd
{
    class Projekt
    {
        public string Naziv { get; set; }
        public int UkupnoVrijeme { get; set; }
        public List<Menadzer> Menadzers { get; set; }

        public Projekt()
        {
            Menadzers = new List<Menadzer>();
        }
    }
}
