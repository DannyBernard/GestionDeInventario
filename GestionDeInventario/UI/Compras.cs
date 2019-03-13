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
        Compra compra;
        public Compras()
        {
            InitializeComponent();
            compra = new Compra();
       
        }

        private DetalleCompra LlenaDetalle()
        {
            DetalleCompra detalle = new DetalleCompra();
            detalle.CodigoComprasProducto = Convert.ToInt32(CodigoProductonumericUpDown.Value);
            detalle.CodigoDeProducto = Convert.ToInt32(CodigoProductonumericUpDown.Value);
            detalle.Descripcion = Convert.ToString(DescripciontextBox);
            detalle.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            detalle.Costo = Convert.ToSingle(CostonumericUpDown.Value);
            detalle.FechaDeVencimineto = Convert.ToDateTime(FechaVencdateTimePicker.Value);
            return detalle;
        }
        private Compra LlenaClase()
        {
            Compra compra = new Compra();
            compra.CodigoCompra = Convert.ToInt32(CodigoCompranumericUpDown.Value);
            compra.CodigoSuplidor = Convert.ToInt32(CodigoDelSuplidornumericUpDown.Value);
            compra.NombreSuplidor = Convert.ToString(NombreSuplidortextBox.Text);
            compra.NumeroOrden = Convert.ToInt32(OrdennumericUpDown.Value);

            LlenaDetalle();
            return compra;
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

       

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
           
            if (LlenaClase().Crear2(compra, listaCompra))
            {
                MessageBox.Show("Guardado");
            }
        }

       
    }
}
