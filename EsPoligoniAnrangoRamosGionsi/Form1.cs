using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsPoligoniAnrangoRamosGionsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<clsPoligonoRegolare> poligoni;
        private void Form1_Load(object sender, EventArgs e)
        {
            poligoni = new List<clsPoligonoRegolare>();
        }

        private void btnInserisciPoligono_Click(object sender, EventArgs e)
        {
            try
            {
                clsPoligonoRegolare poligono;
                if (nudNumeroLati.Value == 3)
                    poligono=new clsTriangolo(txtLunghezzalato.Text, "3", txtAltezza.Text);
                else if (nudNumeroLati.Value == 4)
                    poligono=new clsQuadrato(txtLunghezzalato.Text, "4");
                else if (nudNumeroLati.Value == 9)
                    poligono=new clsEnnagono(txtLunghezzalato.Text, "9", txtApotema.Text);
                else
                    throw new Exception("Il poligono non è Regolare");

                poligoni.Add(poligono);
               VisualizzaPoligoni();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRORE: " + ex.Message);
            }
        }
        private void VisualizzaPoligoni()
        {
            dgvProperties.DataSource = null;
            dgvProperties.DataSource = poligoni;
        }

        private void nudNumeroLati_ValueChanged(object sender, EventArgs e)
        {
            if (nudNumeroLati.Value == 3)
            {
                lblAltezza.Enabled = true;
                txtAltezza.Enabled = true;
                lblApotema.Enabled = false;
                txtApotema.Enabled = false;
            }
            else if (nudNumeroLati.Value == 9)
            {
                lblApotema.Enabled = true;
                txtApotema.Enabled = true;
                lblAltezza.Enabled = false;
                txtAltezza.Enabled = false;
            }
            else
            {
                lblAltezza.Enabled = false;
                txtAltezza.Enabled = false;
                lblApotema.Enabled = false;
                txtApotema.Enabled = false;
            }
        }
    }
}
