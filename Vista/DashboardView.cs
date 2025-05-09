using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermisosAppForm.Vista
{
    public partial class DashboardView : Form
    {
        public DashboardView()
        {
            InitializeComponent();
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {

        }

        private void listarContribuyentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarContribuyentesView gestionarContribuyentesView = new GestionarContribuyentesView();
            gestionarContribuyentesView.Show();
        }

        private void listarVehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarVehiculosView gestionarVehiculosView = new GestionarVehiculosView();
            gestionarVehiculosView.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
