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
    public partial class MantenimientoMarcas : Form
    {
        
        string id_marca = null;
        public MantenimientoMarcas()
        {
            InitializeComponent();
        }

        private void MantenimientoMarcas_Load(object sender, EventArgs e)
        {
            MostrarMarcas();
        }

        private void MostrarMarcas()
        {
            try
            {
                CN_Marcas objeto = new();
                dgvMarcas.DataSource = objeto.MostrarMarcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar las marcas: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarMarca(id_marca, txtMarca.Text, txtDescripcion.Text);
        }

        private void GuardarMarca(string id_marca, string marca, string descripcion)
        {
            try
            {
                CN_Marcas objetoCN = new();
                objetoCN.ActualizaMarca(id_marca, marca, descripcion);
                MessageBox.Show("Marca guardada correctamente");
                MostrarMarcas();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la marca: " + ex.Message);
            }

        }

        private void EliminarMarca(string id_marca)
        {
            try
            {
                CN_Marcas objetoCN = new();
                objetoCN.EliminaMarca(id_marca);
                MessageBox.Show("Marca eliminada correctamente");
                MostrarMarcas();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la marca: " + ex.Message);
            }
        }

        private void RetornarMarca(string id_marca)
        {
            try
            {
                CN_Marcas objetoCN = new();
                DataTable tabla = new();
                tabla = objetoCN.RetornarMarca(id_marca);
                txtMarca.Text = tabla.Rows[0]["marca"].ToString();
                txtDescripcion.Text = tabla.Rows[0]["descripcion"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al retornar la marca: " + ex.Message);
            }
        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_marca = dgvMarcas.CurrentRow.Cells["Id"].Value.ToString();
            RetornarMarca(id_marca);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarMarca(id_marca);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            id_marca = null;
            txtMarca.Text = "";
            txtDescripcion.Text = "";
        }
    }
}
