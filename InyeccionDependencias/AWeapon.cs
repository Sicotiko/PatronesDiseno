using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias
{
    public abstract class AWeapon
    {
        public int Daño { get; private set; }
        public int Defense { get; private set; }
        public AWeapon(int daño, int defense)
        {
            Daño = daño;
            Defense = defense;
        }
        public void Atack()
        {
            Console.WriteLine();
            Console.WriteLine($"Atacas y haces {Daño} ptos. de Daño");
        }

        public void Block()
        {
            Console.WriteLine();
            Console.WriteLine($"Te defiendes y recibes {Defense} ptos. de Daño");
        }
    }
}
