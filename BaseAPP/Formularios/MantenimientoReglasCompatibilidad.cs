﻿using System;
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
    public partial class MantenimientoReglasCompatibilidad : Form
    {
        private string id_regla;
        CN_Componentes componentes = new CN_Componentes();
        public MantenimientoReglasCompatibilidad()
        {
            InitializeComponent();
        }

        private void MantenimientoReglasCompatibilidad_Load(object sender, EventArgs e)
        {
            LlenarTipos();
            RetornarCaracteristicas(cbTipo1.SelectedValue.ToString(), cbCaracteristica1);
            RetornarCaracteristicas(cbTipo2.SelectedValue.ToString(), cbCaracteristica2);
            MostrarReglas();
        }

        private void LlenarTipos()
        {
            try
            {
                cbTipo1.DataSource = componentes.RetornarTipos();
                cbTipo1.DisplayMember = "nombre";
                cbTipo1.ValueMember = "id_tipo_componente";
                cbTipo2.DataSource = componentes.RetornarTipos();
                cbTipo2.DisplayMember = "nombre";
                cbTipo2.ValueMember = "id_tipo_componente";
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al llenar los tipos de componentes: " + ex.Message);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Reglas objeto = new();
                objeto.Insertar(id_regla, cbCaracteristica1.SelectedValue.ToString(), txtValor1.Text, cbOperador.Text, cbCaracteristica2.SelectedValue.ToString(), txtValor2.Text);
                MessageBox.Show("Regla guardada correctamente");
                MostrarReglas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la regla: " + ex.Message);
            }
        }

        private void MostrarReglas()
        {
            try
            {
                CN_Reglas objeto = new();
                dgvReglas.DataSource = objeto.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar las reglas: " + ex.Message);
            }
        }

        private void cbTipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetornarCaracteristicas(cbTipo1.SelectedValue.ToString(), cbCaracteristica1);
        }

        private void cbTipo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RetornarCaracteristicas(cbTipo2.SelectedValue.ToString(), cbCaracteristica2);
        }

        private void dgvReglas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_regla = dgvReglas.CurrentRow.Cells["Id"].Value.ToString();
            CN_Reglas objeto = new();
            DataTable tabla = new();
            tabla = objeto.RetornarRegla(id_regla);
            cbTipo1.SelectedValue = tabla.Rows[0]["id_tipo_1"].ToString();
            cbCaracteristica1.SelectedValue = tabla.Rows[0]["id_caracteristica_1"].ToString();
            txtValor1.Text = tabla.Rows[0]["valor_1"].ToString();
            cbOperador.Text = tabla.Rows[0]["operador"].ToString();
            cbTipo2.SelectedValue = tabla.Rows[0]["id_tipo_2"].ToString();
            cbCaracteristica2.SelectedValue = tabla.Rows[0]["id_caracteristica_2"].ToString();
            txtValor2.Text = tabla.Rows[0]["valor_2"].ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Reglas objeto = new();
                objeto.Eliminar(id_regla);
                MessageBox.Show("Regla eliminada correctamente");
                MostrarReglas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la regla: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            id_regla = null;
            cbTipo1.SelectedIndex = 0;
            cbCaracteristica1.SelectedIndex = 0;
            txtValor1.Text = "";
            cbOperador.SelectedIndex = 0;
            cbTipo2.SelectedIndex = 0;
            cbCaracteristica2.SelectedIndex = 0;
            txtValor2.Text = "";
        }
    }
}
