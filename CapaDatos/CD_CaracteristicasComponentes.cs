using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_CaracteristicasComponentes
    {
        private CD_Conexion conexion = new();
        private SqlDataReader? leer;
        private SqlCommand comando = new();
        DataTable tabla = new();

        public DataTable Mostrar(int id_componente)
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCaracteristicasComponente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_componente", id_componente);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(Int32 id_caracteristica, Int32 id_componente, string valor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizaCaracteristicaComponente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_caracteristica", id_caracteristica);
            comando.Parameters.AddWithValue("@id_componente", id_componente);
            comando.Parameters.AddWithValue("@valor", valor);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(Int32 id_caracteristica, Int32 id_componente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCaracteristicaComponente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_caracteristica", id_caracteristica);
            comando.Parameters.AddWithValue("@id_componente", id_componente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable RetornarCaracteristicas(Int32 id_tipo_componente)
        {
            DataTable tabla = new DataTable();

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RetornarCaracteristicasComponente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_tipo_componente", id_tipo_componente);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
