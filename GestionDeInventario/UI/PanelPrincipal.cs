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
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mantenimeintoUsuario = new Form1();
            mantenimeintoUsuario.Show();
            mantenimeintoUsuario.MdiParent = this;
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoDeProducto mantenimientoDeProducto = new MantenimientoDeProducto();
            mantenimientoDeProducto.Show();
            mantenimientoDeProducto.MdiParent = this;
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            compras.Show();
            compras.MdiParent = this;

        }
    }
}
