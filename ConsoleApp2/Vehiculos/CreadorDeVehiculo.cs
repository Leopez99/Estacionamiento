using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Vehiculos
{
    public class CreadorDeVehiculo
    {
        public Vehiculo crearVehiculo(TipoDeVehiculo t , string matricula, int tiempo, bool esCliente)
        {
            switch (t)
            {
                case TipoDeVehiculo.Camioneta:
                    return new Camioneta(matricula, tiempo, esCliente);
                case TipoDeVehiculo.Auto:
                    return new Auto(matricula, tiempo, esCliente); ;
                case TipoDeVehiculo.Moto:
                    return new Moto(matricula, tiempo, esCliente);
                default:
                    return null;
            }
        }
    }
}
