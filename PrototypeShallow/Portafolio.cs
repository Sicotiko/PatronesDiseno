namespace PrototypeShallow
{
    public class Portafolio : ICloneable
    {
        public string Color { get; set; } = string.Empty;
        public int Capacidad { get; set; }

        public Portafolio(string color, int capacidad)
        {
            Color = color;
            Capacidad = capacidad;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}