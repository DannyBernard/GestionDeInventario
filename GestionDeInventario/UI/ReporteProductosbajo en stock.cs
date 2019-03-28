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
    public partial class ReporteProductosbajo_en_stock : Form
    {
        public ReporteProductosbajo_en_stock()
        {
            InitializeComponent();
        }

        public void LlenaData()
        {
            Producto p = new Producto();
            dataGridView1.DataSource = p.BuscarR();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlenaData();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ImprimirRporte1 i = new ImprimirRporte1();
            i.Show();
        }
    }
}
