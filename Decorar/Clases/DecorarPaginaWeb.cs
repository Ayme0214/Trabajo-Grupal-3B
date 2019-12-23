using System;
using System.Collections.Generic;
using System.Text;
using Decorar.Clases;
using Decorar.Interfaces;

namespace Decorar.Clases
{
    public abstract class DecorarPaginaWeb: IPaginaWeb
    {
        protected IPaginaWeb paginaWeb;
        public DecorarPaginaWeb (IPaginaWeb paginaWeb)
        {
            this.paginaWeb = paginaWeb;
        }
        public abstract string obtenDescripcion();
    }
}
