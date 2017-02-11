using EjemploLibreriaFluent.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploLibreriaFluent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            frmLibros ofrmLibro = new frmLibros();
            ofrmLibro.ShowDialog();
        }

        private void btnEditorial_Click(object sender, EventArgs e)
        {
            frmEditorial frmEditorial = new frmEditorial();
            frmEditorial.ShowDialog();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            frmAutor frmaAutor = new frmAutor();
            frmaAutor.ShowDialog();
        }
    }
}
