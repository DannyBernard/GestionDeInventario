using System;
using System.Text;

using GestionDeInventario.MisClases;
using MySql.Data.MySqlClient;

namespace GestionDeInventario.Entidades
{
    public class Usuario : DataDB
    {

        public int CodigoUsuario { get; set; }
        public String Nombres { get; set; }
        public String Cuenta { get; set; }
        public String Clave { get; set; }
        public bool TipoDeCuenta { get; set; }
        public byte Inactivo { get; set; }
        public DateTime FechaCreacion { get; set; }


        public Usuario()
        {
            CodigoUsuario = 0;
            Nombres = string.Empty;
            Cuenta = string.Empty;
            Clave = string.Empty;
            TipoDeCuenta = false;
            Inactivo = 0;
            FechaCreacion = DateTime.Now;

        }

        public bool Guardar()
        {
            if (this.CodigoUsuario == 0)
            {
                return this.Crear();
            }
            else if (this.CodigoUsuario > 0)
            {
                return this.Modificar();
            }
            return false;
        }

        private bool  Crear()
        {
            bool paso = false;
            MySqlCommand command;
            String SqlInsertUsuario = "insert into Usuario (CodigoUsuario,Nombres,Cuenta,Clave,TipoDeCuenta,Inactivo,FechaDeCreacion)values (@Codigo,@Nombre,@Cuenta,@Password,@TipoDeCuenta,@Inactivo,@fecha)";
            MySqlConnection conn = getConnection();
            conn.Open();
            command = new MySqlCommand(SqlInsertUsuario, conn);
            command.Parameters.AddWithValue("@Codigo", this.CodigoUsuario);
            command.Parameters.AddWithValue("@Nombre", this.Nombres);
            command.Parameters.AddWithValue("@Cuenta", this.Cuenta);
            command.Parameters.AddWithValue("@Password", this.Clave);
            command.Parameters.AddWithValue("@TipoDeCuenta", this.TipoDeCuenta);
            command.Parameters.AddWithValue("@Inactivo", Convert.ToByte(0));
            command.Parameters.AddWithValue("@Fecha", this.FechaCreacion);
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();
            paso = reader.RecordsAffected > 0;
            conn.Close();

            return paso;
        }

        public bool Modificar()
        {
            bool paso = false;
            StringBuilder sql = new StringBuilder();
            MySqlConnection conn = getConnection();
            conn.Open();

            sql.AppendFormat("UPDATE Usuario Set Nombres = '{0}', Cuenta='{1}', Clave='{2}',TipoDeCuenta={3},FechaDeCreacion= {4} WHERE CodigoUsuario = {5}", this.Nombres, this.Cuenta, this.Clave, this.TipoDeCuenta, this.FechaCreacion, this.CodigoUsuario); ;
            MySqlCommand sqlCommand;
            sqlCommand = new MySqlCommand();
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
        public bool Buscar()
        {
            bool paso = false;
            StringBuilder sql = new StringBuilder();

            MySqlCommand command;

            sql.AppendFormat("select CodigoUsuario, Nombres,Cuenta,Clave,TipoDeCuenta,FechaDeCreacion from Usuario where CodigoUsuario ={0} AND Inactivo <> 1 ", this.CodigoUsuario);

            MySqlConnection conn = getConnection();
            command = new MySqlCommand(sql.ToString(), conn);
            conn.Open();
            MySqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                if (dataReader.Read())
                {
                    this.CodigoUsuario = Convert.ToInt32(dataReader["CodigoUsuario"]);
                    this.Nombres = Convert.ToString(dataReader["Nombres"]);
                    this.Cuenta = Convert.ToString(dataReader["Cuenta"]);
                    this.Clave = Convert.ToString(dataReader["Clave"]);
                    this.TipoDeCuenta = Convert.ToBoolean(dataReader["TipoDeCuenta"]);
                    this.FechaCreacion = Convert.ToDateTime(dataReader["FechaDeCreacion"]);
                    //this.Inactivo = Convert.ToByte(dataReader["Inactivo"]);
                  
                }
                conn.Close();
                return true;
            }

            return paso;
        }
        public bool Eliminar()
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                bool paso = false;
                MySqlConnection conn = getConnection();
                conn.Open();
                sql.AppendFormat("UPDATE Usuario SET Inactivo = 1 WHERE CodigoUsuario = {0}", this.CodigoUsuario);
                MySqlCommand sqlCommand;
                sqlCommand = new MySqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = sql.ToString();
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                return paso;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;

        }

    }
}
