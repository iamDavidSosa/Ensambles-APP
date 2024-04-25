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
    public partial class MantenimientoTipoEnsamble : Form
    {
        string id_tipo_ensamble = "0";
        CN_Ensambles objetoCN = new CN_Ensambles();
        public MantenimientoTipoEnsamble()
        {
            InitializeComponent();
        }

        public void MostrarTipoEnsamble()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCN.MostrarTipoEnsamble();
            dgvEnsambles.DataSource = tabla;
        }

        private void MantenimientoTipoEnsamble_Load(object sender, EventArgs e)
        {
            MostrarTipoEnsamble();
        }

        public void InsertarTipoEnsamble()
        {
            try
            {
                objetoCN.InsertarTipoEnsamble(id_tipo_ensamble, txtTipoEnsamble.Text, txtDescripcion.Text);
                MostrarTipoEnsamble();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede insertar el registro, ya que se encuentra en uso");
            }
        }
        public void EliminarTipoEnsamble()
        {
            try
            {
                objetoCN.EliminaTipoEnsamble(id_tipo_ensamble);
                MostrarTipoEnsamble();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar el registro, ya que se encuentra en uso");
            }
        }

        public void Limpiar()
        {
            id_tipo_ensamble = "0";
            txtTipoEnsamble.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarTipoEnsamble();
            MessageBox.Show("Registro insertado correctamente");
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarTipoEnsamble();
            MessageBox.Show("Registro eliminado correctamente");
            Limpiar();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dgvEnsambles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_tipo_ensamble = dgvEnsambles.CurrentRow.Cells["Id"].Value.ToString();
            txtTipoEnsamble.Text = dgvEnsambles.CurrentRow.Cells["Tipo"].Value.ToString();
            txtDescripcion.Text = dgvEnsambles.CurrentRow.Cells["Descripcion"].Value.ToString();

        }
    }
}
