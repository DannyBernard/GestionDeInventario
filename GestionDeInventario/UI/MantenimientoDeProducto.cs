using GestionDeInventario.Entidades;
using GestionDeInventario.MisClases;
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
    public partial class MantenimientoDeProducto : Form 
    {
        public MantenimientoDeProducto()
        {
            InitializeComponent();
            CargarCombo();
        }

       private Producto LlenaClase()
        {
            Producto producto = new Producto();

            producto.CodigoProducto = Convert.ToInt32(CodigonumericUpDown.Value);
            producto.Descripcion = DescripciontextBox.Text;
            producto.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            producto.Precio = Convert.ToSingle(PrecionumericUpDown.Value);
            producto.FechaDeVencimiento = Convert.ToDateTime(FechadateTimePicker.Value);
            producto.Provedor = Convert.ToString(comboBox1.Text);
            return producto;
        }

        private void Llenacampo(Producto producto)
        {

            CodigonumericUpDown.Value = Convert.ToInt32(producto.CodigoProducto);
            DescripciontextBox.Text = producto.Descripcion;
            CantidadnumericUpDown.Value = producto.Cantidad;
            PrecionumericUpDown.Value =Convert.ToDecimal(producto.Precio);
            comboBox1.Text =producto.Provedor;
           // FechadateTimePicker.Value = producto.FechaDeVencimiento;
        }
        private void Nuevo()
        {
            CodigonumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
        }

        public void CargarCombo()
        {
          string  StrConnection = "Initial Catalog= ProyectoAplicado_1_2019; datasource=localhost;port =3306;username = danny; password=1515";

            MySqlConnection conn = new MySqlConnection(StrConnection);
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("SELECT CodigoProducto,Descripcion FROM Producto");
            MySqlCommand command = new MySqlCommand(sql.ToString(), conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);


        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Producto producto;
            if (LlenaClase().Guardar())
            {
                MessageBox.Show("Guadado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se Pudo Guarar", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            BuscarProducto buscarp = new BuscarProducto();
            buscarp.ShowDialog();
            if (buscarp.Productoselec != null)
            {
                int id = buscarp.Productoselec.CodigoProducto;
                producto.Buscarp(id);
                Llenacampo(producto);
            }
        }
    }
}
