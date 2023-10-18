using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana9Foro
{
    internal class ListaDeProductos
    {
        private LinkedList<ProductoPerecedero> listaProducPerecederos;
        private LinkedList<ProductoNoPerecedero> listaProducNoPerecederos;

        public ListaDeProductos()
        {
            this.listaProducPerecederos = new LinkedList<ProductoPerecedero>();
            this.listaProducNoPerecederos = new LinkedList<ProductoNoPerecedero>();
        }

        //Metodo para agregar productos perecederos
        public void addPerecederos(string nombre, double precio, string tipo, int diasAcaducar, int anioCaducidad)
        {
            ProductoPerecedero nuevoProductopOK = new ProductoPerecedero(nombre, precio, tipo, diasAcaducar, anioCaducidad);
            listaProducPerecederos.AddLast(nuevoProductopOK);

        }
        //Metodo para agregar productos no perecederos
        public void addNoPerecederos(string nombre, double precio, string tipo, string tipoCategoria)
        {
            ProductoNoPerecedero nuevoProductoNpOK = new ProductoNoPerecedero(nombre, precio, tipo, tipoCategoria);
            listaProducNoPerecederos.AddLast(nuevoProductoNpOK);
        }
        //Listar productos 
        public void listarProdPerecederos()
        {
            foreach (ProductoPerecedero productoParticular in listaProducPerecederos)
            {
                productoParticular.mostrarDatos();
            }
        }

        public void listarProductosNoPede()
        {
            foreach (ProductoNoPerecedero producto in listaProducNoPerecederos)
            {
                producto.mostrarDatos();
            }
        }
        //Metodos para calcular el precio total de toda la lista
        //Perecederos
        public double precioTotalMercaderiaFullPerece()
        {
            double valorFull = 0;

            foreach (ProductoPerecedero producto in listaProducPerecederos)
            {
                valorFull = valorFull + producto.calcularPrecioTotal(1);
            }
            return valorFull;
        }
        //No perecederos
        public double precioTotalMercaderiaFullNoPerece()
        {
            double valorFull = 0;
            foreach (ProductoNoPerecedero producto in listaProducNoPerecederos)
            {
                valorFull = valorFull + producto.calcularPrecioTotal(1);
            }
            return valorFull;
        }

    }
}
