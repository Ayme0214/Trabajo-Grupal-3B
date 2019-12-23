using System;
using System.Collections.Generic;
using System.Text;
using Decorar.Clases;
using Decorar.Interfaces;

namespace Decorar.Clases
{
    public class PaginaWeb:IPaginaWeb
    {
        public PaginaWeb()
        { }
        public string obtenDescripcion()
        {
            return "Fondo celeste \n"
            + "URL \n"
            + "Imágenes \n"
            + "Letra mediana \n"
            + "Tipo educativa \n";
        }
        internal static bool obtenerDescripcion()
        {
            throw new NotImplementedException();
        }
    }
}
