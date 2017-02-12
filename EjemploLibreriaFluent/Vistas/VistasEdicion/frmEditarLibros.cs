using EjemploLibreriaFluent.Logica;
using System;
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
            this.CenterToScreen();
            this.aceptar = false;
            libro = new Libro();
        }
        public frmEditarLibros(Libro pLibro)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.aceptar = false;
            libro = pLibro;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            libro.Codigo = int.Parse(txtCodigo.Text);
            libro.Nombre = txtxNombre.Text;
            libro.Anio = int.Parse(txtAnio.Text);
            Autor oAutor = (Autor)cmbAutor.SelectedItem;
            Editorial oEditorial = (Editorial)cmbEdito.SelectedItem;
            libro.Editorial = oEditorial;
            libro.Autor = oAutor;
            this.aceptar = true;
            this.Close();
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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo se puede digitar numeros
            char caracter = e.KeyChar;
            if (((caracter < '0') || (caracter > '9')))
            {
                e.Handled = true;
            }
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
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
