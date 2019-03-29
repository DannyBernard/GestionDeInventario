using GestionDeInventario.Entidades;
using GestionDeInventario.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeInventario.UI
{
    public partial class ReporteVencimiento : Form
    {
        public ReporteVencimiento()
        {
            InitializeComponent();
            
        }

        public void LlenarGrip()
        {
            Producto p = new Producto();
            dataGridView1.DataSource = p.ProductoAVencer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlenarGrip();

        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ImprimirReporte2 ir = new ImprimirReporte2();
            ir.Show();
        }
    }
}
