using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias
{
    public class Escudo : AWeapon
    {
        private new const int Daño = 3;
        private new const int Defense = 20;
        public Escudo() : base(Daño, Defense)
        {
        }
    }
}
