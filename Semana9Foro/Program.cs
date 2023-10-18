// See https://aka.ms/new-console-template for more information

//Tengo entendido que esta es una de las nuevas caracteristicas de C# no se necesita explicitar el metodo Main ya que envuelve implicitamente
//el codigo sin estar expresado en la pantalla

using Semana9Foro;

ListaDeProductos mercaditoApu = new ListaDeProductos();

//------------------Test individual-------------------//
//ProductoPerecedero manteca = new ProductoPerecedero("Manteca Cabaña", 600, "lacteo", 18, 2023);
//Console.WriteLine($"El precio total es: {manteca.calcularPrecioTotal(1)}");
//manteca.mostrarDatos();


//------------------Test Listas-------------------//
mercaditoApu.addPerecederos("Manteca Cabaña", 600, "lacteo", 18, 2023);
mercaditoApu.addPerecederos("Lecha sancor", 500, "lacteo", 20, 2023);
mercaditoApu.addPerecederos("Jamon natural", 900, "embutido", 25, 2023);

mercaditoApu.addNoPerecederos("Lentejas Marolio", 500, "no perecedero", "Legumbre");
mercaditoApu.addNoPerecederos("Arroz integral Lucceti", 600, "no perecedero", "arroz");
mercaditoApu.addNoPerecederos("Fideos Molto", 450, "no perecedero", "pasta");

mercaditoApu.listarProdPerecederos();
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine(mercaditoApu.precioTotalMercaderiaFullPerece());
Console.WriteLine("---------------------------------------------------------------");
mercaditoApu.listarProductosNoPede();
Console.WriteLine(mercaditoApu.precioTotalMercaderiaFullNoPerece());

