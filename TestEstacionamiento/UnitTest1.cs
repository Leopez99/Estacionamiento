using ConsoleApp2;
using ConsoleApp2.Vehiculos;

namespace TestEstacionamiento
{
    public class UnitTest1
    {
        Vehiculo camioneta;
        CreadorDeVehiculo creadorDeVehiculo;
        public UnitTest1()
        {
            creadorDeVehiculo = new CreadorDeVehiculo();
        }

        [Fact]
        public void CreacionDeCamioneta()
        {
            camioneta = creadorDeVehiculo.crearVehiculo(1);
            Assert.Equal("C123", camioneta.matricula);
        }
    }
}