using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Espada : IArma
    {
        public void Golpear()
        {
            Console.WriteLine($"Has golpeado con Espada generando 15 de daño");
        }
    }
}
