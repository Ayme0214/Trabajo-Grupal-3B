using System;
using System.Collections.Generic;
using System.Text;
using Decorar.Clases;
using Decorar.Interfaces;

namespace Decorar.Clases
{
    public class Chat: DecorarPaginaWeb
    {
        public Chat (IPaginaWeb paginaWeb) :base (paginaWeb)
        { }
        public override string obtenDescripcion()
        {
            return this.paginaWeb.obtenDescripcion() + "Chat \n";
        }
    }
}
