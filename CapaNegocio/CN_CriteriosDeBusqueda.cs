using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_CriteriosDeBusqueda
    {
        
        public DataTable MostrarCriterios(string id_tipo_ensamble)
        {
            CD_CriteriosDeBusqueda criterios = new CD_CriteriosDeBusqueda();
            return criterios.MostrarCriterios(Convert.ToInt32(id_tipo_ensamble));
        }
        public void ActualizarCriterioBusqueda(string id_tipo_ensamble, string id_caracteristica, string valor_desde, string valor_hasta)
        {
            CD_CriteriosDeBusqueda criterios = new CD_CriteriosDeBusqueda();
            criterios.ActualizarCriterioBusqueda(Convert.ToInt32(id_tipo_ensamble), Convert.ToInt32(id_caracteristica), valor_desde, valor_hasta);
        }

        public void Eliminar(string id_tipo_ensamble, string id_caracteristica)
        {
            CD_CriteriosDeBusqueda criterios = new CD_CriteriosDeBusqueda();
            criterios.Eliminar(Convert.ToInt32(id_tipo_ensamble), Convert.ToInt32(id_caracteristica));
        }
    }
}
