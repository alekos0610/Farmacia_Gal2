using System;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class FrmPQRS : Form
    {
        public FrmPQRS()
        {
            InitializeComponent();
        }

        private void btnCerrarPQRS_Click(object sender, EventArgs e)
        {
            //Botón para cerrar ventana y retornar a menú principal
            this.Close();
        }

        private void FrmPQRS_Load(object sender, EventArgs e)
        {
            // Se crea lista desplegable para elección del tipo de solicitud
            cmbTipoRecurso.Items.Add("Sugerencia");
            cmbTipoRecurso.Items.Add("Queja");
            cmbTipoRecurso.Items.Add("Reclamo");
            cmbTipoRecurso.Items.Add("Petición de Consulta");
            cmbTipoRecurso.Items.Add("Petición de Documentación");
            cmbTipoRecurso.Items.Add("Petición de Información");
            cmbTipoRecurso.Items.Add("Felicitaciónes");
            cmbTipoRecurso.Items.Add("Denuncia");

            // Se crea menú desplegable para elección de Documento para PQRS
            cmbTipoDocPQRS.Items.Add("Anonimo");
            cmbTipoDocPQRS.Items.Add("Cedula de ciudadanía");
            cmbTipoDocPQRS.Items.Add("Tarjeta de identidad");
            cmbTipoDocPQRS.Items.Add("Pasaporte");
            cmbTipoDocPQRS.Items.Add("Registro Civil");
            cmbTipoDocPQRS.Items.Add("NIT");

        }
       
    }
}
