namespace FactoryMethod
{
    public class Bicicleta : Transporte
    {
        public override int PesoSoportado { get; set; }

        public Bicicleta()
        {
            PesoSoportado = 20;
        }
        public override string Nombre()
        {
            return "Bicicleta";
        }
    }
}