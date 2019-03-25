using GestionDeInventario.MisClases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionDeInventario.Entidades
{
    public class DetalleIventario : DataDB
    {
        public int CodigoIventarioProducto { get; set; }
        public int CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public string DescripcionDelProducto { get; set; }
        public string Gondola { get; set; }
        public string Almacen { get; set; }
        public int CodigoIventario { get; set; }

        public DetalleIventario()
        {
            CodigoIventario = 0;
            Cantidad = 0;
            Precio = 0;
            DescripcionDelProducto = string.Empty;
            Gondola = string.Empty;
            Almacen = string.Empty;
            CodigoIventario = 0;

        }

        public DetalleIventario(int codigoIventarioProducto, int codigoProducto, int cantidad, float precio, string descripcionDelProducto, string gondola, string almacen, int codigoIventario)
        {
            CodigoIventarioProducto = codigoIventarioProducto;
            CodigoProducto = codigoProducto;
            Cantidad = cantidad;
            Precio = precio;
            DescripcionDelProducto = descripcionDelProducto;
            Gondola = gondola;
            Almacen = almacen;
            CodigoIventario = codigoIventario;
        }
         public DataTable foreign()
        {
            DataTable dt = new DataTable();

            try
            {


               
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlConnection conn = getConnection();
               
                conn.Open();
                adapter = new MySqlDataAdapter ("select MAX (CodigoIventario) from Invetario", conn);
                adapter.Fill(dt);
               conn.Close();
               
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return dt;

        }
        public bool Crear(List<DetalleIventario> detalleIventarios)
        {
            bool paso = false;
            Iventario iventario = new Iventario();
            MySqlCommand command;
            foreach (var item in detalleIventarios)
            {
            ;
                string sqlInsert = "INSERT IventarioProducto (CodigoIventarioProducto,CodigoProducto,Cantidad,Precio,DescripcionDelProducto,Almacen,Gondola,CodigoIventario)VALUES(@CodigoIventarioProducto,@CodigoProducto,@Cantidad,@Precio,@DescripcionDelProducto,@Almacen,@Gondola,@CodigoIventario)";
                MySqlConnection conn = getConnection();
                conn.Open();
                command = new MySqlCommand(sqlInsert, conn);

                command.Parameters.AddWithValue("@CodigoIventarioProducto", item.CodigoIventarioProducto);
                command.Parameters.AddWithValue("@CodigoProducto", item.CodigoProducto);
                command.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                command.Parameters.AddWithValue("@Precio", item.Precio);
                command.Parameters.AddWithValue("@DescripcionDelProducto", item.DescripcionDelProducto);
                command.Parameters.AddWithValue("@Almacen", item.Almacen);
                command.Parameters.AddWithValue("@Gondola", item.Gondola);
                command.Parameters.AddWithValue("@CodigoIventario",item.CodigoIventario);
                // command.Parameters.AddWithValue("@Inactivo", Convert.ToByte(0));

                command.Prepare();
                MySqlDataReader reader = command.ExecuteReader();
                paso = reader.RecordsAffected > 0;
                conn.Close();
            }
            return paso;
        }
        public bool Modificar(List<DetalleIventario> lista)
        {
            bool paso = false;

            StringBuilder sql = new StringBuilder();
            foreach (var item in lista)
            {
                MySqlConnection conn = getConnection();
                conn.Open();
                MySqlCommand sqlCommand;
                sqlCommand = new MySqlCommand();

                sql.AppendFormat("UPDATE IventarioProducto CodigoIventarioProducto={0},CodigoProducto={1},Cantidad={2},Precio,DescripcionDelProducto='{3}',Almacen='{4}',Gondola='{5}'", item.CodigoIventarioProducto, item.CodigoProducto, item.Cantidad, item.Precio, item.DescripcionDelProducto, item.Almacen, item.Gondola);
                sqlCommand.Connection = conn;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = sql.ToString();
                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    return true;

                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            return false;
        }

        public List<DetalleIventario> Buscar(int id)
        {
            List<DetalleIventario> lista = new List<DetalleIventario>();
            MySqlConnection conn = getConnection();

            conn.Open();
           
            
                MySqlCommand command = new MySqlCommand(string.Format("SELECT CodigoIventarioProducto,CodigoProducto,Cantidad,Precio,DescripcionDelProducto,Almacen,Gondola FROM IventarioProducto WHERE CodigoIventario ", id), conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                DetalleIventario d = new DetalleIventario();

                    d.CodigoIventarioProducto = reader.GetInt32(0);
                    d.CodigoProducto = reader.GetInt32(1);
                    d.Cantidad = reader.GetInt32(2);
                    d.Precio = reader.GetFloat(3);
                    d.DescripcionDelProducto = reader.GetString(4);
                    d.Gondola = reader.GetString(5);
                    d.Almacen = reader.GetString(6);

                lista.Add(d);
                }
                conn.Close();
                 return lista;




        }
        OleDbConnection conn;
        OleDbDataAdapter dbDataAdapter;
        DataTable dataTable;
        public void Exportar(DataGridView dgv,string nombrehoja)
        {
            string ruta = "";
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel File |*.xlsx";
                ofd.Title = "Seleccione el Archivo";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileName.Equals("") == false)
                    {
                        ruta = ofd.FileName;
                    }
                }
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'");
                dbDataAdapter = new OleDbDataAdapter("Select * from [" + nombrehoja + "$]", conn);
                dataTable = new DataTable();
                dbDataAdapter.Fill(dataTable);
                dgv.DataSource = dataTable;

            }catch(Exception e)
            {
                Console.Write(e.ToString());
            }

            
        }
    }
}
