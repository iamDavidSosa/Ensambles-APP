using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Ensambles
    {
        private CD_Ensambles objetoCD = new CD_Ensambles();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void Insertar(string id_motherboard, string id_procesador, string id_memoria_ram, string id_memoria_rom, string id_grafica, string id_case, string id_power_supply, string precio)
        {
            objetoCD.Insertar(Convert.ToInt32(id_motherboard), Convert.ToInt32(id_procesador), Convert.ToInt32(id_memoria_ram), Convert.ToInt32(id_memoria_rom), Convert.ToInt32(id_grafica), Convert.ToInt32(id_case), Convert.ToInt32(id_power_supply), Convert.ToDouble(precio));
        }

        public void LimpiarTablaTemporal()
        {
            objetoCD.LimpiarTablaTemporal();
        }

        public DataTable ContarEnsambles()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ContarEnsambles();
            return tabla;
        }

        public void InsertarTipoEnsamble(string id_tipo_ensamble, string tipo_ensamble, string descripcion)
        {
            if(id_tipo_ensamble == "")
            {
                id_tipo_ensamble = "0";
            }   
            objetoCD.InsertarTipoEnsamble(Convert.ToInt32(id_tipo_ensamble), tipo_ensamble, descripcion);
        }

        public DataTable MostrarTipoEnsamble()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarTipoEnsamble();
            return tabla;
        }

        public void EliminaTipoEnsamble(string id_tipo_ensamble)
        {
            if (id_tipo_ensamble == "")
            {
                id_tipo_ensamble = "0";
            }
            objetoCD.EliminaTipoEnsamble(Convert.ToInt32(id_tipo_ensamble));
        }

    }
}
