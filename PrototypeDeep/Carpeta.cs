using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDeep
{
    public class Carpeta : ICloneable
    {
        public string Color { get; set; } = string.Empty;
        public List<Documento> Documentos { get; set; } = new List<Documento>();
        public Carpeta()
        {
            Color = "Color Original";
            for (int i = 0; i <= 10; i++)
                Documentos.Add(new Documento($"Documento Original {i}", i));
        }
        public object Clone()
        {
            Carpeta carpeta = (Carpeta)this.MemberwiseClone();
            List<Documento> documentos = new List<Documento>();
            foreach (Documento doc in Documentos)
                documentos.Add((Documento)doc.Clone());
            carpeta.Documentos = documentos;

            return carpeta;
        }
    }
}
