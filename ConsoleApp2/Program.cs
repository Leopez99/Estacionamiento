// See https://aka.ms/new-console-template for more information
using ConsoleApp2;
using ConsoleApp2.Vehiculos;
using System.Text.Json;

//string matricula;
//int horaDeEntrada;
//bool esCliente;

//CreadorDeVehiculo.ObtenerVehiculo(out matricula, out horaDeEntrada, out esCliente);

Vehiculo vehiculo = CreadorDeVehiculo.crearVehiculo(TipoDeVehiculo.Camioneta,"matricula", 2, true);

//string jsonString = JsonSerializer.Serialize(vehiculo);

//Console.WriteLine(jsonString);

Ticketera ticket = new Ticketera();

ticket.CrearTicket(vehiculo);



//Console.WriteLine($"Matricula: {vehiculo.matricula}");
//Console.WriteLine($"horaDeEntrada: {vehiculo.horaDeEntrada}");
//Console.WriteLine($"esCliente: {vehiculo.esCliente}");