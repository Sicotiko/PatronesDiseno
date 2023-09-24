using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias
{
    public class Espada : AWeapon
    {
        private new const int Daño = 20;
        private new const int Defense = 5;
        public Espada() : base(Daño, Defense)
        {
        }
    }
}
