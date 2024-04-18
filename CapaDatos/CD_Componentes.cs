using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

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

        public DataTable RetornarComponenteCompatible(Int32 id_componente, Int32 id_componente_siguiente, Int32 id_tipo_ensamble)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RetornarComponenteFiltrado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_componente_actual", id_componente);
            comando.Parameters.AddWithValue("@id_componente_siguiente", id_componente_siguiente);
            comando.Parameters.AddWithValue("@id_tipo_ensamble", id_tipo_ensamble);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable RetornarComponenteInicial(Int32 id_tipo_componente)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RetornarComponenteInicial";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_tipo_componente", id_tipo_componente);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable RetornarTiposEnsambles()
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RetornarTiposEnsambles";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
            
        }

        public DataTable RetornarPrecioEnsamble(Int32 id_motherboard, Int32 id_procesador, Int32 id_memoria_ram, Int32 id_memoria_rom, Int32 id_tarjeta_grafica, Int32 id_case, Int32 id_fuente)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RetornarPrecioEnsamble";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_motherboard", id_motherboard);
            comando.Parameters.AddWithValue("@id_procesador", id_procesador);
            comando.Parameters.AddWithValue("@id_memoria_ram", id_memoria_ram);
            comando.Parameters.AddWithValue("@id_memoria_rom", id_memoria_rom);
            comando.Parameters.AddWithValue("@id_tarjeta_grafica", id_tarjeta_grafica);
            comando.Parameters.AddWithValue("@id_case", id_case);
            comando.Parameters.AddWithValue("@id_fuente", id_fuente);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable RetornarDatosComponentes(Int32 id_componente)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RetornarDatosComponentes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_componente", id_componente);
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
