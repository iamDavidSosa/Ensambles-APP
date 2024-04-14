using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_TiposComponentes
    {
        private CD_TiposComponentes objetoCD = new CD_TiposComponentes();

        public DataTable MostrarTiposComponentes()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarTiposComponentes();
            return tabla;
        }

        public void ActualizaTipoComponente(string id_tipo_componente, string nombre, string descripcion)
        {
            if (id_tipo_componente == string.Empty)
            {
                id_tipo_componente = "0";
            }
            objetoCD.ActualizaTipoComponente(Convert.ToInt32(id_tipo_componente), nombre, descripcion);
        }

        public void EliminaTipoComponente(string id_tipo_componente)
        {
            objetoCD.EliminaTipoComponente(Convert.ToInt32(id_tipo_componente));
        }

        public DataTable RetornarTipoComponente(string id_tipo_componente)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.RetornarTipoComponente(Convert.ToInt32(id_tipo_componente));
            return tabla;
        }
    }
}
