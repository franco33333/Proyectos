using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_de_Clases_y_Herencia
{
    class Menu
    {
        Golosina producto = new Golosina();

        public void golosina()
        {
            char entrada;
            do
            {
                int idAux, stock;
                string nombre;
                float precio;
                Console.WriteLine("Quiere ingresar(i), sacar(s), consultar(c), agregar(a) una golosina; o salir(e)?");
                entrada = Convert.ToChar(Console.ReadLine());
                switch (entrada)
                {
                    case 'i':
                        Console.WriteLine("Ingreso de golosinas");
                        Console.WriteLine("Id del producto: ");
                        idAux = Convert.ToInt32(Console.ReadLine());
                        if (producto.GetGolosinas().Exists(x=>x.Id == idAux))
                        {
                            Console.WriteLine("El producto ya existe");
                            Console.WriteLine("Ingrese cantidad a agregar: ");
                            stock = Convert.ToInt32(Console.ReadLine());
                            producto.modificarGol(idAux, stock);
                        }
                        else
                        {
                            Console.WriteLine("El producto no existe");
                            Console.WriteLine("Ingrese el nombre: ");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese cantidad a agregar: ");
                            stock = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el precio: ");
                            precio = (float)Convert.ToDouble(Console.ReadLine());
                            producto.AgregarProducto(idAux, nombre, stock, precio);
                        }
                        break;
                    case 's':
                        break;
                    case 'c':
                        Console.WriteLine("Ingrese Id a consultar: ");
                        idAux = Convert.ToInt32(Console.ReadLine());
                        if (producto.GetGolosinas().Exists(x => x.Id == idAux))
                        {
                            Golosina aux = producto.GetGolosinas().Find(x=>x.Id == idAux);
                            Console.WriteLine("Nombre del producto: {0}\nStock restante: {1}\nPrecio unitario: {2}\nID: {3}", aux.Nombre, aux.Stock, aux.Precio, idAux);
                        }
                        else
                        {
                            Console.WriteLine("El producto buscado no existe.");
                        }
                            break;
                    case 'a':
                        break;
                    default:
                        break;
                }
            } while (!entrada.Equals('e'));

        }
    }
}

