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

        private void btnCerrarInventario_Click(object sender, EventArgs e)
        {
            //Botón para cerrar ventana y retornar a menú principal
            this.Close();
        }

       
    }
}

