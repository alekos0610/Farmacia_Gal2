
namespace Farmacia
{
    partial class FrmDomicilios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDomicilios));
            this.lblInventario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbInfoPedido = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txbValorT = new System.Windows.Forms.TextBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txbValorUnd = new System.Windows.Forms.TextBox();
            this.lblVUnd = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txbPresentacion = new System.Windows.Forms.TextBox();
            this.txbConcentracion = new System.Windows.Forms.TextBox();
            this.txbProducto = new System.Windows.Forms.TextBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.lblConcentracion = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.gpbInfousuario = new System.Windows.Forms.GroupBox();
            this.cmbDomiciliario = new System.Windows.Forms.ComboBox();
            this.cmbTipoID = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbBarrio = new System.Windows.Forms.TextBox();
            this.txbNomUsuario = new System.Windows.Forms.TextBox();
            this.txbNumId = new System.Windows.Forms.TextBox();
            this.lblNomDomiciliario = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNumId = new System.Windows.Forms.Label();
            this.lblTipoId = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbInfoPedido.SuspendLayout();
            this.gpbInfousuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.BackColor = System.Drawing.Color.White;
            this.lblInventario.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblInventario.Location = new System.Drawing.Point(196, 32);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInventario.Size = new System.Drawing.Size(427, 32);
            this.lblInventario.TabIndex = 4;
            this.lblInventario.Text = "DOMICILIOS FARMACIA GALERAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // gpbInfoPedido
            // 
            this.gpbInfoPedido.Controls.Add(this.cmbDomiciliario);
            this.gpbInfoPedido.Controls.Add(this.lblTotal);
            this.gpbInfoPedido.Controls.Add(this.txbValorT);
            this.gpbInfoPedido.Controls.Add(this.txbCantidad);
            this.gpbInfoPedido.Controls.Add(this.lblCantidad);
            this.gpbInfoPedido.Controls.Add(this.txbValorUnd);
            this.gpbInfoPedido.Controls.Add(this.lblVUnd);
            this.gpbInfoPedido.Controls.Add(this.lblNomDomiciliario);
            this.gpbInfoPedido.Controls.Add(this.txbCodigo);
            this.gpbInfoPedido.Controls.Add(this.lblCodigo);
            this.gpbInfoPedido.Controls.Add(this.txbPresentacion);
            this.gpbInfoPedido.Controls.Add(this.txbConcentracion);
            this.gpbInfoPedido.Controls.Add(this.txbProducto);
            this.gpbInfoPedido.Controls.Add(this.lblPresentacion);
            this.gpbInfoPedido.Controls.Add(this.lblConcentracion);
            this.gpbInfoPedido.Controls.Add(this.lblProducto);
            this.gpbInfoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoPedido.Location = new System.Drawing.Point(90, 67);
            this.gpbInfoPedido.Name = "gpbInfoPedido";
            this.gpbInfoPedido.Size = new System.Drawing.Size(667, 172);
            this.gpbInfoPedido.TabIndex = 6;
            this.gpbInfoPedido.TabStop = false;
            this.gpbInfoPedido.Text = "Información del pedido";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(385, 130);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 16);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Valor total";
            // 
            // txbValorT
            // 
            this.txbValorT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbValorT.Location = new System.Drawing.Point(484, 130);
            this.txbValorT.Name = "txbValorT";
            this.txbValorT.Size = new System.Drawing.Size(139, 22);
            this.txbValorT.TabIndex = 12;
            // 
            // txbCantidad
            // 
            this.txbCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCantidad.Location = new System.Drawing.Point(484, 68);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(139, 22);
            this.txbCantidad.TabIndex = 11;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(385, 70);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 16);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txbValorUnd
            // 
            this.txbValorUnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbValorUnd.Location = new System.Drawing.Point(484, 100);
            this.txbValorUnd.Name = "txbValorUnd";
            this.txbValorUnd.Size = new System.Drawing.Size(139, 22);
            this.txbValorUnd.TabIndex = 9;
            // 
            // lblVUnd
            // 
            this.lblVUnd.AutoSize = true;
            this.lblVUnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVUnd.Location = new System.Drawing.Point(385, 100);
            this.lblVUnd.Name = "lblVUnd";
            this.lblVUnd.Size = new System.Drawing.Size(85, 16);
            this.lblVUnd.TabIndex = 8;
            this.lblVUnd.Text = "Valor unitario";
            // 
            // txbCodigo
            // 
            this.txbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCodigo.Location = new System.Drawing.Point(165, 102);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(162, 22);
            this.txbCodigo.TabIndex = 7;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 102);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(129, 16);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código del producto";
            // 
            // txbPresentacion
            // 
            this.txbPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPresentacion.Location = new System.Drawing.Point(165, 70);
            this.txbPresentacion.Name = "txbPresentacion";
            this.txbPresentacion.Size = new System.Drawing.Size(162, 22);
            this.txbPresentacion.TabIndex = 5;
            // 
            // txbConcentracion
            // 
            this.txbConcentracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbConcentracion.Location = new System.Drawing.Point(484, 40);
            this.txbConcentracion.Name = "txbConcentracion";
            this.txbConcentracion.Size = new System.Drawing.Size(139, 22);
            this.txbConcentracion.TabIndex = 4;
            // 
            // txbProducto
            // 
            this.txbProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbProducto.Location = new System.Drawing.Point(165, 40);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.Size = new System.Drawing.Size(162, 22);
            this.txbProducto.TabIndex = 3;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.Location = new System.Drawing.Point(6, 68);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(86, 16);
            this.lblPresentacion.TabIndex = 2;
            this.lblPresentacion.Text = "Presentación";
            // 
            // lblConcentracion
            // 
            this.lblConcentracion.AutoSize = true;
            this.lblConcentracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcentracion.Location = new System.Drawing.Point(385, 42);
            this.lblConcentracion.Name = "lblConcentracion";
            this.lblConcentracion.Size = new System.Drawing.Size(93, 16);
            this.lblConcentracion.TabIndex = 1;
            this.lblConcentracion.Text = "Concentración";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(6, 42);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(134, 16);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Nombre del producto";
            // 
            // gpbInfousuario
            // 
            this.gpbInfousuario.Controls.Add(this.cmbTipoID);
            this.gpbInfousuario.Controls.Add(this.btnCerrar);
            this.gpbInfousuario.Controls.Add(this.txbTel);
            this.gpbInfousuario.Controls.Add(this.txbDireccion);
            this.gpbInfousuario.Controls.Add(this.txbBarrio);
            this.gpbInfousuario.Controls.Add(this.txbNomUsuario);
            this.gpbInfousuario.Controls.Add(this.txbNumId);
            this.gpbInfousuario.Controls.Add(this.lblTel);
            this.gpbInfousuario.Controls.Add(this.lblBarrio);
            this.gpbInfousuario.Controls.Add(this.lblDireccion);
            this.gpbInfousuario.Controls.Add(this.lblNumId);
            this.gpbInfousuario.Controls.Add(this.lblTipoId);
            this.gpbInfousuario.Controls.Add(this.lblNomUsuario);
            this.gpbInfousuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfousuario.Location = new System.Drawing.Point(90, 245);
            this.gpbInfousuario.Name = "gpbInfousuario";
            this.gpbInfousuario.Size = new System.Drawing.Size(667, 188);
            this.gpbInfousuario.TabIndex = 7;
            this.gpbInfousuario.TabStop = false;
            this.gpbInfousuario.Text = "Información del usuario";
            // 
            // cmbDomiciliario
            // 
            this.cmbDomiciliario.FormattingEnabled = true;
            this.cmbDomiciliario.Location = new System.Drawing.Point(165, 136);
            this.cmbDomiciliario.Name = "cmbDomiciliario";
            this.cmbDomiciliario.Size = new System.Drawing.Size(162, 24);
            this.cmbDomiciliario.TabIndex = 28;
            // 
            // cmbTipoID
            // 
            this.cmbTipoID.FormattingEnabled = true;
            this.cmbTipoID.Location = new System.Drawing.Point(170, 56);
            this.cmbTipoID.Name = "cmbTipoID";
            this.cmbTipoID.Size = new System.Drawing.Size(162, 24);
            this.cmbTipoID.TabIndex = 15;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(556, 142);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(79, 34);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txbTel
            // 
            this.txbTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTel.Location = new System.Drawing.Point(484, 92);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(139, 22);
            this.txbTel.TabIndex = 27;
            // 
            // txbDireccion
            // 
            this.txbDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDireccion.Location = new System.Drawing.Point(484, 60);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(139, 22);
            this.txbDireccion.TabIndex = 26;
            // 
            // txbBarrio
            // 
            this.txbBarrio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbBarrio.Location = new System.Drawing.Point(484, 21);
            this.txbBarrio.Name = "txbBarrio";
            this.txbBarrio.Size = new System.Drawing.Size(139, 22);
            this.txbBarrio.TabIndex = 25;
            // 
            // txbNomUsuario
            // 
            this.txbNomUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNomUsuario.Location = new System.Drawing.Point(170, 27);
            this.txbNomUsuario.Name = "txbNomUsuario";
            this.txbNomUsuario.Size = new System.Drawing.Size(162, 22);
            this.txbNomUsuario.TabIndex = 23;
            // 
            // txbNumId
            // 
            this.txbNumId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNumId.Location = new System.Drawing.Point(170, 90);
            this.txbNumId.Name = "txbNumId";
            this.txbNumId.Size = new System.Drawing.Size(162, 22);
            this.txbNumId.TabIndex = 15;
            // 
            // lblNomDomiciliario
            // 
            this.lblNomDomiciliario.AutoSize = true;
            this.lblNomDomiciliario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomDomiciliario.Location = new System.Drawing.Point(6, 136);
            this.lblNomDomiciliario.Name = "lblNomDomiciliario";
            this.lblNomDomiciliario.Size = new System.Drawing.Size(153, 16);
            this.lblNomDomiciliario.TabIndex = 21;
            this.lblNomDomiciliario.Text = "Domiciliario que entrega";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(385, 92);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(61, 16);
            this.lblTel.TabIndex = 20;
            this.lblTel.Text = "Télefono";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(387, 27);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(43, 16);
            this.lblBarrio.TabIndex = 19;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(385, 62);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNumId
            // 
            this.lblNumId.AutoSize = true;
            this.lblNumId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumId.Location = new System.Drawing.Point(6, 92);
            this.lblNumId.Name = "lblNumId";
            this.lblNumId.Size = new System.Drawing.Size(132, 16);
            this.lblNumId.TabIndex = 17;
            this.lblNumId.Text = "Nro  de identificación";
            // 
            // lblTipoId
            // 
            this.lblTipoId.AutoSize = true;
            this.lblTipoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoId.Location = new System.Drawing.Point(6, 63);
            this.lblTipoId.Name = "lblTipoId";
            this.lblTipoId.Size = new System.Drawing.Size(135, 16);
            this.lblTipoId.TabIndex = 16;
            this.lblTipoId.Text = "Tipo de identificación";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUsuario.Location = new System.Drawing.Point(6, 29);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(115, 16);
            this.lblNomUsuario.TabIndex = 15;
            this.lblNomUsuario.Text = "Nombre completo";
            // 
            // FrmDomicilios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbInfoPedido);
            this.Controls.Add(this.gpbInfousuario);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmDomicilios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domicilios";
            this.Load += new System.EventHandler(this.FrmDomicilios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbInfoPedido.ResumeLayout(false);
            this.gpbInfoPedido.PerformLayout();
            this.gpbInfousuario.ResumeLayout(false);
            this.gpbInfousuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbInfoPedido;
        private System.Windows.Forms.GroupBox gpbInfousuario;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txbPresentacion;
        private System.Windows.Forms.TextBox txbConcentracion;
        private System.Windows.Forms.TextBox txbProducto;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblConcentracion;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txbValorT;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txbValorUnd;
        private System.Windows.Forms.Label lblVUnd;
        private System.Windows.Forms.Label lblNomDomiciliario;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNumId;
        private System.Windows.Forms.Label lblTipoId;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbBarrio;
        private System.Windows.Forms.TextBox txbNomUsuario;
        private System.Windows.Forms.TextBox txbNumId;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbTipoID;
        private System.Windows.Forms.ComboBox cmbDomiciliario;
    }
}