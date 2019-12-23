using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDatos.Clases
{
    public sealed class Singleton
    {
       private static Singleton instancia = null;
       public Singleton()
       {}
       public static Singleton Instancia
           {
            get
            {
             if (instancia == null)
            {
             instancia = new Singleton();
             }
             return instancia;
             }
             }
            private List<BasedeDatos> basedeDatos;
            public List<BasedeDatos> BasedeDatos
            {
                get { return basedeDatos; }
                set { basedeDatos = value; }
            }
     }
}
