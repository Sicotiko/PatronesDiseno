using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class DocumentoDetalle : ADocumento
    {
        public decimal Cantidad { get; set; }
        public string Unidad { get; set; }

        public DocumentoDetalle(string Nombre, decimal SubTotal, decimal cantidad, string unidad) : base(Nombre, SubTotal)
        {
            Cantidad = cantidad;
            Unidad = unidad;
        }
    }
}
