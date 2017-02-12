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
    public partial class frmEditorial : Form
    {
        public frmEditorial()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEditarEditorial oEdita = new frmEditarEditorial();
            oEdita.ShowDialog();
            if (oEdita.Aceptar == true)
            {

            }
        }
    }
}
