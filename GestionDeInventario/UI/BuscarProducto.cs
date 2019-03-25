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
    public partial class BuscarProducto : Form
    {
        public BuscarProducto()
        {
            InitializeComponent();
            LlenarGr();
        }
        
         public void LlenarGr()
        {
            string desc = CriteriotextBox.Text;
           
            Producto p = new Producto();
            dataGridView1.DataSource = p.BuscarL(desc);
        }

        
        public Producto Productoselec { get; set; } 
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Productoselec = p.Buscarp(id);
                this.Close();
           }
        }

        private void Cancbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            string desc;
            
            desc = CriteriotextBox.Text;
            dataGridView1.DataSource = this.Buscar(desc);
      
        }
        public List<Producto> Buscar(string Desc)
        {
            string StrConnection = "Initial Catalog= ProyectoAplicado_1_2019; datasource=127.0.0.1;port =3306;username = danny; password=1515";
            List<Producto> lista = new List<Producto>();
            MySqlConnection conn = new MySqlConnection(StrConnection);
            conn.Open();
            MySqlCommand command = new MySqlCommand(string.Format("SELECT CodigoProducto, Descripcion, Precio, Cantidad, Provedor, FechaVencimiento FROM Producto WHERE Descripcion='{0}'like'%"+ CriteriotextBox.Text+ "%'", Desc), conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Producto p = new Producto();
                p.CodigoProducto = reader.GetInt32(0);
                p.Descripcion = reader.GetString(1);
                p.Precio = reader.GetFloat(2);
                p.Cantidad = reader.GetInt32(3);
                p.Provedor = reader.GetString(4);
                p.FechaDeVencimiento = reader.GetDateTime(5);

                lista.Add(p);
            }
            conn.Close();
            return lista;
        }
    }
}
