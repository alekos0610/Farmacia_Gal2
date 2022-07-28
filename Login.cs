﻿using System;
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
    public partial class login : Form
    {
        // Se declaran dos variables globales para la Validación
        // Esto a futuro será reemplazado por la validación desde la base de datos
        string Usuario = "a";
        string Contraseña = "a";

        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            // Imagen ocultar la mandamos al frente
            pbOcultar.BringToFront();

            //Se muestra la contraseña
            txtContraseña.PasswordChar = '*';
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            // Se manda al frente imagen mostrar la contraseña
            pbMostrar.BringToFront();
            // Se oculta la contraseña
            txtContraseña.PasswordChar = '\0';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Si el usuario es diferente a datos de validación
            // si la contraseña es diferente a datos declarados en la validación
            if (txtUsuario.Text != Usuario || txtContraseña.Text != Contraseña)
            {
                if (txtUsuario.Text != Usuario)
                {
                    //Mostrar mensaje emergente de Usuario incorrecto
                    MessageBox.Show("Usuario Incorrecto");
                    //Limpiar Linea de texto Usuario
                    txtUsuario.Clear();
                    //Poner el cursor en la caja de texto
                    txtUsuario.Focus();
                    //Acción return para que no continúe ejecutandose el codigo siguiente
                    return;
                }
                //Se verifica la caja de texto contraseña
                if (txtContraseña.Text != Contraseña)
                {
                    //Mostrar mensaje emergente de Contraseña Incorrecta
                    MessageBox.Show("Contraseña incorrecta");
                    //limpiar caja de texto Contraseña
                    txtContraseña.Clear();
                    //Poner el cursor en la caja de texto contraseña
                    txtContraseña.Focus();
                    //Acción return para que no continúe ejecutandose el codigo siguiente
                    return;
                }
            }
            else
            {
                //Limpiar los formularios
                txtUsuario.Clear();
                txtContraseña.Clear();

                // Si se cumplen las condiciones anteriores, saltar al siguiente formulario = principal
                FrmPrincipal Form = new FrmPrincipal();
                // ShowDialog para solo poder interactuar con el formulario nuevo y no saltar de uno a otro.
                Form.ShowDialog();
            }
        }

        private void btnOlvCont_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por favor ponte en contacto con el administrador del sistema");
        }

        private void lnkrecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Si se da click se salta al formulario de recuperación de usuario
            FrmRecuperación Form = new FrmRecuperación();
            // ShowDialog para solo poder interactuar con el formulario nuevo y no saltar de uno a otro.
            Form.ShowDialog();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
