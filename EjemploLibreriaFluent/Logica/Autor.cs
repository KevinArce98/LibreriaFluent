using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLibreriaFluent.Logica
{
    class Autor
    {
        private string nombre;
        private string apellido;
        private int codigo;
        private string nacionalidad;
        public Autor()
        {

        }
        public Autor(string pNombre, string pApellido, int pCodigo, string pNacionalidad)
        {
            this.nombre = pNombre;
            this.apellido = pNombre;
            this.codigo = pCodigo;
            this.nacionalidad = pNacionalidad;
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

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
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

        public string Nacionalidad
        {
            get
            {
                return nacionalidad;
            }

            set
            {
                nacionalidad = value;
            }
        }
    }
}
