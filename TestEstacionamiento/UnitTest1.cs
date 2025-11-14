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

        [Fact]  //No funciona porque el metodo crearVehiculo hace cosas con readLine() y necesita la consola
        public void CreacionDeCamioneta()
        {
            camioneta = creadorDeVehiculo.crearVehiculo(1); 
            Assert.Equal("C123", camioneta.matricula);
        }
    }
}