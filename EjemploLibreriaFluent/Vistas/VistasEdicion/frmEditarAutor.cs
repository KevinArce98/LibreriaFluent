﻿using EjemploLibreriaFluent.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploLibreriaFluent.Vistas.VistasEdicion
{
    public partial class frmEditarAutor : Form
    {
        private bool aceptar;
        private Autor autor;
        public frmEditarAutor()
        {
            InitializeComponent();
            this.CenterToScreen();
            aceptar = false;
            autor = new Autor();
        }
        public frmEditarAutor(Autor pAutor)
        {
            InitializeComponent();
            this.CenterToScreen();
            aceptar = false;
            autor = pAutor;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals("") || txtNombre.Text.Equals("") || txtApellido.Text.Equals("")
                || txtNacionalidad.Text.Equals(""))
            {
                MessageBox.Show("Ingrese los datos solicitados", "Error", MessageBoxButtons.OK);
            }
            else
            {
                autor.Nombre = txtNombre.Text;
                autor.Apellido = txtApellido.Text;
                autor.Nacionalidad = txtNacionalidad.Text;
                autor.Codigo = int.Parse(txtCodigo.Text);
                this.aceptar = true;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Aceptar
        {
            get
            {
                return aceptar;
            }

            set
            {
                aceptar = value;
            }
        }

        public Autor Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se puede digitar numeros
            char caracter = e.KeyChar;
            if (((caracter < '0') || (caracter > '9')))
            {
                e.Handled = true;
            }
        }
    }
}
