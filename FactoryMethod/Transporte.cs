using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Transporte
    {
        public abstract string Nombre();
        public abstract int PesoSoportado { get; set; }

    }
}
