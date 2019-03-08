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

namespace GestionDeInventario.UI
{
    public partial class Compras : Form
    {
        List<DetalleCompra> listaCompra = new List<DetalleCompra>();
        public Compras()
        {
            InitializeComponent();
       
        }

        private DetalleCompra LlenaDetalle()
        {
            DetalleCompra detalle = new DetalleCompra();
            detalle.CodigoComprasProducto = Convert.ToInt32(CodigoProductonumericUpDown.Value);
            return detalle;
        }

        public void ActualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaCompra;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            listaCompra.Add(LlenaDetalle());
           // LimpiarCamposDetalle();
            ActualizarGrid();
        }

        private void LimpiarCamposDetalle()
        {
            throw new NotImplementedException();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
