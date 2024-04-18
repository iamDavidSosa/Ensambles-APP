using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Componentes
    {
        public DataTable Mostrar()
        {
            CD_Componentes componentes = new CD_Componentes();
            return componentes.Mostrar();
        }

        public void Insertar(string id_componente, string id_tipo_componente, string id_marca, string modelo, string descripcion, float precio_venta, string cantidad, string estado)
        {
            if (id_componente == "")
            {
                id_componente = "0";
            }
            CD_Componentes componentes = new CD_Componentes();
            componentes.Insertar(Convert.ToInt32(id_componente), Convert.ToInt32(id_tipo_componente), Convert.ToInt32(id_marca), modelo, descripcion, Convert.ToSingle(precio_venta), Convert.ToInt32(cantidad), Convert.ToInt32(estado));
        }

        public void Eliminar(string id_componente)
        {
            CD_Componentes componentes = new CD_Componentes();
            componentes.Eliminar(Convert.ToInt32(id_componente));
        }

        public DataTable RetornarComponente(string id_componente)
        {
            CD_Componentes componentes = new CD_Componentes();
            DataTable tabla = componentes.RetornarComponente(Convert.ToInt32(id_componente));
            return tabla;
        }

        public DataTable RetornarTipos()
        {
            CD_Componentes componentes = new CD_Componentes();
            DataTable tabla = componentes.RetornarTipos();
            return tabla;
        }

        public DataTable RetornarMarcas()
        {
            CD_Componentes componentes = new CD_Componentes();
            DataTable tabla = componentes.RetornarMarcas();
            return tabla;
        }

        public DataTable RetornarComponenteCompatible(string id_componente, string id_componente_siguiente, string id_tipo_ensamble)
        {
            CD_Componentes componentes = new CD_Componentes();
            DataTable tabla = componentes.RetornarComponenteCompatible(Convert.ToInt32(id_componente), Convert.ToInt32(id_componente_siguiente), Convert.ToInt32(id_tipo_ensamble));
            return tabla;
        }

        public DataTable RetornarComponenteInicial(string id_tipo_componente)
        {
            CD_Componentes componentes = new CD_Componentes();
            DataTable tabla = componentes.RetornarComponenteInicial(Convert.ToInt32(id_tipo_componente));
            return tabla;
        }

        public DataTable RetornarTiposEnsambles()
        {
            CD_Componentes componentes = new CD_Componentes();
            DataTable tabla = componentes.RetornarTiposEnsambles();
            return tabla;
        }



    }
}
