using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLibreriaFluent.Logica
{
    public class Libro
    {
        private int codigo;
        private string nombre;
        private Autor autor;
        private Editorial editorial;
        private int anio;

        public int Anio
        {
            get
            {
                return anio;
            }

            set
            {
                anio = value;
            }
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        internal Autor Autor
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

        internal Editorial Editorial
        {
            get
            {
                return editorial;
            }

            set
            {
                editorial = value;
            }
        }

        public Libro(int pCodigo, String pNombre, Autor pAutor, Editorial pEditorial, int pAnio)
        {
            this.Nombre = pNombre;
            this.Codigo = pCodigo;
            this.Autor = pAutor;
            this.Editorial = pEditorial;
            this.Anio = pAnio;
        }
        public Libro()
        {

        }
    }
}
