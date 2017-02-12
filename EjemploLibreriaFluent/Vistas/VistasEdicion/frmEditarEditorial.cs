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
    public partial class frmEditarEditorial : Form
    {
        private bool aceptar;
        private Editorial oEditorial;

        public frmEditarEditorial()
        {
            InitializeComponent();
            this.CenterToScreen();
            aceptar = false;
            oEditorial = new Editorial();
        }

        public frmEditarEditorial(Editorial pEditorial)
        {
            InitializeComponent();
            this.CenterToScreen();
            aceptar = false;
            oEditorial = pEditorial;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            oEditorial.Codigo = int.Parse(txtCodigo.Text);
            oEditorial.Nombre = txtNombre.Text;
            this.aceptar = true;
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

        public Editorial OEditorial
        {
            get
            {
                return oEditorial;
            }

            set
            {
                oEditorial = value;
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
