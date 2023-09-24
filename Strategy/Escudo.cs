using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Escudo : IArma
    {
        public void Golpear()
        {
            Console.WriteLine($"Has golpeado con Escudo generando 10 de daño");
        }
    }
}
