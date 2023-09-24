using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Camion : Transporte
    {
        public override int PesoSoportado { get; set; }

        public Camion()
        {
            PesoSoportado = 25000000;
        }
        public override string Nombre()
        {
            return "Camion";
        }
    }
}
