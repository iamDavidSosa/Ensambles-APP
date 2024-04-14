using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public  class CN_Marcas
    {
        private CD_Marcas objetoCD = new CD_Marcas();

        public DataTable MostrarMarcas()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarMarcas();
            return tabla;
        }

        public void ActualizaMarca(string id_marca, string marca, string descripcion)
        {
            if (id_marca == string.Empty)
            {
                id_marca = "0";
            }
            objetoCD.ActualizaMarca(Convert.ToInt32(id_marca), marca, descripcion);
        }

        public void EliminaMarca(string id_marca)
        {
            objetoCD.EliminaMarca(Convert.ToInt32(id_marca));
        }

        public DataTable RetornarMarca(string id_marca)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.RetornarMarca(Convert.ToInt32(id_marca));
            return tabla;
        }
    }
}
