namespace Composite
{
    public abstract class ADocumento
    {
        public string Nombre { get; set; }
        public decimal SubTotal { get; set; }

        public ADocumento(string Nombre, decimal SubTotal)
        {
            this.Nombre = Nombre;
            this.SubTotal = SubTotal;
        }
    }
}