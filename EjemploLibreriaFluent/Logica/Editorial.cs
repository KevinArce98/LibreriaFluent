using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLibreriaFluent.Logica
{
    public class Editorial
    {
        private int codigo;
        private string nombre;
        public Editorial()
        {

        }
        public Editorial(int pCodigo, string pNombre)
        {
            this.nombre = pNombre;
            this.codigo = pCodigo;
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
    }
}
