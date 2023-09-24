using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Documento : ADocumento
    {
        private List<ADocumento> Documentos = new List<ADocumento>();

        public decimal Total
        {
            get
            {
                decimal total = 0;
                foreach (ADocumento documento in Documentos)
                {
                    if (documento.GetType() == typeof(DocumentoDetalle))
                        total += documento.SubTotal;
                    else
                        total += ((Documento)documento).Total;
                }
                return total;
            }
        }

        public void Add(ADocumento documento)
        {
            Documentos.Add(documento);
        }
        public void Remove(ADocumento documento)
        {
            Documentos.Remove(documento);
        }

        public Documento(string Nombre, decimal Total = 0) : base(Nombre, Total)
        {
        }
    }
}
