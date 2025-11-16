using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Vehiculos
{
    public static class CreadorDeVehiculo
    {
        public static Vehiculo crearVehiculo(TipoDeVehiculo t , string matricula, int horaDeEntrada, bool esCliente)
        {
            switch (t)
            {
                case TipoDeVehiculo.Camioneta:
                    return new Camioneta(matricula, horaDeEntrada, esCliente);
                case TipoDeVehiculo.Auto:
                    return new Auto(matricula, horaDeEntrada, esCliente); ;
                case TipoDeVehiculo.Moto:
                    return new Moto(matricula, horaDeEntrada, esCliente);
                default:
                    return null;
            }
        }

        public static void ObtenerVehiculo(out string matricula, out int horaDeEntrada, out bool esCliente)
        {
            Console.Write("Matricula: ");
            matricula = Console.ReadLine();
            Console.Write("Tiempo: ");
            horaDeEntrada = int.Parse(Console.ReadLine());
            Console.Write("Es cliente: ");
            esCliente = bool.Parse(Console.ReadLine());
        }
    }
}
