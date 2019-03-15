using GestionDeInventario.MisClases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeInventario.Entidades
{
    public class Provedores : DataDB
    {
        public int CodigoProvedores { get; set; }
        public string NombreDeLaEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Chofer { get; set; }

        public Provedores(int codigoProvedores, string nombreDeLaEmpresa, string direccion, string telefono, string chofer)
        {
            this.CodigoProvedores = codigoProvedores;
            this.NombreDeLaEmpresa = nombreDeLaEmpresa;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Chofer = chofer;
        }

        public Provedores()
        {

        }

        public bool Guardar()
        {
            if (this.CodigoProvedores == 0)
            {
                return this.Crear();
            }
            else if (this.CodigoProvedores > 0)
            {
                return this.Modificar();
            }
            return false;
        }


        private bool Crear()
        {
            bool paso = false;
            MySqlCommand command;
            string sqlInsert = "INSERT Provedores (CodigoProvedor,NombreDeLaEmpresa,Direccion,Telefono,ChoferActual,Inactivo)VALUES(@Codigo,@Nombre,@Direccion,@Telefono,@chofer,@Inactivo)";
            MySqlConnection conn = getConnection();
            conn.Open();
            command = new MySqlCommand(sqlInsert, conn);
            command.Parameters.AddWithValue("@Codigo", this.CodigoProvedores);
            command.Parameters.AddWithValue("@Nombre", this.NombreDeLaEmpresa);
            command.Parameters.AddWithValue("@Direccion", this.Direccion);
            command.Parameters.AddWithValue("@Telefono", this.Telefono);
            command.Parameters.AddWithValue("@chofer", this.Chofer);
            command.Parameters.AddWithValue("@Inactivo", Convert.ToByte(0));
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();
            paso = reader.RecordsAffected > 0;
            conn.Close();
            return paso;
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
                stringBuilder.AppendFormat("UPDATE Provedores SET NombreDeLaEmpresa ='{0}',Direccion = '{1}',Telefono ='{2}',ChoferActual = '{3}'where CodigoProvedor={4}", this.NombreDeLaEmpresa, this.Direccion, this.Telefono, this.Chofer, this.CodigoProvedores);
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

        public bool Eliminar()
        {
            try
            {
                bool paso = false;
                StringBuilder stringBuilder = new StringBuilder();
                MySqlConnection conn = getConnection();
                conn.Open();
                stringBuilder.AppendFormat("UPDATE Provedores SET Inactivo = 1 WHERE CodigoProvedor = {0}", this.CodigoProvedores);
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

        public List<Provedores> BuscarL()
        {
            List<Provedores> lista = new List<Provedores>();
            MySqlConnection conn = getConnection();
            conn.Open();

            MySqlCommand command;
            command = new MySqlCommand(string.Format("SELECT CodigoProvedor, NombreDeLaEmpresa,Direccion, Telefono, ChoferActual FROM Provedores where Inactivo <>1"), conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Provedores provedores = new Provedores();
                provedores.CodigoProvedores = reader.GetInt32(0);
                provedores.NombreDeLaEmpresa = reader.GetString(1);
                provedores.Direccion = reader.GetString(2);
                provedores.Telefono = reader.GetString(3);
                provedores.Chofer = reader.GetString(4);


                lista.Add(provedores);

            }
            conn.Close();
            return lista;

        }
        public Provedores Buscarp(int id)
        {
            MySqlConnection conn = getConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand(string.Format("SELECT CodigoProvedor, NombreDeLaEmpresa,Direccion, Telefono, ChoferActual FROM Provedores WHERE CodigoProvedor={0}", id), conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                this.CodigoProvedores = reader.GetInt32(0);
                this.NombreDeLaEmpresa = reader.GetString(1);
                this.Direccion = reader.GetString(2);
                this.Telefono = reader.GetString(3);
                this.Chofer = reader.GetString(4);



            }
            conn.Close();
            return this;
        }
    }
}
