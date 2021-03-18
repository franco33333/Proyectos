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
                Console.WriteLine("Quiere ingresar(i), sacar(s), consultar(c) una golosina, mostrar todas(m); o salir(e)?");
                entrada = Convert.ToChar(Console.ReadLine());
                switch (entrada)
                {
                    case 'i':
                        Console.WriteLine("Ingreso de golosinas");
                        Console.WriteLine("Id del producto: ");
                        idAux = Convert.ToInt32(Console.ReadLine());
                        if (producto.GetGolosinas().Exists(x=>x.id == idAux))
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
                        Console.WriteLine("Sacar golosinas");
                        Console.WriteLine("Ingrese ID de la golosina a sacar: ");
                        idAux = Convert.ToInt32(Console.ReadLine());
                        if(producto.GetGolosinas().Exists(x=>x.id == idAux))
                        {
                            Golosina aux = (Golosina)producto.GetGolosinas().Find(x => x.id == idAux);
                            Console.WriteLine("Se ha eliminado el producto {0}, con nombre {1}, stock {2} y precio {3}",aux.Id,aux.Nombre,aux.Stock,aux.Precio);
                            producto.eliminarGol(idAux);
                        }
                        break;
                    case 'm':
                        if (producto.GetGolosinas().Count!=0)
                        {
                            foreach (var item in producto.GetGolosinas())
                            {
                                Console.WriteLine("Producto ID: {0}\nNombre: {1}\nStock restante: {2}\nPrecio unitario: {3}\n\n\n", item.id, item.nombre, item.stock, item.precio);
                            }
                        }else
                        {
                            Console.WriteLine("No existen elmenetos en la lista.");
                        }
                        break;
                    case 'c':
                        Console.WriteLine("Ingrese Id a consultar: ");
                        idAux = Convert.ToInt32(Console.ReadLine());
                        if (producto.GetGolosinas().Exists(x => x.id == idAux))
                        {
                            Golosina aux = (Golosina)producto.GetGolosinas().Find(x=>x.id == idAux);
                            Console.WriteLine("Nombre del producto: {0}\nStock restante: {1}\nPrecio unitario: {2}\nID: {3}", aux.Nombre, aux.Stock, aux.Precio, idAux);
                        }
                        else
                        {
                            Console.WriteLine("El producto buscado no existe.");
                        }
                            break;
                    default:
                        break;
                }
            } while (!entrada.Equals('e'));

        }
    }
}

