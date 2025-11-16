using ConsoleApp2;
using ConsoleApp2.Vehiculos;

namespace TestEstacionamiento
{
    public class UnitTest1
    {
        Vehiculo camioneta;
        Vehiculo auto;
        public UnitTest1()
        {
        }

        [Fact]
        public void CreacionDeCamioneta()
        {
            camioneta = CreadorDeVehiculo.crearVehiculo(TipoDeVehiculo.Camioneta, "C123", 2, true); 
            Assert.Equal("C123", camioneta.matricula);
        }
    }
}