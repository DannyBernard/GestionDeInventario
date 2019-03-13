using GestionDeInventario.MisClases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeInventario.UI;

namespace GestionDeInventario.Entidades
{
    public class Compra : DataDB
    {
        public int CodigoCompra { get; set; }
        public int NumeroOrden { get; set; }
        public int CodigoSuplidor { get; set; }
        public string NombreSuplidor { get; set; }
        public DateTime FechaCreacion { get; set; }


        public Compra()
        {
            CodigoCompra = 0;
            NumeroOrden = 0;
            CodigoSuplidor = 0;
            NombreSuplidor = string.Empty;
            FechaCreacion = DateTime.Now;

        }
        /*
        public bool Crear()
        {
            DetalleCompra detalleCompra = new DetalleCompra();
            bool paso = false;
            MySqlCommand command;
            string InsertInto = "INSERT INTO Compra (CodigoCompra,NumeroDeOrdden,CodigoSuplidor,FechaCreacion)values(@CodigoCompra,@NumeroDeOrden,@CodigoSuplidor)";
            string InsertIntoD = "INSERT INTO ComprasProducto (CodigoCompraProducto,CodigoProducto,Descripcion,Cantidad,Costo,FechaVencimiento )values (@CodigoCompraProducto,@CodigoProducto,@Descripcion,@Cantidad,@Costo,@FechaVencimiento )";
            MySqlConnection conn = getConnection();
            conn.Open();
            command = new MySqlCommand(InsertInto, conn);
            command.Parameters.AddWithValue("@CodigoCOmpra", this.CodigoCompra);
            command.Parameters.AddWithValue("@NumeroDeOrden", this.NumeroOrden);
            command.Parameters.AddWithValue("@CodigoSuplidor", this.CodigoSuplidor);
            command.Parameters.AddWithValue("FechaCreacion", this.FechaCreacion);
            command = new MySqlCommand(InsertIntoD, conn);
            foreach(var item in detalleCompra.CodigoDeProducto)
            {

            }
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();
            paso = reader.RecordsAffected > 0;
            conn.Clone();
            return paso;



        }
        */
        public bool Crear2(Compra compra, List<DetalleCompra> lista)
        {
            DetalleCompra detalleCompra = new DetalleCompra();
            Producto prod = new Producto();
            StringBuilder sql = new StringBuilder();
            bool paso = false;
            MySqlCommand command;
            string InsertInto = "INSERT INTO Compras (CodigoCompra,NumeroOrden,CodigoSuplidor,NombreSuplidor,FechaCreacion)values(@CodigoCompra,@NumeroOrden,@CodigoSuplidor,@NombreSuplidor,@FechaCreacion)";
            string InsertIntoD = "INSERT INTO ComprasProducto (CodigoDeProducto,Descripcion,Cantidad,Costo,FechaDeVencimineto )values (@CodigoProducto,@Descripcion,@Cantidad,@Costo,@FechaVencimiento )";
            // sql.AppendFormat("UPDATE PRODUCTO SET Cantidad = {0} where CodigoProducto = {1}", prod.Cantidad, prod.CodigoProducto);
            MySqlConnection conn = getConnection();
            conn.Open();
            command = new MySqlCommand(InsertInto, conn);
            command.Parameters.AddWithValue("@CodigoCompra", this.CodigoCompra);
            command.Parameters.AddWithValue("@NumeroOrden", this.NumeroOrden);
            command.Parameters.AddWithValue("@CodigoSuplidor", this.CodigoSuplidor);
            command.Parameters.AddWithValue("@NombreSuplidor", this.NombreSuplidor);
            command.Parameters.AddWithValue("@FechaCreacion", this.FechaCreacion);
            //ejecutar el comendo
            command.Prepare();
            command.ExecuteReader();
            
            MySqlDataReader reader = command.ExecuteReader();
            paso = reader.RecordsAffected > 0;
            conn.Close();

            //MySqlDataReader reader = command.ExecuteReader();
            // paso = reader.RecordsAffected > 0;

            //fin de la ejecucion de la primera consulta
            MySqlConnection conn2 = getConnection();
            conn2.Open();
            foreach (DetalleCompra d in lista)
            {
                 MySqlCommand command2;
                command2 = new MySqlCommand(InsertIntoD, conn2);
                //command2.Parameters.AddWithValue("@CodigoCompraProducto", d.CodigoComprasProducto);
                command2.Parameters.AddWithValue("@CodigoProducto", d.CodigoDeProducto);
                command2.Parameters.AddWithValue("@Descripcion", d.Descripcion);
                command2.Parameters.AddWithValue("@Cantidad", d.Cantidad);
                command2.Parameters.AddWithValue("@Costo", d.Costo);
                command2.Parameters.AddWithValue("@FechaVencimiento", d.FechaDeVencimineto);

                //   MySqlDataReader reader2 = command2.ExecuteReader();
                //  paso = reader2.RecordsAffected > 0;
                //actualizar el product    
                /*
                Producto p = new Producto().Buscar(d.CodigoDeProducto);
                p.Cantidad += d.Cantidad;
                p.Modificar();
                //ejecutar y leer para obtener el producto y almacenarlo en un objeto
                //seleccionas el producto obtienes la cantidad, luego sumar d.Cantidad a cantidad
                //hacer otro comando pero con un update del produnto en el campo cantidad

                //
              
             * */
                command2.Prepare();
                command2.ExecuteReader();
                MySqlDataReader reader2 = command2.ExecuteReader();
                paso = reader2.RecordsAffected > 0;
                conn2.Close();
            }
                return paso;
            

         



        }
    }
}
