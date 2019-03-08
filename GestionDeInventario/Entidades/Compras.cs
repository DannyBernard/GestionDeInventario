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
    public class Compras : DataDB
    {
        public int CodigoCompra { get; set; }
        public int NumeroOrden { get; set; }
        public int CodigoSuplidor { get; set; }
        public string NombreSuplidor { get; set; }
        public DateTime FechaCreacion { get; set; }
        

        public Compras()
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
        public bool Crear2(Compras compra, List<DetalleCompra> lista)
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
            //ejecutar el comendo
            command.Prepare();
            command.ExecuteReader();
            //fin de la ejecucion de la primera consulta

            foreach (DetalleCompra d in lista)
            {
                command = new MySqlCommand(InsertIntoD, conn);
                command.Parameters.AddWithValue("@CodigoCompraProducto", d.CodigoComprasProducto);
                command.Parameters.AddWithValue("@CodigoProducto", d.CodigoDeProducto);
                command.Parameters.AddWithValue("@Descripcion", d.Descripcion);
                command.Parameters.AddWithValue("@Cantidad", d.Cantidad);

                command.Prepare();
                command.ExecuteReader();

                //actualizar el producto
                Producto p = new Producto().Buscar(d.CodigoDeProducto);
                p.Cantidad += d.Cantidad;
                p.Modificar();
                //ejecutar y leer para obtener el producto y almacenarlo en un objeto
                //seleccionas el producto obtienes la cantidad, luego sumar d.Cantidad a cantidad
                //hacer otro comando pero con un update del produnto en el campo cantidad
                //

            }
            


            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();
            paso = reader.RecordsAffected > 0;
            conn.Clone();
            return paso;



        }
    }
}
