using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsPoligoniAnrangoRamosGionsi
{
    internal class clsEnnagono:clsPoligonoRegolare
    {
        private double apotema;
        public string Apotema
        {
            get=>apotema.ToString();
            set
            {
                if (!double.TryParse(value, out apotema) || apotema <= 0) throw new Exception("L'apotema deve essere un numero decimale maggiore di 0");
            }
        }
        //COSTRUTTORE
        public clsEnnagono(string lun,string n,string a) : base(lun, n)
        {
            Apotema = a;
            Dati = "Poligono = Ennagono" + Dati + "\nArea = " + Area() + "\nApotema = " + Apotema;
        }

        //PUBBLICI
        public override string Area()
        {
            double area;
            area = Perimetro() * apotema / 2;
            return area.ToString();
        }
        public void AssegnaApotema(string lun)
        {
            Apotema = lun;
        }
        public string LeggiApotema()
        {
            return Apotema;
        }
    }
}
