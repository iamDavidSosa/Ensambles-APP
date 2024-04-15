using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseAPP.Formularios
{
    public partial class MantenimientoCaracteristicasComponentes : Form
    {
        public MantenimientoCaracteristicasComponentes()
        {
            InitializeComponent();
        }

        private void MantenimientoCaracteristicasComponentes_Load(object sender, EventArgs e)
        {
            MostrarCaracteristicas(Formularios.MantenimientoComponentes.id_componente_actual);
            RetornarCaracteristicas(Formularios.MantenimientoComponentes.Id_tipo_componente);
        }
        private void MostrarCaracteristicas(string id_componente)
        {
            try
            {
                CN_CaracteristicasComponentes objetoBusqueda = new();
                DataTable tabla = new();
                tabla = objetoBusqueda.Mostrar(id_componente);
                dgvCaracteristicas.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar las características: " + ex.Message);
            }
        }

        private void RetornarCaracteristicas(string id_tipo_componente)
        {
            try
            {
                CN_CaracteristicasComponentes objetoBusqueda = new();
                DataTable tabla = new();
                tabla = objetoBusqueda.RetornarCaracteristicas(id_tipo_componente);
                cbCaracteristicas.DataSource = tabla;
                cbCaracteristicas.DisplayMember = "nombre";
                cbCaracteristicas.ValueMember = "id_caracteristica";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar las características: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCaracteristica();
        }

        private void GuardarCaracteristica()
        {
            try
            {
                CN_CaracteristicasComponentes objeto = new();
                objeto.Insertar(cbCaracteristicas.SelectedValue.ToString(), Formularios.MantenimientoComponentes.id_componente_actual, txtValor.Text);
                MostrarCaracteristicas(Formularios.MantenimientoComponentes.id_componente_actual);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la característica: " + ex.Message);
            }
        }

        private void EliminarCaracteristica()
        {
            try
            {
                CN_CaracteristicasComponentes objeto = new();
                objeto.Eliminar(cbCaracteristicas.SelectedValue.ToString(), Formularios.MantenimientoComponentes.id_componente_actual);
                MostrarCaracteristicas(Formularios.MantenimientoComponentes.id_componente_actual);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la característica: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtValor.Text = "";
            cbCaracteristicas.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar la característica?", "Eliminar característica", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EliminarCaracteristica();
            }
            else
            {
                Limpiar();
            }

        }

        private void dgvCaracteristicas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCaracteristicas.SelectedCells.Count > 0)
            {
                try
                {
                    cbCaracteristicas.Text = dgvCaracteristicas.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtValor.Text = dgvCaracteristicas.CurrentRow.Cells["Valor"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar la característica: " + ex.Message);
                }

            }
        }

        private void pbCaracteristica_Click(object sender, EventArgs e)
        {
            Formularios.MantenimientoCaracteristicas mantenimientoCaracteristicas = new();
            mantenimientoCaracteristicas.ShowDialog();
            RetornarCaracteristicas(Formularios.MantenimientoComponentes.Id_tipo_componente);          
        }
    }
}
