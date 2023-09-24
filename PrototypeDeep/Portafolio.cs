using System.Diagnostics;

namespace PrototypeDeep
{
    public class Portafolio : ICloneable
    {
        public string Color { get; set; } = string.Empty;
        public int Capacidad { get; set; }
        public Documento Documento { get; set; }

        public Portafolio(string color, int capacidad)
        {
            Color = color;
            Capacidad = capacidad;
            Documento = new Documento("Guia 1", 3);
        }

        public object Clone()
        {
            Portafolio portafolio = (Portafolio)this.MemberwiseClone();
            portafolio.Documento = (Documento)Documento.Clone();
            return portafolio;
        }
    }
}