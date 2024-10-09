using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsPoligoniAnrangoRamosGionsi
{
    internal class clsTriangolo:clsPoligonoRegolare
    {
        private double altezza;
        public string Altezza
        {
            get=>altezza.ToString();
            set
            {
                if (!double.TryParse(value, out altezza) || altezza <= 0) throw new Exception("L'altezza deve essere un numero decimale positivo");

            }
        }

        //COSTRUTTORE
        public clsTriangolo(string lun, string n,string h):base(lun,n)
        {
            Altezza = h;
            Dati = "Poligono = Triangolo" + Dati + "\nArea = " + Area() + "\nTriangolo= " + Altezza;

        }
        //METODI PUBBLICI

        public void AssegnaAltezza(string h)
        {
            Altezza = h;
        }
        public string LeggiAltezza()
        {
            return Altezza;
        }

        public override string Area()
        {
            double area=altezza*Convert.ToDouble(LunghezzaLato)/ 2;

            return area.ToString();
        }
    }
}
