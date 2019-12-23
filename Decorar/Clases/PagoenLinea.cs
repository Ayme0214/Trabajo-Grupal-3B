using System;
using System.Collections.Generic;
using System.Text;
using Decorar.Clases;
using Decorar.Interfaces;

namespace Decorar.Clases
{
   public class PagoenLinea:DecorarPaginaWeb
    {
        public PagoenLinea(IPaginaWeb paginaWeb):base (paginaWeb)
        { }
        public override string obtenDescripcion()
        {
            return this.paginaWeb.obtenDescripcion()
                + "Pago en línea \n";
        }
    }
}
