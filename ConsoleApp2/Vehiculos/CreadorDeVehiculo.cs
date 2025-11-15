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

        public Vehiculo crearVehiculo(int v, string matricula, int tiempo, bool esCliente)
        {

            switch (v)
            {
                case CAMION:
                    return new Camioneta(matricula, tiempo, esCliente);
                case AUTO:
                    return new Auto(matricula, tiempo, esCliente); ;
                case MOTO:
                    return new Moto(matricula, tiempo, esCliente);
                default:
                    return null;
            }
        }
    }
}
