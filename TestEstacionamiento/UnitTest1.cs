using ConsoleApp2;
using ConsoleApp2.Vehiculos;

namespace TestEstacionamiento
{
    public class UnitTest1
    {
        Vehiculo camioneta;
        Vehiculo auto;
        CreadorDeVehiculo creadorDeVehiculo;
        public UnitTest1()
        {
            creadorDeVehiculo = new CreadorDeVehiculo();
        }

        [Fact]
        public void CreacionDeCamioneta()
        {
            camioneta = creadorDeVehiculo.crearVehiculo(TipoDeVehiculo.Camioneta, "C123", 2, true); 
            Assert.Equal("C123", camioneta.matricula);
        }
    }
}