using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Vehiculos
{
    public abstract class Vehiculo
    {
        public string matricula { get; set; }
        public int tiempo { get; set; }
        public bool esCliente { get; set; }

        protected Vehiculo(string matricula, int tiempo, bool esCliente) 
        {
            this.matricula = matricula;
            this.tiempo = tiempo;
            this.esCliente = esCliente;
        }

    }
}
