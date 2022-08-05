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
            BorrarMensaje();
            if (ValidarCampos())
            {
                MessageBox.Show("Datos Ingresados correctamente");
            }

        }

        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtProducto.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtProducto, "Ingresar nombre del Producto");
            }

            if (txtPresentacion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtProducto, "Ingresar el tipo de presentación");
            }

            if (txtCodigo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCodigo, "Ingresar Codigo del Medicamento");
            }

            if (txtConcentracion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtConcentracion, "Ingresar Concentración del medicamento");
            }

            if (txtCantidad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCantidad, "Ingresar la Cantidad");
            }

            if (txtValorUnd.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtValorUnd, "Ingresar Valor Unitario");
            }

            if (txtValorT.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtValorT, "Ingresar Valor total");
            }

            return ok;
        }

        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtProducto, "");
            errorProvider1.SetError(txtPresentacion, "");
            errorProvider1.SetError(txtCodigo, "");
            errorProvider1.SetError(txtConcentracion, "");
            errorProvider1.SetError(txtCantidad, "");
            errorProvider1.SetError(txtValorUnd, "");
            errorProvider1.SetError(txtValorT, "");
                
        }

        private void txtCantidad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int num;
            if(!int.TryParse(txtCantidad.Text, out num))
            {
                errorProvider1.SetError(txtCantidad, "Ingrese un valor númerico");
            }
            else
            {
                errorProvider1.SetError(txtCantidad, "");
            }
        }
    }
}
