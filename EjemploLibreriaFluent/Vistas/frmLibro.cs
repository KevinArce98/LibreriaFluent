﻿using EjemploLibreriaFluent.Logica;
using EjemploLibreriaFluent.Vistas.VistasEdicion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploLibreriaFluent.Vistas
{
    public partial class frmLibros : Form
    {
        public frmLibros()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEditarLibros oEdita = new frmEditarLibros();
            oEdita.ShowDialog();
            if (oEdita.IsAceptar == true)
            {
            
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {          
            frmEditarLibros oEdita = new frmEditarLibros();
            oEdita.ShowDialog();
        }
    }
}
