using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Vehiculos
{
    public class CreadorDeVehiculo
    {
        public Vehiculo crearVehiculo(TipoDeVehiculo t , string matricula, int horaDeEntrada, bool esCliente)
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
    }
}
