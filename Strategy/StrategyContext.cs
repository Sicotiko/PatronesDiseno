using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class StrategyContext
    {
        private IArma arma;

        public StrategyContext()
        {
            this.arma = new ManoLimpia();
        }
        public void AtacarAManoLimpia()
        {
            this.arma = new ManoLimpia();
        }
        public void AtacarConEscudo()
        {
            this.arma = new Escudo();
        }
        public void AtacarConEspada()
        {
            this.arma = new Espada();
        }
        public void Atacar()
        {
            this.arma.Golpear();
        }

    }
}
