using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Vehiculos
{
    public class Auto : Vehiculo
    {
        public Auto(string matricula, int tiempo, bool esCliente) : base(matricula, tiempo, esCliente)
        {
        }
    }
}
