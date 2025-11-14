using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Vehiculos
{
    public class CreadorDeVehiculo
    {
        const int CAMION = 1;
        const int AUTO = 2;
        const int MOTO = 3;

        public Vehiculo crearVehiculo(int v)
        {
            Console.Write("Matricula: ");
            string matricula = Console.ReadLine();
            Console.Write("Tiempo: ");
            string tiempo = Console.ReadLine();
            Console.Write("Es cliente: ");
            string esCliente = Console.ReadLine();

            switch (v)
            {
                case CAMION:
                    return new Camioneta(matricula, int.Parse(tiempo), bool.Parse(esCliente));
                case AUTO:
                    return new Auto(matricula, int.Parse(tiempo), bool.Parse(esCliente)); ;
                case MOTO:
                    return new Moto(matricula, int.Parse(tiempo), bool.Parse(esCliente));
                default:
                    return null;
            }
        }

        private Camioneta crearCamioneta()
        {
            Console.Write("Matricula: ");
            string matricula = Console.ReadLine();
            Console.Write("Tiempo: ");
            string tiempo = Console.ReadLine();
            Console.Write("Es cliente: ");
            string esCliente = Console.ReadLine();

            return new Camioneta(matricula, int.Parse(tiempo), bool.Parse(esCliente));

        }
    }
}
