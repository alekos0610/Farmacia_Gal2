
namespace Farmacia
{
    partial class FrmPQRS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPQRS));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gpbPQR = new System.Windows.Forms.GroupBox();
            this.cmbTipoDocPQRS = new System.Windows.Forms.ComboBox();
            this.cmbTipoRecurso = new System.Windows.Forms.ComboBox();
            this.btnCerrarPQRS = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbNumId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblTipId = new System.Windows.Forms.Label();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txbSituacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gpbPQR.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(490, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 236);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // gpbPQR
            // 
            this.gpbPQR.Controls.Add(this.cmbTipoDocPQRS);
            this.gpbPQR.Controls.Add(this.cmbTipoRecurso);
            this.gpbPQR.Controls.Add(this.btnCerrarPQRS);
            this.gpbPQR.Controls.Add(this.lblDireccion);
            this.gpbPQR.Controls.Add(this.label2);
            this.gpbPQR.Controls.Add(this.txbDireccion);
            this.gpbPQR.Controls.Add(this.txbNumId);
            this.gpbPQR.Controls.Add(this.label1);
            this.gpbPQR.Controls.Add(this.txbNombres);
            this.gpbPQR.Controls.Add(this.lblNombres);
            this.gpbPQR.Controls.Add(this.txbEmail);
            this.gpbPQR.Controls.Add(this.txbTel);
            this.gpbPQR.Controls.Add(this.lblEmail);
            this.gpbPQR.Controls.Add(this.lblTel);
            this.gpbPQR.Controls.Add(this.lblTipId);
            this.gpbPQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPQR.Location = new System.Drawing.Point(23, 74);
            this.gpbPQR.Name = "gpbPQR";
            this.gpbPQR.Size = new System.Drawing.Size(403, 364);
            this.gpbPQR.TabIndex = 2;
            this.gpbPQR.TabStop = false;
            this.gpbPQR.Text = "Información PQR";
            // 
            // cmbTipoDocPQRS
            // 
            this.cmbTipoDocPQRS.FormattingEnabled = true;
            this.cmbTipoDocPQRS.Location = new System.Drawing.Point(186, 67);
            this.cmbTipoDocPQRS.Name = "cmbTipoDocPQRS";
            this.cmbTipoDocPQRS.Size = new System.Drawing.Size(168, 24);
            this.cmbTipoDocPQRS.TabIndex = 25;
            // 
            // cmbTipoRecurso
            // 
            this.cmbTipoRecurso.FormattingEnabled = true;
            this.cmbTipoRecurso.Location = new System.Drawing.Point(186, 37);
            this.cmbTipoRecurso.Name = "cmbTipoRecurso";
            this.cmbTipoRecurso.Size = new System.Drawing.Size(168, 24);
            this.cmbTipoRecurso.TabIndex = 24;
            // 
            // btnCerrarPQRS
            // 
            this.btnCerrarPQRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrarPQRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPQRS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarPQRS.Location = new System.Drawing.Point(308, 322);
            this.btnCerrarPQRS.Name = "btnCerrarPQRS";
            this.btnCerrarPQRS.Size = new System.Drawing.Size(75, 27);
            this.btnCerrarPQRS.TabIndex = 22;
            this.btnCerrarPQRS.Text = "Cerrar";
            this.btnCerrarPQRS.UseVisualStyleBackColor = false;
            this.btnCerrarPQRS.Click += new System.EventHandler(this.btnCerrarPQRS_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblDireccion.Location = new System.Drawing.Point(116, 189);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(72, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo de Solicitud";
            // 
            // txbDireccion
            // 
            this.txbDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDireccion.Location = new System.Drawing.Point(186, 187);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(168, 22);
            this.txbDireccion.TabIndex = 13;
            // 
            // txbNumId
            // 
            this.txbNumId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNumId.Location = new System.Drawing.Point(186, 99);
            this.txbNumId.Name = "txbNumId";
            this.txbNumId.Size = new System.Drawing.Size(168, 22);
            this.txbNumId.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(25, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de identificación";
            // 
            // txbNombres
            // 
            this.txbNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNombres.Location = new System.Drawing.Point(186, 129);
            this.txbNombres.Name = "txbNombres";
            this.txbNombres.Size = new System.Drawing.Size(168, 22);
            this.txbNombres.TabIndex = 9;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblNombres.Location = new System.Drawing.Point(51, 131);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(129, 16);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres completos";
            // 
            // txbEmail
            // 
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Location = new System.Drawing.Point(186, 215);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(168, 22);
            this.txbEmail.TabIndex = 14;
            // 
            // txbTel
            // 
            this.txbTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTel.Location = new System.Drawing.Point(186, 159);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(168, 22);
            this.txbTel.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(139, 217);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(119, 161);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(61, 16);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "Télefono";
            // 
            // lblTipId
            // 
            this.lblTipId.AutoSize = true;
            this.lblTipId.Location = new System.Drawing.Point(45, 67);
            this.lblTipId.Name = "lblTipId";
            this.lblTipId.Size = new System.Drawing.Size(135, 16);
            this.lblTipId.TabIndex = 1;
            this.lblTipId.Text = "Tipo de identificación";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.BackColor = System.Drawing.Color.White;
            this.lblInventario.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventario.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblInventario.Location = new System.Drawing.Point(104, -1);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInventario.Size = new System.Drawing.Size(581, 32);
            this.lblInventario.TabIndex = 5;
            this.lblInventario.Text = "SUGERENCIAS Y QUEJAS FARMACIA GALERAS";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(434, 250);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(164, 16);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción de la solicitud";
            // 
            // txbSituacion
            // 
            this.txbSituacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSituacion.Location = new System.Drawing.Point(437, 269);
            this.txbSituacion.Multiline = true;
            this.txbSituacion.Name = "txbSituacion";
            this.txbSituacion.Size = new System.Drawing.Size(351, 169);
            this.txbSituacion.TabIndex = 23;
            // 
            // FrmPQRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.txbSituacion);
            this.Controls.Add(this.gpbPQR);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmPQRS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PQRS";
            this.Load += new System.EventHandler(this.FrmPQRS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gpbPQR.ResumeLayout(false);
            this.gpbPQR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gpbPQR;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipId;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbNumId;
        private System.Windows.Forms.TextBox txbNombres;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.TextBox txbSituacion;
        private System.Windows.Forms.Button btnCerrarPQRS;
        private System.Windows.Forms.ComboBox cmbTipoRecurso;
        private System.Windows.Forms.ComboBox cmbTipoDocPQRS;
    }
}