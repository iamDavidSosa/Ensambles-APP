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

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ChangeForm(new MantenimientoComponentes());
            lblTitulo.Text = "Mantenimiento Componentes";
            pbTitulo.Image = Properties.Resources.gcard;
        }

        //Que el pbSalir cierra la aplicación
        private void pbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
