using System;
using Decorar.Clases;
using Decorar.Interfaces;

namespace Decorar
{
    class Program
    {
        static void Main(string[] args)
        {
            PaginaWeb Pagina= new PaginaWeb();
            Chat Conectarse = new Chat(Pagina);
            PagoenLinea Pagos = new PagoenLinea(Conectarse);
            Login Usuario = new Login(Pagos);
            MultiplesIdiomas Idiomas = new MultiplesIdiomas(Usuario);

            Console.WriteLine("Pagina web cuenta con las siguientes funcionalidades \n");
            Console.WriteLine(Idiomas.obtenDescripcion());
            Console.ReadKey();
        }
    }
}
