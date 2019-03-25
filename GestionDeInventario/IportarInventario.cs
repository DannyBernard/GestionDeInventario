using GestionDeInventario.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeInventario
{
    public partial class IportarInventario : Form
    {
        public IportarInventario()
        {
            InitializeComponent();
        }

        private void Cargarbutton_Click(object sender, EventArgs e)
        {
            new DetalleIventario().Exportar(dataGridView1, "Prueva");
        }
    }
}
