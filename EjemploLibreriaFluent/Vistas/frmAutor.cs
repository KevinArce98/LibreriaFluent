﻿using EjemploLibreriaFluent.Vistas.VistasEdicion;
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
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEditarAutor oEdita = new frmEditarAutor();
            oEdita.ShowDialog();
        }
    }
}
