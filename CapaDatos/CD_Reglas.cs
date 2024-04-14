using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Reglas
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlDataReader leer;
        private SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarReglas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(Int32 id_regla, Int32 id_caracteristica_1, string valor_1, string operador, Int32 id_caracteristica_2, string valor_2)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizaReglaCompatibilidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_regla", id_regla);
            comando.Parameters.AddWithValue("@id_caracteristica_1", id_caracteristica_1);
            comando.Parameters.AddWithValue("@valor_1", valor_1);
            comando.Parameters.AddWithValue("@operador", operador);
            comando.Parameters.AddWithValue("@id_caracteristica_2", id_caracteristica_2);
            comando.Parameters.AddWithValue("@valor_2", valor_2);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public void Eliminar(Int32 id_regla)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarRegla";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_regla", id_regla);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable RetornarRegla(Int32 id_regla)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RetornarRegla";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_regla", id_regla);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
