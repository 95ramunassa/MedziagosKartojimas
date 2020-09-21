using MedziagosKartojimas._2Uzduotis;
using MedziagosKartojimas._4Uzduotis;

namespace MedziagosKartojimas._5Uzduotis
{
    public class CKlase : BKlase
    {
        public int Number { get; set; }
        public string Word { get; set; }
        public double DoubleNumber { get; set; }
        public AKlase AClassObject{ get; set; }


        public CKlase(string name) : base(name)
        {

        }

        public CKlase(string name, int number) : base(name)
        {
            Number = number;
        }

        public CKlase(string name, int number, string word) : base(name)
        {
            Number = number;
            Word = word;
        }

        public CKlase(string name, int number, string word, double doubleNumber, AKlase aClassObject) : base(name)
        {
            Number = number;
            Word = word;
            DoubleNumber = doubleNumber;
            AClassObject = aClassObject;
        }
    }
}
