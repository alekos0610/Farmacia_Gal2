using System;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }                              

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            // Se crea lista desplegable para selección de presentación en inventario.
            cmbPresentacion.Items.Add("Cápsula");
            cmbPresentacion.Items.Add("Comprimido");
            cmbPresentacion.Items.Add("Grajea");
            cmbPresentacion.Items.Add("Jarabe");
            cmbPresentacion.Items.Add("Suspensión");
            cmbPresentacion.Items.Add("Polvo");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
                      
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
          
        private void lblFechaInv_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void txbEstante_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}

