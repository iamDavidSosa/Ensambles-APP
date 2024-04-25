using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace BaseAPP.Formularios
{
    public partial class VistaEnsamblesGenerados : Form
    {
        public VistaEnsamblesGenerados()
        {
            InitializeComponent();
        }

        private void VistaEnsamblesGenerados_Load(object sender, EventArgs e)
        {
            MostrarEnsambles();
        }

        private void MostrarEnsambles()
        {
            try
            {
                CN_Ensambles ensambles = new CN_Ensambles();
                DataTable tabla = ensambles.Mostrar();
                dgvEnsambles.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los ensambles: " + ex.Message);
            }
        }
    }
}
