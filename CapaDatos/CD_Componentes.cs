using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Componentes
    {
        private CD_Conexion conexion = new();
        private SqlDataReader? leer;
        private SqlCommand comando = new();
        DataTable tabla = new();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarComponentes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(Int32 id_componente, Int32 id_tipo_componente, Int32 id_marca, string modelo, string descripcion, float precio_venta, Int32 cantidad, Int32 estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizaComponente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_componente", id_componente);
            comando.Parameters.AddWithValue("@id_tipo_componente", id_tipo_componente);
            comando.Parameters.AddWithValue("@id_marca", id_marca);
            comando.Parameters.AddWithValue("@modelo", modelo);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@precio_venta", precio_venta);
            comando.Parameters.AddWithValue("@cantidad", cantidad);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(Int32 id_componente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarComponente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_componente", id_componente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable RetornarComponente(Int32 id_componente)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RetornarComponente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_componente", id_componente);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable RetornarTipos()
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RetornarTipos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable RetornarMarcas()
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RetornarMarcas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
