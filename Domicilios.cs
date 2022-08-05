using System;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FrmDomicilios : Form
    {
        public FrmDomicilios()
        {
            InitializeComponent();
        }

        private void FrmDomicilios_Load(object sender, EventArgs e)
        {
            // Se crea lista desplegable para selección de tipo de documento en identificación del usuario del menú domicilios.
            cmbTipoID.Items.Add("Tarjeta de identidad");
            cmbTipoID.Items.Add("Cedula de ciudadanía");
            cmbTipoID.Items.Add("Cedula de Extranjería");

            // Se crea lista Desplegable para selección de domiciliario.
            cmbDomiciliario.Items.Add("Michel Tarazona");
            cmbDomiciliario.Items.Add("Carlos Bustamante");
            cmbDomiciliario.Items.Add("Alejandra Medina");
            cmbDomiciliario.Items.Add("Sergio Silva");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Botón con opción de cerrar la ventana y retornar a menú principal
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ValidarCampos();

        }

        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtProducto.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtProducto, "Ingresar nombre");
            }

            if (txtPresentacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtProducto, "Ingresar nombre");
            }




            return ok;
        }

    }
}
