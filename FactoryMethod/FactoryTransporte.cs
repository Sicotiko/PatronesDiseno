using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FactoryTransporte
    {

        public static Transporte? Crear()
        {
            int aleatorio = new Random().Next(0, 25000001);
            Console.WriteLine(aleatorio.ToString());
            switch (aleatorio)
            {
                case <= 20:
                    return new Bicicleta();
                case > 20 and <= 1000:
                    return new Camioneta();
                case > 1000 and <= 25000000:
                    return new Camion();
                default:
                    return null;
            }

        }
        public static Transporte? Crear(int aleatorio)
        {
            Console.WriteLine($"Peso asignado: {aleatorio.ToString()}");
            switch (aleatorio)
            {
                case <= 20:
                    return new Bicicleta();
                case > 20 and <= 1000:
                    return new Camioneta();
                case > 1000 and <= 25000000:
                    return new Camion();
                default:
                    return null;
            }

        }
    }
}
