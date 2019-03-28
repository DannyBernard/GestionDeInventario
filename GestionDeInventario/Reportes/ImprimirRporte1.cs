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

namespace GestionDeInventario.Reportes
{
    public partial class ImprimirRporte1 : Form
    {
        public ImprimirRporte1()
        {
            InitializeComponent();
            CargarReporte();
        }

        public void CargarReporte()
        {
          
            Producto p = new Producto();
            ProductoReporte pr = new ProductoReporte();
            pr.SetDataSource(Filtar());
            crystalReportViewer1.ReportSource = pr; 
        }

        public DataTable Filtar()
        {
            string Conn = "Initial Catalog= ProyectoAplicado_1_2019; datasource=127.0.0.1;port =3306;username = danny; password=1515";
            string query = "SELECT CodigoProducto, Descripcion, Precio, Cantidad, Provedor, FechaVencimiento FROM Producto WHERE Cantidad <= 5";
            MySqlConnection connection =new MySqlConnection(Conn);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query,connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            return dt;


        }
    }
}
