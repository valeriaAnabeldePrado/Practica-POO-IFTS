using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana9Foro
{
     class ProductoPerecedero : ProductoMain
    {
        public int DiasACaducar { get; set; }
        public int AnioACaducar { get; set; }

        public ProductoPerecedero(string nombre, double precio, string tipo, int diasAcaducar, int anioCaducidad) : base(nombre, precio, tipo)
        {
            this.DiasACaducar = diasAcaducar;
            this.AnioACaducar = anioCaducidad;
        }

        //Sobre escribi el metodo de la clase abstracta mayor
        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.WriteLine($"La fecha de caducidad es: {DiasACaducar}/{AnioACaducar}");
        }

        public override double calcularPrecioTotal(int cantidadProductos)
        {
            double valor;

            int diaActual = DateTime.Now.Day;
            int anioActual = DateTime.Now.Year;
            int tiempoQueQueda = DiasACaducar - diaActual;

            switch (tiempoQueQueda)
            {
                case 1 when anioActual == AnioACaducar:
                    valor = Precio / 4;
                    break;
                case 2 when anioActual == AnioACaducar:
                    valor = Precio / 3;
                    break;
                case 3 when anioActual == AnioACaducar:
                    valor = Precio / 2;
                    break;
                default:
                    valor = Precio;
                    break;
            }

            if (valor < Precio)
            {
                Console.WriteLine("Se realizo un descuento por próximo vencimiento");
            }
            string valorFormateado = valor.ToString("0.00");
            double valorFinal = Convert.ToDouble(valorFormateado);

            return valorFinal;
        }

    }
}
