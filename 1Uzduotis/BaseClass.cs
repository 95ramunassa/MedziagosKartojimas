namespace MedziagosKartojimas._1Uzduotis
{
    public abstract class BaseClass
    {
        public string Name { get; }

        public BaseClass(string name)
        {
            this.Name = name;
        }

        public abstract string NameMetodas();

        public abstract  int NameKodas(int x);
    } 
}
