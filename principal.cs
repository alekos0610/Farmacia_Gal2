using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario Autenticado:", "Bienvenido a Farmacia Galera");
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            // Botón Inventario, lleva a form inventario al dar click
            Form FrmPrincipal = new FrmInventario();
            FrmPrincipal.ShowDialog();
            
        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            Form FrmPrincipal = new FrmDomicilios();
            FrmPrincipal.ShowDialog();
        }

        private void btnPQRS_Click(object sender, EventArgs e)
        {
            Form FrmPrincipal = new FrmPQRS();
            FrmPrincipal.ShowDialog();
        }

        private void opcionesDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cerrar este objeto y volver al login
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Terminar la aplicación
            Application.Exit();
        }
    }
}
