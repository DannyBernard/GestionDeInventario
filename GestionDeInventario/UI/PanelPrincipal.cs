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



        private void controlDeInventarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ControlIvenariocs controlIvenariocs = new ControlIvenariocs();
            controlIvenariocs.Show();

        }

        private void provedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoProvedores mantenimientoProvedores = new MantenimientoProvedores();
            mantenimientoProvedores.Show();
            mantenimientoProvedores.MdiParent = this;
        }

        private void consultaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarProducto buscarProducto = new BuscarProducto();
            buscarProducto.Show();
            buscarProducto.MdiParent = this;
        }

        private void consultaProvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarProvedor buscarProvedor = new BuscarProvedor();
            buscarProvedor.Show();
            buscarProvedor.MdiParent = this;
        }

        private void importarIventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IportarInventario ip = new IportarInventario();
            ip.Show();
            ip.MdiParent = this;
        }

        private void productosBajoEnStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteProductosbajo_en_stock reporte = new ReporteProductosbajo_en_stock();
            reporte.Show();

        }
    }
}
