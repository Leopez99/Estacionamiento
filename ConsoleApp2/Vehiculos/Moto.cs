using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Vehiculos
{
    public class Moto : Vehiculo
    {
        public Moto(string matricula, int tiempo, bool esCliente) : base(matricula, tiempo, esCliente)
        {
        }
    }
}
