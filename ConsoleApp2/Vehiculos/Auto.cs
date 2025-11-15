using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Vehiculos
{
    public class Auto : Vehiculo
    {
        public Auto(string matricula, int horaDeEntrada, bool esCliente) : base(matricula, horaDeEntrada, esCliente)
        {
        }
    }
}
