using System;

namespace HappyCoderLtd
{
    class Program
    {
        static void Main(string[] args)
        {
            Projekt projekt = new Projekt();
            projekt.Naziv = "Proba";

            Menadzer menadzer = new Menadzer("Men1","Men1");
            Voditelj voditelj = new Voditelj("Voditelj", "Voditelj");
            Voditelj voditelj2 = new Voditelj("Voditelj", "Voditelj");
            Programer programer = new Programer("Programer", "Programer");
            Programer programer2 = new Programer("Programer", "Programer");
            Programer programer3 = new Programer("Programer", "Programer");

            voditelj.Programeri.Add(programer);
            voditelj.Programeri.Add(programer2);
            voditelj2.Programeri.Add(programer3);
            menadzer.Voditelji.Add(voditelj);
            projekt.Menadzers.Add(menadzer);

            
            foreach (var men in projekt.Menadzers)
            {
                foreach (var vod in men.Voditelji)
                {
                    foreach (var pro in vod.Programeri)
                    {
                       vod.UkupnoVrijeme+=pro.OdradiPosao();
                    }
                }
            }


            foreach (var men in projekt.Menadzers)
            {
                foreach (var vod in men.Voditelji)
                {
                    men.UkupnoVrijeme += vod.UkupnoVrijeme;
                }
            }

            foreach (var men in projekt.Menadzers)
            {
                projekt.UkupnoVrijeme += men.UkupnoVrijeme;
            }

           

            Baza.Projekti.Add(projekt);


            foreach (var item in Baza.Projekti)
            {
                Console.WriteLine($"Projekt:{item.Naziv}");
                Console.WriteLine($"UkupnoVrijeme:{item.UkupnoVrijeme}");
            }


            
        }
    }
}
