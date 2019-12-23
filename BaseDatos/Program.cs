using System;
using System.Collections.Generic;
using System.Text;
using BaseDatos.Clases;

namespace BaseDatos.Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            BasedeDatos dato1 = new BasedeDatos ("Sql Server");
            BasedeDatos dato2 = new BasedeDatos("Oracle");
            BasedeDatos dato3 = new BasedeDatos("Postgre Sql");
            Singleton.Instancia.BasedeDatos = new List<BasedeDatos>();

            Singleton.Instancia.BasedeDatos.Add(dato1);
            Singleton.Instancia.BasedeDatos.Add(dato2);
            Singleton.Instancia.BasedeDatos.Add(dato3);
            foreach (BasedeDatos item in Singleton.Instancia.BasedeDatos)
            {
                Console.WriteLine(item.Mostrar());
            }
            Console.ReadLine();
        }
    }
}
