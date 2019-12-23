using System;
using System.Collections.Generic;
using System.Text;
using Decorar.Clases;
using Decorar.Interfaces;

namespace Decorar.Clases
{
    public class Login : DecorarPaginaWeb
    {
        public Login(IPaginaWeb paginaWeb) : base(paginaWeb)
        { }
        public override string obtenDescripcion()
        {
            return this.paginaWeb.obtenDescripcion() + "Login \n";
        }
    }
}
