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
    public partial class MantenimientoCriteriosDeBusqueda : Form
    {
        public MantenimientoCriteriosDeBusqueda()
        {
            InitializeComponent();
        }

        private void MantenimientoTiposDeEnsambles_Load(object sender, EventArgs e)
        {
            LlenarTipos();
            LlenarTiposEnsambles();
            RetornarCaracteristicas(cbTipo1.SelectedValue.ToString(), cbCaracteristica1);
            MostrarCriterios();
        }

        private void LlenarTipos()
        {
            try
            {
                CN_Componentes componentes = new CN_Componentes();
                cbTipo1.DataSource = componentes.RetornarTipos();
                cbTipo1.DisplayMember = "nombre";
                cbTipo1.ValueMember = "id_tipo_componente";
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al llenar los tipos de componentes: " + ex.Message);
            }
        }

        private void MostrarCriterios()
        {
            try
            {
                CN_CriteriosDeBusqueda criterios = new CN_CriteriosDeBusqueda();
                DataTable tabla = criterios.MostrarCriterios(cbTipoUso.SelectedValue.ToString());
                dgvCriterios.DataSource = tabla;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al mostrar los criterios: " + ex.Message);
            }
        }

        private void LlenarTiposEnsambles()
        {
            try
            {
                CN_Componentes componentes = new();
                DataTable tabla = componentes.RetornarTiposEnsambles();
                if (tabla.Rows.Count > 0)
                {
                    DataRow row = tabla.Rows[0];
                    cbTipoUso.DataSource = tabla;
                    cbTipoUso.DisplayMember = "Tipo";
                    cbTipoUso.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de componentes: " + ex.Message);
            }
        }

        private void RetornarCaracteristicas(string id_tipo_componente, ComboBox cbCaracteristicas)
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
                //MessageBox.Show("Error al mostrar las características: " + ex.Message);
            }
        }

        private void ActualizarCriterioBusqueda()
        {
            try
            {
                CN_CriteriosDeBusqueda criterios = new();
                criterios.ActualizarCriterioBusqueda(cbTipoUso.SelectedValue.ToString(), cbCaracteristica1.SelectedValue.ToString(), txtDesde.Text, txtHasta.Text);
                MostrarCriterios();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el criterio de búsqueda: " + ex.Message);
            }
        }

        private void EliminarCriterioBusqueda()
        {
            try
            {
                CN_CriteriosDeBusqueda criterios = new();
                criterios.Eliminar(cbTipoUso.SelectedValue.ToString(), cbCaracteristica1.SelectedValue.ToString());
                MostrarCriterios();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el criterio de búsqueda: " + ex.Message);
            }
        }

        private void cbTipoUso_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarCriterios();
        }

        private void cbTipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetornarCaracteristicas(cbTipo1.SelectedValue.ToString(), cbCaracteristica1);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarCriterioBusqueda();
        }

        private void Limpiar()
        {
            txtDesde.Text = "";
            txtHasta.Text = "";
            cbCaracteristica1.SelectedIndex = 0;
            cbTipo1.SelectedIndex = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCriterioBusqueda();
        }

        private void dgvCriterios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvCriterios.Rows[e.RowIndex];
                    cbTipoUso.SelectedValue = row.Cells["IDe"].Value.ToString();
                    cbTipo1.SelectedValue = row.Cells["IDt"].Value.ToString();
                    cbCaracteristica1.SelectedValue = row.Cells["IDc"].Value.ToString();
                    txtDesde.Text = row.Cells["Desde"].Value.ToString();
                    txtHasta.Text = row.Cells["Hasta"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar el criterio de búsqueda: " + ex.Message);
                }

            }

        }

        private void pbTiposEnsambles_Click(object sender, EventArgs e)
        {
            MantenimientoTipoEnsamble mantenimientoTipoEnsamble = new();
            mantenimientoTipoEnsamble.ShowDialog();
            LlenarTiposEnsambles();
        }

        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
