using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_CriteriosDeBusqueda
    {
        private CD_Conexion conexion = new();
        private SqlDataReader leer;
        private SqlCommand comando = new();
        DataTable tabla = new();

        public DataTable MostrarCriterios(Int32 id_tipo_ensamble)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCriteriosDeBusqueda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_tipo_ensamble", id_tipo_ensamble);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            leer.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public void ActualizarCriterioBusqueda(Int32 id_tipo_ensamble, Int32 id_caracteristica, string valor_desde, string valor_hasta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizaCriterioBusqueda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_tipo_ensamble", id_tipo_ensamble);
            comando.Parameters.AddWithValue("@id_caracteristica", id_caracteristica);
            comando.Parameters.AddWithValue("@valor_desde", valor_desde);
            comando.Parameters.AddWithValue("@valor_hasta", valor_hasta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(Int32 id_tipo_ensamble, Int32 id_caracteristica)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminaCriterioBusqueda";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_tipo_ensamble", id_tipo_ensamble);
            comando.Parameters.AddWithValue("@id_caracteristica", id_caracteristica);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
