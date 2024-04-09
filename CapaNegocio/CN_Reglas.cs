using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Reglas
    {
        private CD_Reglas objeto = new CD_Reglas();
        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = objeto.Mostrar();
            return tabla;
        }

        public void Insertar(string id_regla, string id_caracteristica_1, string valor_1, string operador, string id_caracteristica_2, string valor_2)
        {
            if (id_regla == "")
            {
                id_regla = "0";
            }

            objeto.Insertar(Convert.ToInt32(id_regla), Convert.ToInt32(id_caracteristica_1), valor_1, operador, Convert.ToInt32(id_caracteristica_2), valor_2);
        }

        public void Eliminar(string id_regla)
        {
            objeto.Eliminar(Convert.ToInt32(id_regla));
        }
    }
}
