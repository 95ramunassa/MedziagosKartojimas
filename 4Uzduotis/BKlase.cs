using MedziagosKartojimas._1Uzduotis;
using MedziagosKartojimas._3Uzduotis;
using System;
using System.Collections.Generic;

namespace MedziagosKartojimas._4Uzduotis
{
    public class BKlase : BaseClass, ZodisKitaip
    { 
        public BKlase(string name) : base(name)
        {
                
        }
        public override int NameKodas(int x)
        {
            int vardas = 0;
            foreach (var item in Name)
            {
                vardas += (int)item * item;
            }
            return vardas;
        }

        public override string NameMetodas()
        {
            throw new NotImplementedException();
        }

        public string ZodisBeBalsiu()
        {
            string newZodis = "";

            List<char> balsiai = new List<char> {
                'a',
                'e',
                'i',
                'o',
                'u' };

            foreach (var item in Name)
            {
                if (!balsiai.Contains(item))
                {
                    newZodis += (int)item;
                }
            }
            return newZodis;
        }

        public string ZodisBePriebalsiu()
        {
            string newZodis = "";

            List<char> balsiai = new List<char> {
                'a',
                'e',
                'i',
                'o',
                'u' };

            foreach (var item in Name)
            {
                if (balsiai.Contains(item))
                {
                    newZodis += (int)item;
                }
            }
            return newZodis;
        }

        public string ZodisSuPakeistomisBalsemis(char a)
        {
            string newZodis = "";

            List<char> balsiai = new List<char> {
                'a',
                'e',
                'i',
                'o',
                'u' };

            foreach (var item in Name)
            {
                if (balsiai.Contains(item))
                {
                    newZodis += a;
                }
                else
                {
                    newZodis += item;
                }
            }
            return newZodis;
        }

        public string ZodisSuPakeistomisPriebalsemis(int x)
        {
            string newZodis = "";
            List<char> balsiai = new List<char> {
                'a',
                'e',
                'i',
                'o',
                'u' };

            foreach (var item in Name)
            {
                if (balsiai.Contains(item))
                {
                    newZodis += x.ToString();
                }
                else
                {
                    newZodis += item;
                }
            }
            return newZodis;
        }
    }
}
