using EjemploLibreriaFluent.Logica;
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
    public partial class frmEditarLibros : Form
    {
        private bool aceptar;
        private Libro libro;
        public frmEditarLibros()
        {
            InitializeComponent();
            this.Aceptar = false;
        }

        

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool IsAceptar
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

        internal Libro Libro
        {
            get
            {
                return libro;
            }

            set
            {
                libro = value;
            }
        }
    }
}
