using BaseAPP.Formularios;
using System.Windows.Forms;

namespace BaseAPP
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            ChangeForm(new Dashboard());
        }

        public void ChangeForm(Form form)
        {
            this.pnlPrincipal.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            this.pnlPrincipal.Controls.Add(form);
            form.Show();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReglas_Click_1(object sender, EventArgs e)
        {
            ChangeForm(new MantenimientoReglasCompatibilidad());
            lblTitulo.Text = "Mantenimiento Reglas de Compatibilidad";
            pbTitulo.Image = Properties.Resources.reglas1;
        }

        private void btnEnsambles_Click(object sender, EventArgs e)
        {
            ChangeForm(new GeneradorEnsambles());
            lblTitulo.Text = "Generador de Ensambles";
            pbTitulo.Image = Properties.Resources.ensamble;
        }

        private void btnComponentes_Click(object sender, EventArgs e)
        {
            ChangeForm(new MantenimientoComponentes());
            lblTitulo.Text = "Mantenimiento Componentes";
            pbTitulo.Image = Properties.Resources.gcard;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ChangeForm(new Dashboard());
            lblTitulo.Text = "Dashboard";
            pbTitulo.Image = Properties.Resources.dashboardT;

        }
    }
}
