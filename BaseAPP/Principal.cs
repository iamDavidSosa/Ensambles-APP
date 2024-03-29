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



    }
}
