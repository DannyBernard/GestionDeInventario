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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace GestionDeInventario
{
   
    public partial class IportarInventario : Form
    {
        List<DetalleIventario> lista = new List<DetalleIventario>();
        public IportarInventario()
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
      
        public DataTable foreingk()
        {
            Iventario iventario = new Iventario();
            return iventario.foreign();
        }
        private void Cargarbutton_Click(object sender, EventArgs e)
        {
            new DetalleIventario().Exportar(dataGridView1, "Prueva");
        }
        MySqlConnection conn = new MySqlConnection("Initial Catalog= ProyectoAplicado_1_2019; datasource=127.0.0.1;port =3306;username = danny; password=1515");
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
          
            MySqlCommand command = new MySqlCommand("INSERT INTO IventarioProducto Values( @CodigoProducto, @Cantidad, @Precio, @DescripcionDelProducto, @Almacen, @Gondola)",conn);
            conn.Open();
            try
            {
                /*
             foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    command.Parameters.Clear();
                    command.Parameters.Add("@CodigoProducto", MySqlDbType.Int32).Value = Convert.ToString(row.Cells["codigoProductoDataGridViewTextBoxColumn"].Value);
                    command.Parameters.Add("@Cantidad", MySqlDbType.Int32).Value = Convert.ToString(row.Cells["cantidadDataGridViewTextBoxColumn"].Value);
                    command.Parameters.Add("@Precio", MySqlDbType.Float).Value = Convert.ToString(row.Cells["precioDataGridViewTextBoxColumn"].Value);
                    command.Parameters.Add("@DescripcionDelProducto", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["descripcionDelProductoDataGridViewTextBoxColumn"].Value);
                    command.Parameters.Add("@Gondola", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["gondolaDataGridViewTextBoxColumn"].Value);
                    command.Parameters.Add("@Almacen", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["codigoProductoDataGridViewTextBoxColumn"].Value);
                    command.ExecuteNonQuery();
                  
                }
              */
                Iventario inventario = new Iventario();
                List<DetalleIventario> lista = new List<DetalleIventario>();
                DetalleIventario di = new DetalleIventario();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                  
                    di.CodigoProducto = Convert.ToInt32(row.Cells[0].Value);
                    di.Cantidad = Convert.ToInt32(row.Cells[1].Value);
                    di.Precio = Convert.ToSingle(row.Cells[2].Value);
                    di.DescripcionDelProducto = Convert.ToString(row.Cells[3].Value);
                    di.Gondola = Convert.ToString(row.Cells[4].Value);
                    di.Almacen = Convert.ToString(row.Cells[5].Value);
                    DataTable dt = new DataTable();

                    // DetalleIventario detalleIventario = new DetalleIventario();
                   
                    lista.Add(di);
                }
               if(di.Crear(lista))
                {
                    if (LlenaClase().Crear())
                    

                    
                    MessageBox.Show("Listo");
                }
                
            }
            catch (Exception ex)
            {
                Console.Write(ex);
              
                

            }
            
        }
    }
}
