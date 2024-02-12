using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Data Source=(local);Initial Catalog=ventas_soporte_db;Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
