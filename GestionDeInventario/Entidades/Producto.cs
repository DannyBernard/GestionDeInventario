using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeInventario.MisClases;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestionDeInventario.Entidades
{
    public class Producto : DataDB
    {
        public int CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public string Provedor { get; set; }
        public DateTime FechaDeVencimiento { get; set; }


        public Producto()
        {
            CodigoProducto = 0;
            Descripcion = string.Empty;
            Cantidad = 0;
            Precio = 0;
            Provedor = string.Empty;
            FechaDeVencimiento = DateTime.Now;

        }

        public bool Guardar()
        {
            if (this.CodigoProducto == 0)
            {
                return this.Crear();
            }
            else if (this.CodigoProducto > 0)
            {
                return this.Modificar();
            }
            return false;
        }



        public bool Crear()
        {
            bool paso = false;
           // try
           // {
             
                MySqlCommand command;
                String sqlInsert = "insert into Producto(CodigoProducto,Descripcion,Cantidad,Precio,Provedor,FechaVencimiento,Inactivo) values (@codigo,@descripcion,@cantidad,@precio,@provedor,@fechavenc,@Inactivo)";
                MySqlConnection conn = getConnection();
                conn.Open();
                command = new MySqlCommand(sqlInsert, conn);
                command.Parameters.AddWithValue("@codigo", this.CodigoProducto);
                command.Parameters.AddWithValue("@descripcion", this.Descripcion);
                command.Parameters.AddWithValue("@cantidad", this.Cantidad);
                command.Parameters.AddWithValue("@precio", this.Precio);
                command.Parameters.AddWithValue("@provedor",this.Provedor);
                command.Parameters.AddWithValue("@fechavenc", this.FechaDeVencimiento);
                command.Parameters.AddWithValue("@Inactivo", Convert.ToByte(0));
                command.Prepare();
                MySqlDataReader dataReader = command.ExecuteReader();
                paso = dataReader.RecordsAffected > 0;
                return paso = true;
           // }
            /*
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            */
          //  return paso = true;
        }

        public bool Modificar()
        {
            try
            {
                bool paso = false;
                StringBuilder stringBuilder = new StringBuilder();
                MySqlConnection conn = getConnection();
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand();
                stringBuilder.AppendFormat("UPDATE Producto SET Descripcion ='{0}',Cantidad = {1},Precio ={2},Provedor = '{3}'");
                mySqlCommand.Connection = conn;
                mySqlCommand.CommandText = stringBuilder.ToString();
                if (mySqlCommand.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    return paso = true;

                }
                else
                {
                    conn.Close();
                    return paso;
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return false;
        }
        public Producto Buscar(int id)
        {
            try
            {
                bool paso = false;
                StringBuilder stringBuilder = new StringBuilder();
                MySqlCommand command;
                stringBuilder.AppendFormat("SELECT CodigoProducto, Descripcion,Cantidad,Precio,Provedor,FechaDeVencimiento FROM Producto WHERE CodigoProducto ={0} AND Inactico <> 1 ", id);
                MySqlConnection conn = getConnection();
                command = new MySqlCommand(stringBuilder.ToString(), conn);
                conn.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    this.CodigoProducto = Convert.ToInt32(dataReader["CodigoProducto"]);
                    this.Descripcion = Convert.ToString(dataReader["Descripcion"]);
                    this.Cantidad = Convert.ToInt32(dataReader["Cantidad"]);
                    this.Precio = Convert.ToSingle(dataReader["Precio"]);
                    this.Provedor = Convert.ToString(dataReader["Provedor"]);
                    this.FechaDeVencimiento = Convert.ToDateTime(dataReader["FechaDeVencimiento"]);
                }
                conn.Close();
                return this; 
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return null; 

        }

        public bool Eliminar()
        {
            try
            {
                bool paso = false;
                StringBuilder stringBuilder = new StringBuilder();
                MySqlConnection conn = getConnection();
                conn.Open();
                stringBuilder.AppendFormat("UPDATE Producto SET Inactvo = 1 WHERE CodigoProducto = {0}", this.CodigoProducto);
                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = stringBuilder.ToString();
                command.ExecuteNonQuery();
                conn.Close();
                return paso;
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            return false;
        }
        public void CargarCombo()
        {
            MySqlConnection conn = getConnection();
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("SELECT CodigoProducto,Descripcion FROM Producto");
            MySqlCommand command = new MySqlCommand(sql.ToString(), conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            

        }
    }
}
