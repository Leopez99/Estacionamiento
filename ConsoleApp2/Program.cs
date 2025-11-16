// See https://aka.ms/new-console-template for more information
using ConsoleApp2.Vehiculos;

Console.WriteLine("Hello, World!");

string matricula;
int horaDeEntrada;
bool esCliente;

CreadorDeVehiculo.ObtenerVehiculo(out matricula, out horaDeEntrada, out esCliente);

Vehiculo vehiculo = CreadorDeVehiculo.crearVehiculo(TipoDeVehiculo.Camioneta,matricula, horaDeEntrada, esCliente);

Console.WriteLine($"Matricula: {vehiculo.matricula}");
Console.WriteLine($"horaDeEntrada: {vehiculo.horaDeEntrada}");
Console.WriteLine($"esCliente: {vehiculo.esCliente}");