using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Caracteristicas
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlDataReader leer;
        private SqlCommand comando = new SqlCommand();

        public DataTable MostrarCaracteristicas()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCaracteristicas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void ActualizaCaracteristica(Int32 id_caracteristica, Int32 id_tipo_componente, string nombre, string descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizaCaracteristica";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_caracteristica", id_caracteristica);
            comando.Parameters.AddWithValue("@id_tipo_componente", id_tipo_componente);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminaCaracteristica(Int32 id_caracteristica)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminaCaracteristica";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_caracteristica", id_caracteristica);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable RetornarCaracteristica(Int32 id_caracteristica)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RetornarCaracteristica";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_caracteristica", id_caracteristica);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
