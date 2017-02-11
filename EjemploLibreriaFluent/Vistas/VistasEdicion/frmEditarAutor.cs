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
    public partial class frmEditarAutor : Form
    {
        private bool aceptar;
        private Autor autor;
        public frmEditarAutor()
        {
            InitializeComponent();
            aceptar = false;
            autor = new Autor();
        }
        public frmEditarAutor(Autor pAutor)
        {
            InitializeComponent();
            aceptar = false;
            autor = pAutor;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            autor.Nombre = txtNombre.Text;
            autor.Apellido = txtApellido.Text;
            autor.Nacionalidad = txtNacionalidad.Text;
            autor.Codigo = int.Parse(txtCodigo.Text);
            this.aceptar = true;
            this.Close();
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
    }
}
