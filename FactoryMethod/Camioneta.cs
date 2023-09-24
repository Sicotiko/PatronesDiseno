using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Camioneta : Transporte
    {


        public override int PesoSoportado { get; set; }
        public Camioneta()
        {
            PesoSoportado = 1000;
        }
        public override string Nombre()
        {
            return "Camioneta";
        }
    }
}
