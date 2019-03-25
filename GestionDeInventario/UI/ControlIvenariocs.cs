using GestionDeInventario.Entidades;
using MySql.Data.MySqlClient;
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
            TipoDeInventariocomboBox.SelectedIndex = 0;
            GondolacomboBox.SelectedIndex = 0;
            AlmacencomboBox.SelectedIndex = 0;
        }




        public Iventario LlenaClase()
        {
            Iventario iventario = new Iventario();

            iventario.Obsevacion = ObservaciontextBox.Text;
            iventario.TipoDeIventario = TipoDeInventariocomboBox.Text;
            return iventario;

        }
        public void Nuevo()
        {
            CodigoRegistronumericUpDown.Value = 0;


            DescripciontextBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            GondolacomboBox.Text = string.Empty;
            AlmacencomboBox.Text = string.Empty;

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
            // Nuevo();
        }

        public DataTable foreingk()
        {
            Iventario iventario = new Iventario();
            return iventario.foreign();
        }
        int id;
        private void Guardarbutton_Click(object sender, EventArgs e)
        {


            //errorProvider1.Clear();
            if (Validar())
            {
                MessageBox.Show("Revise Sus Campos");
                return;
            }
            Iventario inventario = LlenaClase();

            //Iventario inventario = LlenaClase();
            if (inventario.Crear())
            {


                //DetalleIventario detalleIventario = new DetalleIventario();


                DetalleIventario detalleIventario = new DetalleIventario();
                if (detalleIventario.Crear(lista))
                {


                    MessageBox.Show("Guardo");
                }
            }
        
    }

        public DetalleIventario LlenarDetalle()
        {
            Iventario inventario = new Iventario();
            DetalleIventario detalleIventario = new DetalleIventario();
            DataTable dt = new DataTable();

            // DetalleIventario detalleIventario = new DetalleIventario();
            dt = foreingk();
           
              id = inventario.CodigoInvetario = int.Parse(dt.Rows[0][0].ToString());
            

            detalleIventario.CodigoProducto = Convert.ToInt32(CodigoProductonumericUpDown.Value);
            detalleIventario.DescripcionDelProducto = DescripciontextBox.Text;
            detalleIventario.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            detalleIventario.Precio = Convert.ToSingle(PrecionumericUpDown.Value);
            detalleIventario.Gondola = GondolacomboBox.Text;
            detalleIventario.Almacen = AlmacencomboBox.Text;
            detalleIventario.CodigoIventario = id+1;
           
      

            return detalleIventario;

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
            CantidadnumericUpDown.Value = Convert.ToInt32(producto.Cantidad);
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
            if (CodigoProductonumericUpDown.Value == 0)
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

