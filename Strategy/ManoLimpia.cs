using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ManoLimpia : IArma
    {

        public void Golpear()
        {
            Console.WriteLine($"Has golpeado a mano limpia generando 3 de daño");
        }
    }
}
