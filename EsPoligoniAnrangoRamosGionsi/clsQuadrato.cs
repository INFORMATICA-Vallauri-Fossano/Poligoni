using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsPoligoniAnrangoRamosGionsi
{
    internal class clsQuadrato:clsPoligonoRegolare
    {
        public clsQuadrato(string lun, string n) : base(lun, n)
        {
            Dati = "Poligono = Quadrato" + Dati + "\nArea = " + Area();
        }

        public override string Area()
        {
            double area;
            area = Math.Pow(Convert.ToDouble(LunghezzaLato), 2);
            return area.ToString();
        }
    }
}
