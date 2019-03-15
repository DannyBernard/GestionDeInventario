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
    public partial class ControlIvenariocs : Form
    {
        List<DetalleIventario> lista = new List<DetalleIventario>();
        public ControlIvenariocs()
        {
            InitializeComponent();
        }
        
        public DetalleIventario LlenarDetalle()
        {
            DetalleIventario detalleIventario = new DetalleIventario();
            detalleIventario.CodigoIventarioProducto = Convert.ToInt32(CodigoRegistronumericUpDown.Value);
            detalleIventario.CodigoProducto = Convert.ToInt32(CodigoProductonumericUpDown.Value);
            detalleIventario.DescripcionDelProducto = DescripciontextBox.Text;
            detalleIventario.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            detalleIventario.Precio = Convert.ToSingle(prenumericUpDown.Value);
            detalleIventario.Gondola = GondolacomboBox.Text;
            detalleIventario.Almacen = AlmacencomboBox.Text;
            return detalleIventario;
        }
        public Iventario LlenaClase()
        {
            Iventario iventario = new Iventario();
            iventario.CodigoInvetario = Convert.ToInt32(CodigoIventarionumericUpDown.Value);
            iventario.Obsevacion = ObservaciontextBox.Text;
            iventario.TipoDeIventario = TipoDeInventariocomboBox.Text;
            return iventario;

        }
        public void ActualizarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }
        public void LlenaCampo(Iventario iventario)
        {
            Iventario inventario = new Iventario();
            CodigoIventarionumericUpDown.Value  = Convert.ToInt32(iventario.CodigoInvetario);
            ObservaciontextBox.Text = iventario.Obsevacion;
            ObservaciontextBox.Text = iventario.TipoDeIventario;

            lista.Add(LlenarDetalle());

        }

        private void AddALGrinbutton_Click(object sender, EventArgs e)
        {
            lista.Add(LlenarDetalle());
            ActualizarGrid();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (LlenaClase().Crear())
            {
                if (LlenarDetalle().Crear(lista))
                    {
                    MessageBox.Show("Guardo");
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Iventario iventario = new Iventario();
            DetalleIventario detalleIventario = new DetalleIventario();
            int id = Convert.ToInt32(CodigoProductonumericUpDown.Value);
           dataGridView1.DataSource = detalleIventario.Buscar(id);
            LlenaCampo(iventario);
        }
    }
}
