using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana9Foro
{
     class ProductoNoPerecedero : ProductoMain
    {
        public string TipodePraducto { get; set; }

        //Le coloco : base para llamar al costructor de la clase base
        public ProductoNoPerecedero(string nombre, double precio, string tipo, string tipoCategoria) : base(nombre, precio, tipo)
        {
            this.TipodePraducto = tipoCategoria;
        }
        //Sobre escribi el metodo de la clase abstracta mayor
        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.WriteLine($"La categoria: {TipodePraducto}");
        }

    }
}
