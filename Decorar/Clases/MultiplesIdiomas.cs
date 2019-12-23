using System;
using System.Collections.Generic;
using System.Text;
using Decorar.Clases;
using Decorar.Interfaces;

namespace Decorar.Clases
{
    public class MultiplesIdiomas:DecorarPaginaWeb
    {
        public MultiplesIdiomas (IPaginaWeb paginaWeb): base (paginaWeb)
        { }
        public override string obtenDescripcion()
        {
            return this.paginaWeb.obtenDescripcion()
            + "Tipos de idiomas: \n"
            + " Español \n"
            + " Inglés \n"
            + " Ruso \n"
            + " Francés \n"
            + " Árabe \n";
        }
    }
}
