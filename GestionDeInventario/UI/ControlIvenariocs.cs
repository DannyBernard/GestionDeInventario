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
            detalleIventario.CodigoIventario = Convert.ToInt32(CodigoIventarionumericUpDown.Value);
            detalleIventario.DescripcionDelProducto = DescripciontextBox.Text;
            detalleIventario.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            detalleIventario.Precio = Convert.ToSingle(PrecionumericUpDown.Value);
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
        public void Nuevo()
        {
            CodigoRegistronumericUpDown.Value = 0;
            CodigoProductonumericUpDown.Value = 0;
            CodigoIventarionumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            GondolacomboBox.Text = string.Empty;
            AlmacencomboBox.Text = string.Empty;
            CodigoIventarionumericUpDown.Value = 0;
            ObservaciontextBox.Text = string.Empty;
            TipoDeInventariocomboBox.Text = string.Empty;
            
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
            if (Validar())
            {
                MessageBox.Show("Revise Sus Campos");
                return;
            }
           
            lista.Add(LlenarDetalle());
            ActualizarGrid();
            Nuevo();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            //errorProvider1.Clear();
            if (Validar())
            {
                MessageBox.Show("Revise Sus Campos");
                return;
            }
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
        private void Llenacampo(Producto producto)
        {
           CodigoProductonumericUpDown.Value = Convert.ToInt32(producto.CodigoProducto);
            DescripciontextBox.Text = producto.Descripcion;
            CantidadnumericUpDown.Value =Convert.ToInt32( producto.Cantidad);
            PrecionumericUpDown.Value = Convert.ToDecimal(producto.Precio);
            
        }
        private void BuscarProductobutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            BuscarProducto buscar = new BuscarProducto();
            buscar.ShowDialog();

            Producto producto = new Producto();
           
            if (buscar.Productoselec != null)
            {
                int id = buscar.Productoselec.CodigoProducto;
                producto.Buscarp(id);
                Llenacampo(producto);
            }
        }

        public bool Validar()
        {
            bool paso = false;
            if(CodigoProductonumericUpDown.Value ==0)
            {
                errorProvider1.SetError(CodigoProductonumericUpDown, "Codigo 0 no exite");
                paso = true;
            }
            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider1.SetError(DescripciontextBox, "Campo Vacio");
                paso = true;
            }
            if (CantidadnumericUpDown.Value == 0)
            {
                errorProvider1.SetError(CantidadnumericUpDown, "Cantidad en 0");
                paso = true;
            }
            if (PrecionumericUpDown.Value == 0)
            {
                errorProvider1.SetError(PrecionumericUpDown, "Precio en 0");
                paso = true;
                
            }
           
            if (string.IsNullOrWhiteSpace(TipoDeInventariocomboBox.Text))
            {
                errorProvider1.SetError(TipoDeInventariocomboBox, "Combo Vacio");
                paso = true;
            }
            if (string.IsNullOrWhiteSpace(GondolacomboBox.Text))
            {
                errorProvider1.SetError(GondolacomboBox, "Combo Vacio");
                paso = true;
            }
            if (string.IsNullOrWhiteSpace(AlmacencomboBox.Text))
            {
                errorProvider1.SetError(AlmacencomboBox, "Combo Vacio");
                paso = true;
            }

            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Nuevo();
            dataGridView1.DataSource = null;
        }
    }
}
