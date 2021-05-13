using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCoderLtd
{
    class Programer : Zaposlenik
    {
        public Programer(string ime, string prezime)
           : base(ime, prezime)
        {

        }

        public override int OdradiPosao()
        {
            Random random = new Random();
            return random.Next(10);
        }
    }
}
