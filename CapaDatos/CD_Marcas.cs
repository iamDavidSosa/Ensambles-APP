using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Marcas
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlDataReader leer;
        private SqlCommand comando = new SqlCommand();

        public DataTable MostrarMarcas()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMarcas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void ActualizaMarca(Int32 id_marca, string marca, string descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizaMarca";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_marca", id_marca);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void EliminaMarca(int id_marca)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminaMarca";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_marca", id_marca);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable RetornarMarca(int id_marca)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RetornarMarca";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_marca", id_marca);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
