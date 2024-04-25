using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Ensambles
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlDataReader leer;
        private SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEnsamblesGenerados";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(Int32 id_motherboard, Int32 id_procesador, Int32 id_memoria_ram, Int32 id_memoria_rom, Int32 id_grafica, Int32 id_case, Int32 id_power_supply, double precio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "AgregarEnsamble";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_motherboard", id_motherboard);
            comando.Parameters.AddWithValue("@id_procesador", id_procesador);
            comando.Parameters.AddWithValue("@id_memoria_ram", id_memoria_ram);
            comando.Parameters.AddWithValue("@id_memoria_rom", id_memoria_rom);
            comando.Parameters.AddWithValue("@id_grafica", id_grafica);
            comando.Parameters.AddWithValue("@id_case", id_case);
            comando.Parameters.AddWithValue("@id_power_supply", id_power_supply);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void LimpiarTablaTemporal()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "LimpiarTablaTemporal";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable ContarEnsambles()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ContarEnsambles";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarTipoEnsamble(Int32 id_tipo_ensamble, string tipo_ensamble, string descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizaTipoEnsamble";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_tipo_ensamble", id_tipo_ensamble);
            comando.Parameters.AddWithValue("@tipo_ensamble", tipo_ensamble);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EliminaTipoEnsamble(Int32 id_tipo_ensamble)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminaTipoEnsamble";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_tipo_ensamble", id_tipo_ensamble);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable MostrarTipoEnsamble()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarTipoEnsamble";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
