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
    public partial class MantenimientoTiposComponentes : Form
    {
        string id_tipo_componente = null;
        public MantenimientoTiposComponentes()
        {
            InitializeComponent();
        }

        private void MantenimientoTiposComponentes_Load(object sender, EventArgs e)
        {
            MostrarTiposComponentes();
        }

        private void MostrarTiposComponentes()
        {
            try
            {
                CN_TiposComponentes objeto = new();
                dgvTipos.DataSource = objeto.MostrarTiposComponentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los tipos de componentes: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarTipoComponente(id_tipo_componente, txtNombre.Text, txtDescripcion.Text);
        }

        private void GuardarTipoComponente(string id_tipo_componente, string nombre, string descripcion)
        {
            try
            {
                CN_TiposComponentes objetoCN = new();
                objetoCN.ActualizaTipoComponente(id_tipo_componente, nombre, descripcion);
                MessageBox.Show("Tipo de componente guardado correctamente");
                MostrarTiposComponentes();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el tipo de componente: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            id_tipo_componente = null;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void EliminarTipoComponente(string id_tipo_componente)
        {
            try
            {
                CN_TiposComponentes objetoCN = new();
                objetoCN.EliminaTipoComponente(id_tipo_componente);
                MessageBox.Show("Tipo de componente eliminado correctamente");
                MostrarTiposComponentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el tipo de componente: " + ex.Message);
            }
        }

        private void RetornarTipoComponente(string id_tipo_componente)
        {
            try
            {
                CN_TiposComponentes objetoCN = new();
                DataTable tabla = new();
                tabla = objetoCN.RetornarTipoComponente(id_tipo_componente);
                txtNombre.Text = tabla.Rows[0]["nombre"].ToString();
                txtDescripcion.Text = tabla.Rows[0]["descripcion"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al retornar el tipo de componente: " + ex.Message);
            }
        }

        private void dgvTipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_tipo_componente = dgvTipos.CurrentRow.Cells["Id"].Value.ToString();
            RetornarTipoComponente(id_tipo_componente);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarTipoComponente(id_tipo_componente);
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
