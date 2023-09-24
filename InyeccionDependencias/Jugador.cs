namespace InyeccionDependencias
{
    public class Jugador
    {
        private AWeapon _arma;
        public Jugador(AWeapon arma)
        {
            _arma = arma;
        }

        public void Atacar()
        {
            this._arma.Atack();
        }
        public void Bloquear()
        {
            this._arma.Block();
        }
    }
}