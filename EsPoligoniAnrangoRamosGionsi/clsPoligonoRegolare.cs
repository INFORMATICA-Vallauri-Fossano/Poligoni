using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsPoligoniAnrangoRamosGionsi
{
    internal abstract class clsPoligonoRegolare
    {
        public string Dati { get; set; } 
        private double lunghezzaLato;
        private int numeroLati;

        public string LunghezzaLato
        {
            get => lunghezzaLato.ToString();
            set
            {
                if (!double.TryParse(value, out lunghezzaLato) || lunghezzaLato <= 0) throw new Exception("Bisogna inserire un numero decimale positivo"); 
            }
        }
        public string NumeroLati
        {
            get => numeroLati.ToString();
            set
            {
                if (!int.TryParse(value, out numeroLati) || numeroLati <= 2) throw new Exception("Bisogna inserire un numero intero. Minimo 2");
            }
        }
        //COSTRUTTORE
        public clsPoligonoRegolare(string lun, string n)
        {
            LunghezzaLato = lun;
            NumeroLati = n;
            Dati = "\nPerimetro = " + Perimetro().ToString("N2");
        }
        //METODI PUBBLICI
        public void AssegnaLunghezzaLato(string lun)
        {
            LunghezzaLato = lun;
        }
        public string LeggiLunghezzalato()
        {
            return LunghezzaLato;
        }
        public void AssegnaNumeroLati(string n)
        {
            NumeroLati = n;
        }
        public string LeggiNumeroLati()
        {
            return NumeroLati;
        }
        public double Perimetro()
        {
            return numeroLati * lunghezzaLato;
        }
        public abstract string Area();

    }
}
