using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EjemploLibreriaFluent.Datos
{
    class ConexionSqlServer
    {
        IDbContext connection;

        public ConexionSqlServer()
        {
            this.connection = new DbContext();
            this.connection = this.establecerConexion();
        }

        public IDbContext Connection
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }

        private IDbContext establecerConexion()
        {
            IDbContext oContext = new DbContext();
            return oContext.ConnectionString(
                "Data Source = WARRENPC" + "\\" + "SQLEXPRESS; Initial Catalog = DataContext;" +
                "Integrated Security = True;", new SqlServerProvider());
        }
    }
}
