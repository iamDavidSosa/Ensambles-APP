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
    public partial class MantenimientoComponentes : Form
    {
        private string? Id_componente;
        public static string? id_componente_actual;
        public static string? Id_tipo_componente;
        CN_Componentes componentes = new CN_Componentes();
        public MantenimientoComponentes()
        {
            InitializeComponent();
        }

        private void MantenimientoComponentes_Load_1(object sender, EventArgs e)
        {
            MostrarComponentes();
            MostrarCaracteristicas("0");
            LlenarTipos();
            LlenarMarcas();
        }

        private void MostrarComponentes()
        {
            try
            {
                dgvComponentes.DataSource = componentes.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los componentes: " + ex.Message);
            }
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

        private void LlenarTipos()
        {
            try
            {
                cbTipoComponente.DataSource = componentes.RetornarTipos();
                cbTipoComponente.DisplayMember = "nombre";
                cbTipoComponente.ValueMember = "id_tipo_componente";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar los tipos de componentes: " + ex.Message);
            }
        }

        private void LlenarMarcas()
        {
            try
            {
                cbMarca.DataSource = componentes.RetornarMarcas();
                cbMarca.DisplayMember = "marca";
                cbMarca.ValueMember = "id_marca";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar las marcas: " + ex.Message);
            }
        }

        private void BuscarComponente(string id)
        {
            try
            {
                CN_Componentes objetoBusqueda = new();
                DataTable tabla = new();
                tabla = objetoBusqueda.RetornarComponente(id);
                Id_componente = tabla.Rows[0]["id_componente"].ToString();
                id_componente_actual = Id_componente;
                cbTipoComponente.SelectedValue = tabla.Rows[0]["id_tipo_componente"].ToString();
                Id_tipo_componente = cbTipoComponente.SelectedValue.ToString();
                cbMarca.SelectedValue = tabla.Rows[0]["id_marca"].ToString();
                txtModelo.Text = tabla.Rows[0]["modelo"].ToString();
                txtDescripcion.Text = tabla.Rows[0]["descripcion"].ToString();
                txtPrecio.Text = tabla.Rows[0]["precio_venta"].ToString();
                txtCantidad.Text = tabla.Rows[0]["cantidad"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el componente: " + ex.Message);
            }
        }

        private void dgvComponentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvComponentes.SelectedCells.Count > 0)
            {
                string? ID = dgvComponentes.CurrentRow.Cells["ID"].Value.ToString();
                BuscarComponente(ID);
                MostrarCaracteristicas(ID);
            }
        }

        private void Limpiar()
        {
            Id_componente = null;
            txtModelo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text == "" || txtDescripcion.Text == "" || txtPrecio.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                try
                {
                    if (Id_componente == null)
                    {
                        componentes.Insertar("0", cbTipoComponente.SelectedValue.ToString(), cbMarca.SelectedValue.ToString(), txtModelo.Text, txtDescripcion.Text, Convert.ToSingle(txtPrecio.Text), txtCantidad.Text, "1");
                    }
                    else
                    {
                        componentes.Insertar(Id_componente, cbTipoComponente.SelectedValue.ToString(), cbMarca.SelectedValue.ToString(), txtModelo.Text, txtDescripcion.Text, Convert.ToSingle(txtPrecio.Text), txtCantidad.Text, "1");
                    }
                    Limpiar();
                    MostrarComponentes();
                }
                catch (Exception ex)
                {
                    
                }
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Id_componente != null)
                {
                    if (MessageBox.Show("¿Estás seguro que deseas eliminar el componente?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        componentes.Eliminar(Id_componente);
                        Limpiar();
                        MostrarComponentes();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un componente para eliminar");
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void pbCaracteristicas_Click(object sender, EventArgs e)
        {
            Formularios.MantenimientoCaracteristicasComponentes caracteristicas = new();
            caracteristicas.ShowDialog();
            MostrarCaracteristicas(id_componente_actual);
        }

        private void pbMarcas_Click(object sender, EventArgs e)
        {
            Formularios.MantenimientoMarcas marcas = new();
            marcas.ShowDialog();
            LlenarMarcas();
        }

        private void pbTiposComponentes_Click(object sender, EventArgs e)
        {
            Formularios.MantenimientoTiposComponentes tipos = new();
            tipos.ShowDialog();
            LlenarTipos();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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
