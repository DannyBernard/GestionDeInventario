using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeInventario.MisClases
{
    public abstract class DataDB
    {
        public DataDB()
        {
            StrConnection = "Initial Catalog= ProyectoAplicado_1_2019; datasource=127.0.0.1;port =3306;username = danny; password=1515";
            connection = new MySqlConnection(StrConnection);
        }
        protected String StrConnection;
        protected MySqlConnection connection;

        public MySqlConnection getConnection()
        {
            try
            {
                if (connection != null)
                {
                    return connection;
                }
                else
                {
                    connection = new MySqlConnection(StrConnection);
                    return connection;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return connection;
        }
    }
}
