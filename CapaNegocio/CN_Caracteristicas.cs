using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Caracteristicas
    {
        private CD_Caracteristicas objetoCD = new CD_Caracteristicas();

        public DataTable MostrarCaracteristicas()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCaracteristicas();
            return tabla;
        }

        public void ActualizaCaracteristica(string id_caracteristica, string id_tipo_componente, string nombre, string descripcion)
        {
            if (id_caracteristica == string.Empty)
            {
                id_caracteristica = "0";
            }
            objetoCD.ActualizaCaracteristica(Convert.ToInt32(id_caracteristica),Convert.ToInt32(id_tipo_componente), nombre, descripcion);
        }

        public void EliminaCaracteristica(string id_caracteristica)
        {
            objetoCD.EliminaCaracteristica(Convert.ToInt32(id_caracteristica));
        }

        public DataTable RetornarCaracteristica(string id_caracteristica)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.RetornarCaracteristica(Convert.ToInt32(id_caracteristica));
            return tabla;
        }
    }
}
