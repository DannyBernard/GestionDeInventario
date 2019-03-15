using GestionDeInventario.MisClases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeInventario.Entidades
{
    public class Iventario : DataDB
    {
        public int CodigoInvetario { get; set; }
        public string Obsevacion { get; set; }
        public string TipoDeIventario { get; set; }
        public string Usario {get; set;}

        public Iventario()
        {
            CodigoInvetario = 0;
            Obsevacion = string.Empty;
            TipoDeIventario = string.Empty;
           
        }

        public bool Crear()
        {
            bool paso = false;
            MySqlCommand command;
            string sqlInsert = "INSERT Invetario (CodigoIventario,Observacion,TipoDeInvetario)VALUES(@CodigoIventario,@Observacion,@TipoDeInvetario)";
            MySqlConnection conn = getConnection();
            conn.Open();
            command = new MySqlCommand(sqlInsert, conn);
            command.Parameters.AddWithValue("@CodigoIventario", this.CodigoInvetario);
            command.Parameters.AddWithValue("@Observacion", this.Obsevacion);
            command.Parameters.AddWithValue("@TipoDeInvetario", this.TipoDeIventario);
           //  command.Parameters.AddWithValue("@Inactivo", Convert.ToByte(0));
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();
            paso = reader.RecordsAffected > 0;
            conn.Close();
            return paso;
        }
    }
}
