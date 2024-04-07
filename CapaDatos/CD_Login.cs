using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Login
    {
        public bool Login(string usuario, string password)
        {
            CD_Conexion conexion = new CD_Conexion();
            string query = "SELECT * FROM t_usuarios WHERE usuario = '" + usuario + "' AND clave = '" + password + "'";
            conexion.AbrirConexion();
            SqlCommand command = new SqlCommand(query, conexion.AbrirConexion());
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                conexion.CerrarConexion();
                return true;
            }
            else
            {
                conexion.CerrarConexion();
                return false;
            }
        }
    }
}
