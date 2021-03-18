using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_de_Clases_y_Herencia
{
    
    abstract class Producto
    {
        protected List<Producto> productos;
        public string nombre;
        public int id, stock;
        public float precio;

        public Producto()
        {
            productos = new List<Producto>();
        }
        public abstract void AgregarProducto(int ident, string nom, int cant, float pre);
    }
}
