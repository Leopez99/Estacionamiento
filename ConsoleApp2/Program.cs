// See https://aka.ms/new-console-template for more information
using ConsoleApp2.Vehiculos;

Console.WriteLine("Hello, World!");

CreadorDeVehiculo creadorDeVehiculo = new CreadorDeVehiculo();
Vehiculo a = creadorDeVehiculo.crearVehiculo(TipoDeVehiculo.Camioneta, "ABCC2312", 2, true);

Console.WriteLine($"Matricula: {a.matricula}");
Console.WriteLine($"Tiempo: {a.tiempo}");
Console.WriteLine($"esCliente: {a.esCliente}");