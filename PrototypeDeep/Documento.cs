namespace PrototypeDeep
{
    public class Documento : ICloneable
    {
        public string NombreDocumento { get; set; } = string.Empty;
        public int CantidadHojas { get; set; }

        public Documento(string nombreDocumento, int cantidadHojas)
        {
            NombreDocumento = nombreDocumento;
            CantidadHojas = cantidadHojas;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}