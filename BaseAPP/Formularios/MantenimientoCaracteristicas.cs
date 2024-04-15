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
    public partial class MantenimientoCaracteristicas : Form
    {
        private string id_caracteristica = null;
        public MantenimientoCaracteristicas()
        {
            InitializeComponent();
        }

        private void MantenimientoCaracteristicas_Load(object sender, EventArgs e)
        {
            MostrarCaracteristicas();
            LlenarTipos();
        }

        private void MostrarCaracteristicas()
        {
            try
            {
                CN_Caracteristicas objeto = new();
                dgvCaracteristicas.DataSource = objeto.MostrarCaracteristicas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar las características: " + ex.Message);
            }
        }

        private void LlenarTipos()
        {
            try
            {
                CN_Componentes componentes = new();
                cbTipoComponente.DataSource = componentes.RetornarTipos();
                cbTipoComponente.DisplayMember = "nombre";
                cbTipoComponente.ValueMember = "id_tipo_componente";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar los tipos de componentes: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCaracteristica(id_caracteristica, cbTipoComponente.SelectedValue.ToString(), txtNombre.Text, txtDescripcion.Text);
        }

        private void GuardarCaracteristica(string id_caracteristica, string id_tipo_componente, string nombre, string descripcion)
        {
            try
            {
                CN_Caracteristicas objetoCN = new();
                objetoCN.ActualizaCaracteristica(id_caracteristica, id_tipo_componente, nombre, descripcion);
                MessageBox.Show("Característica guardada correctamente");
                MostrarCaracteristicas();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la característica: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            id_caracteristica = null;
            cbTipoComponente.SelectedIndex = -1;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void EliminarCaracteristica(string id_caracteristica)
        {
            try
            {
                CN_Caracteristicas objetoCN = new();
                objetoCN.EliminaCaracteristica(id_caracteristica);
                MessageBox.Show("Característica eliminada correctamente");
                MostrarCaracteristicas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la característica: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCaracteristica(id_caracteristica);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void RetornarCaracteristica(string id_caracteristica)
        {
            try
            {
                CN_Caracteristicas objetoCN = new();
                DataTable tabla = new();
                tabla = objetoCN.RetornarCaracteristica(id_caracteristica);
                cbTipoComponente.SelectedValue = tabla.Rows[0]["id_tipo"].ToString();
                txtNombre.Text = tabla.Rows[0]["nombre"].ToString();
                txtDescripcion.Text = tabla.Rows[0]["descripcion"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al retornar la característica: " + ex.Message);
            }
        }

        private void dgvCaracteristicas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_caracteristica = dgvCaracteristicas.CurrentRow.Cells["Id"].Value.ToString();
            RetornarCaracteristica(id_caracteristica);
        }
    }
}
