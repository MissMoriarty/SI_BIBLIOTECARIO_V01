using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 

namespace SI_BIBLIOTECARIO
{
    public class Conexion
    {
        private MySqlConnection conexion;
        private string servidor = "localhost";
        private string baseDatos = "si bibliotecario";
        private string usuario = "root";
        private string clave = "";
        private string cadenaconexion;
        public Conexion()
        {
            cadenaconexion = "database = " + baseDatos + "; DataSource = " + servidor + "; user id = " + usuario + "; password =" + clave ;
        }

        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaconexion);
                conexion.Open();
            }
            return conexion;
        }
    }
}
