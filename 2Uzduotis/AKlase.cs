using MedziagosKartojimas._1Uzduotis;
using System.Collections.Generic;

namespace MedziagosKartojimas._2Uzduotis
{
    public class AKlase : BaseClass
    {
        public AKlase(string name) : base(name)
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
                else
                {
                    newZodis += item;
                }
            }
            return newZodis;
        }
    }
}
