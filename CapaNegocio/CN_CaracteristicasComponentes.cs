using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_CaracteristicasComponentes
    {
        private CD_CaracteristicasComponentes caracteristicasComponentes = new();

        public DataTable Mostrar(string id_componente)
        {
            DataTable tabla = new();
            tabla = caracteristicasComponentes.Mostrar(Convert.ToInt32(id_componente));
            return tabla;
        }

        public void Insertar(string id_caracteristica, string id_componente, string valor)
        {
            caracteristicasComponentes.Insertar(Convert.ToInt32(id_caracteristica), Convert.ToInt32(id_componente), valor);
        }

        public void Eliminar(string id_caracteristica, string id_componente)
        {
            caracteristicasComponentes.Eliminar(Convert.ToInt32(id_caracteristica), Convert.ToInt32(id_componente));
        }

        public DataTable RetornarCaracteristicas(string id_tipo_componente)
        {
            DataTable tabla = new DataTable();
            tabla = caracteristicasComponentes.RetornarCaracteristicas(Convert.ToInt32(id_tipo_componente));
            return tabla;
        }
    }
}
