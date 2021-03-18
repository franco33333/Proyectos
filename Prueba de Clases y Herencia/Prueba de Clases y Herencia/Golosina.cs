using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_de_Clases_y_Herencia
{
    class Golosina:Producto
    {
        private string nombre;
        private int id, stock;
        private float precio;

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

        static List<Golosina> golosinas;
        public Golosina()
        {
            golosinas = new List<Golosina>();
        }

        public override void AgregarProducto(int ident, string nom, int cant, float pre)
        {
            Golosina gol = new Golosina();
            gol.id = ident;
            gol.nombre = nom;
            gol.stock = cant;
            gol.precio = pre;
            golosinas.Add((Golosina)gol);
        }

        public List<Golosina> GetGolosinas(){return golosinas;}

        public int getId() {return id;}
        public void modificarGol(int idAux, int sto)
        {
            //Busca el producto y le suma el stock.
            golosinas.Find(x => x.id == idAux).stock+=sto;
        }
    }
}
