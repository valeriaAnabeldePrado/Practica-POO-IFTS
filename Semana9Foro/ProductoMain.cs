using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana9Foro
{
    abstract class ProductoMain
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Tipo { get; set; }


        public ProductoMain(string nombre, double precio, string tipo)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Tipo = tipo;
        }
        //En C#, la palabra clave "virtual" se utiliza en la declaración de un método para indicar
        //que ese método puede ser sobrescrito por las clases derivadas.
        public virtual double calcularPrecioTotal(int cantidadProductos)
        {
            return Precio * cantidadProductos;
        }

        public virtual void mostrarDatos()
        {
            Console.WriteLine($"Producto: {Nombre}, precio: {Precio}, tipo: {Tipo}");
        }

    }
}
