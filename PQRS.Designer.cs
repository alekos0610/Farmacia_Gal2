
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
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txbRecurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.txbFecha = new System.Windows.Forms.TextBox();
            this.txbBarrio = new System.Windows.Forms.TextBox();
            this.txbNumId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txbNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.txbTipId = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblTipId = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.lblInventario = new System.Windows.Forms.Label();
            this.lblSituacion = new System.Windows.Forms.Label();
            this.txbSituacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gpbPQR.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(437, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 304);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // gpbPQR
            // 
            this.gpbPQR.Controls.Add(this.lblBarrio);
            this.gpbPQR.Controls.Add(this.txbRecurso);
            this.gpbPQR.Controls.Add(this.label2);
            this.gpbPQR.Controls.Add(this.textBox13);
            this.gpbPQR.Controls.Add(this.txbFecha);
            this.gpbPQR.Controls.Add(this.txbBarrio);
            this.gpbPQR.Controls.Add(this.txbNumId);
            this.gpbPQR.Controls.Add(this.label1);
            this.gpbPQR.Controls.Add(this.textBox10);
            this.gpbPQR.Controls.Add(this.txbNombres);
            this.gpbPQR.Controls.Add(this.lblNombres);
            this.gpbPQR.Controls.Add(this.textBox9);
            this.gpbPQR.Controls.Add(this.txbEmail);
            this.gpbPQR.Controls.Add(this.txbTel);
            this.gpbPQR.Controls.Add(this.txbTipId);
            this.gpbPQR.Controls.Add(this.lblFecha);
            this.gpbPQR.Controls.Add(this.lblEmail);
            this.gpbPQR.Controls.Add(this.lblTel);
            this.gpbPQR.Controls.Add(this.lblTipId);
            this.gpbPQR.Controls.Add(this.textBox11);
            this.gpbPQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPQR.Location = new System.Drawing.Point(23, 74);
            this.gpbPQR.Name = "gpbPQR";
            this.gpbPQR.Size = new System.Drawing.Size(403, 364);
            this.gpbPQR.TabIndex = 2;
            this.gpbPQR.TabStop = false;
            this.gpbPQR.Text = "Información PQR";
            this.gpbPQR.Enter += new System.EventHandler(this.gpbPQR_Enter);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblBarrio.Location = new System.Drawing.Point(18, 155);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(43, 16);
            this.lblBarrio.TabIndex = 4;
            this.lblBarrio.Text = "Barrio";
            // 
            // txbRecurso
            // 
            this.txbRecurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRecurso.Location = new System.Drawing.Point(215, 221);
            this.txbRecurso.Name = "txbRecurso";
            this.txbRecurso.Size = new System.Drawing.Size(168, 22);
            this.txbRecurso.TabIndex = 15;
            this.txbRecurso.TextChanged += new System.EventHandler(this.txbRecurso_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(17, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo de recurso";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox13.Location = new System.Drawing.Point(6, 217);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(391, 35);
            this.textBox13.TabIndex = 21;
            // 
            // txbFecha
            // 
            this.txbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFecha.Location = new System.Drawing.Point(215, 258);
            this.txbFecha.Name = "txbFecha";
            this.txbFecha.Size = new System.Drawing.Size(168, 22);
            this.txbFecha.TabIndex = 20;
            // 
            // txbBarrio
            // 
            this.txbBarrio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbBarrio.Location = new System.Drawing.Point(215, 156);
            this.txbBarrio.Name = "txbBarrio";
            this.txbBarrio.Size = new System.Drawing.Size(168, 22);
            this.txbBarrio.TabIndex = 13;
            // 
            // txbNumId
            // 
            this.txbNumId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNumId.Location = new System.Drawing.Point(215, 96);
            this.txbNumId.Name = "txbNumId";
            this.txbNumId.Size = new System.Drawing.Size(168, 22);
            this.txbNumId.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(18, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de identificación";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox10.Location = new System.Drawing.Point(6, 92);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(391, 33);
            this.textBox10.TabIndex = 18;
            // 
            // txbNombres
            // 
            this.txbNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNombres.Location = new System.Drawing.Point(215, 36);
            this.txbNombres.Name = "txbNombres";
            this.txbNombres.Size = new System.Drawing.Size(168, 22);
            this.txbNombres.TabIndex = 9;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblNombres.Location = new System.Drawing.Point(18, 36);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(129, 16);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres completos";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox9.Location = new System.Drawing.Point(6, 33);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(391, 34);
            this.textBox9.TabIndex = 17;
            // 
            // txbEmail
            // 
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Location = new System.Drawing.Point(215, 193);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(168, 22);
            this.txbEmail.TabIndex = 14;
            // 
            // txbTel
            // 
            this.txbTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTel.Location = new System.Drawing.Point(215, 128);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(168, 22);
            this.txbTel.TabIndex = 12;
            // 
            // txbTipId
            // 
            this.txbTipId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTipId.Location = new System.Drawing.Point(215, 68);
            this.txbTipId.Name = "txbTipId";
            this.txbTipId.Size = new System.Drawing.Size(168, 22);
            this.txbTipId.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(18, 261);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(18, 128);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(61, 16);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "Télefono";
            // 
            // lblTipId
            // 
            this.lblTipId.AutoSize = true;
            this.lblTipId.Location = new System.Drawing.Point(17, 70);
            this.lblTipId.Name = "lblTipId";
            this.lblTipId.Size = new System.Drawing.Size(135, 16);
            this.lblTipId.TabIndex = 1;
            this.lblTipId.Text = "Tipo de identificación";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox11.Location = new System.Drawing.Point(6, 152);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(391, 35);
            this.textBox11.TabIndex = 19;
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
            // lblSituacion
            // 
            this.lblSituacion.AutoSize = true;
            this.lblSituacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacion.Location = new System.Drawing.Point(434, 313);
            this.lblSituacion.Name = "lblSituacion";
            this.lblSituacion.Size = new System.Drawing.Size(134, 16);
            this.lblSituacion.TabIndex = 8;
            this.lblSituacion.Text = "Situación presentada";
            // 
            // txbSituacion
            // 
            this.txbSituacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSituacion.Location = new System.Drawing.Point(437, 334);
            this.txbSituacion.Multiline = true;
            this.txbSituacion.Name = "txbSituacion";
            this.txbSituacion.Size = new System.Drawing.Size(351, 104);
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
            this.Controls.Add(this.lblSituacion);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmPQRS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PQRS";
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
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipId;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSituacion;
        private System.Windows.Forms.TextBox txbRecurso;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox txbFecha;
        private System.Windows.Forms.TextBox txbBarrio;
        private System.Windows.Forms.TextBox txbNumId;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txbNombres;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.TextBox txbTipId;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox txbSituacion;
    }
}