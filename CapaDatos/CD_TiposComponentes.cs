using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public  class CD_TiposComponentes
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlDataReader leer;
        private SqlCommand comando = new SqlCommand();

        public DataTable MostrarTiposComponentes()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarTiposComponentes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void ActualizaTipoComponente(Int32 id_tipo_componente, string nombre, string descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizaTipoComponente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_tipo_componente", id_tipo_componente);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminaTipoComponente(int id_tipo_componente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminaTipoComponente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_tipo_componente", id_tipo_componente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable RetornarTipoComponente(int id_tipo_componente)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RetornarTipoComponente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_tipo_componente", id_tipo_componente);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
