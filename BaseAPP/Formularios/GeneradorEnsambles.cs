using CapaDatos;
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
    public partial class GeneradorEnsambles : Form
    {
        //private int[,] componentes_elegidos = new int[7, 2];

        private class Componente
        {
            public int IdComponente { get; set; }
            public int IdTipoComponente { get; set; }
        }

        private class Ensamble
        {
            public int IdEnsamble { get; set; }
            public int IdComponente { get; set; }

        }

        List<Componente> listaMotherboard, listaProcesadores, listaMemoriasRAM = new();
        List<Componente> listaROM = new();
        List<Componente> listaTarjetaGrafica = new();

        public GeneradorEnsambles()
        {
            InitializeComponent();
        }

        private void cbEspecificar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEspecificar.Checked)
            {
                gbComponentes.Enabled = true;
            }
            else
            {
                gbComponentes.Enabled = false;
            }
        }

        private void GeneradorEnsambles_Load(object sender, EventArgs e)
        {
            LlenarTiposEnsambles();
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
                    cbTipoEnsamble.DataSource = tabla;
                    cbTipoEnsamble.DisplayMember = "Tipo";
                    cbTipoEnsamble.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de componentes: " + ex.Message);
            }
        }


        private void BuscarComponenteCompatible(string id_componente, string id_componente_siguiente)
        {
            if (listaMotherboard == null)
            {
                CN_Componentes componentes = new();
                DataTable tabla = componentes.RetornarComponenteInicial(id_componente);
                if (tabla.Rows.Count > 0)
                {
                    DataRow row = tabla.Rows[0];
                    listaMotherboard = tabla.AsEnumerable()
                    .Select(row => new Componente
                    {
                        IdComponente = row.Field<int>("id_componente"),
                        IdTipoComponente = row.Field<int>("id_tipo_componente")
                    })
                    .ToList();

                    foreach (Componente componente in listaMotherboard)
                    {
                        BuscarComponenteCompatible(componente.IdComponente.ToString(), componente.IdTipoComponente.ToString());
                    }
                }
            }
            else
            {

            }
        }

        private void ArmarEnsamble()
        {
            try
            {
                LlenarListaMotherBoard();
                int contador = 0;
                string id_tipo_ensamble = cbTipoEnsamble.SelectedValue.ToString();
                foreach (Componente componente in listaMotherboard)
                {
                    LlenarListaProcesadores(componente.IdComponente.ToString(), "1", id_tipo_ensamble);
                    LlenarListaMemoriasRAM(componente.IdComponente.ToString(), "3", id_tipo_ensamble);
                    LlenarListaROM(componente.IdComponente.ToString(), "4", id_tipo_ensamble);
                    LlenarListaTarjetaGrafica(componente.IdComponente.ToString(), "2", id_tipo_ensamble);

                    if (listaProcesadores.Count == 0)
                    {
                        MessageBox.Show("No hay procesadores compatibles con la motherboard: " + componente.IdComponente);
                    }
                    else
                    {
                        foreach (Componente procesador in listaProcesadores)
                        {
                            if (listaMemoriasRAM.Count == 0)
                            {
                                MessageBox.Show("No hay memorias RAM compatibles con la motherboard: " + componente.IdComponente);
                            }
                            else
                            {
                                foreach (Componente memoriaRAM in listaMemoriasRAM)
                                {
                                    if (listaROM.Count == 0)
                                    {
                                        MessageBox.Show("No hay ROM compatibles con la motherboard: " + componente.IdComponente);
                                    }
                                    else
                                    {
                                        foreach (Componente rom in listaROM)
                                        {
                                            if (listaTarjetaGrafica.Count == 0)
                                            {
                                                MessageBox.Show("No hay tarjetas graficas compatibles con la motherboard: " + componente.IdComponente);
                                            }
                                            else
                                            {
                                                foreach (Componente tarjetaGrafica in listaTarjetaGrafica)
                                                {
                                                    contador++;
                                                    MessageBox.Show("Motherboard: " + componente.IdComponente + " Procesador: " + procesador.IdComponente + " Memoria RAM: " + memoriaRAM.IdComponente + " ROM: " + rom.IdComponente + " Tarjeta Grafica: " + tarjetaGrafica.IdComponente);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los componentes: " + ex.Message);
            }

        }

        private void LlenarListaMotherBoard()
        {
            try
            {
                CN_Componentes componentes = new();
                DataTable tabla = componentes.RetornarComponenteInicial("7");
                if (tabla.Rows.Count > 0)
                {
                    DataRow row = tabla.Rows[0];
                    listaMotherboard = tabla.AsEnumerable()
                    .Select(row => new Componente
                    {
                        IdComponente = row.Field<int>("id_componente"),
                        IdTipoComponente = row.Field<int>("id_tipo_componente")
                    })
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los componentess: " + ex.Message);
            }
        }

        private void LlenarListaProcesadores(string id_componente, string id_componente_siguiente, string id_tipo_ensamble)
        {
            try
            {
                CN_Componentes componentes = new();
                DataTable tabla = componentes.RetornarComponenteCompatible(id_componente, id_componente_siguiente, id_tipo_ensamble);
                if (tabla.Rows.Count > 0)
                {
                    DataRow row = tabla.Rows[0];
                    listaProcesadores = tabla.AsEnumerable()
                    .Select(row => new Componente
                    {
                        IdComponente = row.Field<int>("id_componente"),
                        IdTipoComponente = row.Field<int>("id_tipo_componente")
                    })
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los componentes: " + ex.Message);
            }
        }

        private void LlenarListaMemoriasRAM(string id_componente, string id_componente_siguiente, string id_tipo_ensamble)
        {
            try
            {
                CN_Componentes componentes = new();
                DataTable tabla = componentes.RetornarComponenteCompatible(id_componente, id_componente_siguiente, id_tipo_ensamble);
                if (tabla.Rows.Count > 0)
                {
                    DataRow row = tabla.Rows[0];
                    listaMemoriasRAM = tabla.AsEnumerable()
                    .Select(row => new Componente
                    {
                        IdComponente = row.Field<int>("id_componente"),
                        IdTipoComponente = row.Field<int>("id_tipo_componente")
                    })
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los componentes: " + ex.Message);
            }
        }

        private void LlenarListaROM(string id_componente, string id_componente_siguiente, string id_tipo_ensamble)
        {
            try
            {
                CN_Componentes componentes = new();
                DataTable tabla = componentes.RetornarComponenteCompatible(id_componente, id_componente_siguiente, id_tipo_ensamble);
                if (tabla.Rows.Count > 0)
                {
                    DataRow row = tabla.Rows[0];
                    listaROM = tabla.AsEnumerable()
                    .Select(row => new Componente
                    {
                        IdComponente = row.Field<int>("id_componente"),
                        IdTipoComponente = row.Field<int>("id_tipo_componente")
                    })
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los componentes: " + ex.Message);
            }
        }

        private void LlenarListaTarjetaGrafica(string id_componente, string id_componente_siguiente, string id_tipo_ensamble)
        {
            try
            {
                CN_Componentes componentes = new();
                DataTable tabla = componentes.RetornarComponenteCompatible(id_componente, id_componente_siguiente, id_tipo_ensamble);
                if (tabla.Rows.Count > 0)
                {
                    DataRow row = tabla.Rows[0];
                    listaTarjetaGrafica = tabla.AsEnumerable()
                    .Select(row => new Componente
                    {
                        IdComponente = row.Field<int>("id_componente"),
                        IdTipoComponente = row.Field<int>("id_tipo_componente")
                    })
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los componentes: " + ex.Message);
            }
        }

        private void btnEnsamble_Click(object sender, EventArgs e)
        {
            ArmarEnsamble();
        }

        private void pbTiposEnsambles_Click(object sender, EventArgs e)
        {
            MantenimientoCriteriosDeBusqueda mantenimientoTiposDeEnsambles = new();
            mantenimientoTiposDeEnsambles.ShowDialog();


        }
    }
}
