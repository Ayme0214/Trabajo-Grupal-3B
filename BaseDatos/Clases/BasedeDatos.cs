using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDatos.Clases
{
    public class BasedeDatos
    {
        private string datos;
        public BasedeDatos (string datos)
        {
            Datos = datos;
        }
        public string Datos
        {
            get { return datos; }
            set { datos = value; }
        }

        public string Mostrar()
        {
            return "\n" 
                + Datos;
        }
    }
}
