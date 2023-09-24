using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias
{
    public class Mano : AWeapon
    {
        private new const int Daño = 1;
        private new const int Defense = 1;

        public Mano() : base(Daño, Defense)
        {
        }
    }
}
