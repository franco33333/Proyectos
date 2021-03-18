using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_de_Clases_y_Herencia
{
    class Golosina:Producto
    {
        public String Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Stock
        {
            set
            {
                stock = value;
            }
            get
            {
                return stock;
            }
        }

        public float Precio
        {
            set
            {
                precio = value;
            }
            get
            {
                return precio;
            }
        }

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        //static List<Golosina> golosinas;
        public Golosina()
        {

        }

        public override void AgregarProducto(int ident, string nom, int cant, float pre)
        {
            Golosina gol = new Golosina();
            gol.id = ident;
            gol.nombre = nom;
            gol.stock = cant;
            gol.precio = pre;
            productos.Add((Golosina)gol);
        }

        public List<Producto> GetGolosinas(){return productos;}

        public int getId() {return id;}
        public void modificarGol(int idAux, int sto)
        {
            //Busca el producto y le suma el stock.
            productos.Find(x => x.id == idAux).stock+=sto;
        }

        public void eliminarGol(int idAux)
        {
            productos.Remove(productos.Find(x => x.id == idAux));
        }
    }
}
