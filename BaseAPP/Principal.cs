using BaseAPP.Formularios;

namespace BaseAPP
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            this.pnlPrincipal.Controls.Clear();
            Dashboard frmDashboard = new Dashboard() {Dock=DockStyle.Fill, TopLevel=false, TopMost=true};
            this.pnlPrincipal.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }


    }
}
