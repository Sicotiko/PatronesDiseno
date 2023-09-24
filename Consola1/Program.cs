namespace Consola1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PruebaSingleton();
        }

        private static void PruebaSingleton()
        {
            Console.WriteLine($"Primera Prueba {Singleton.Singleton.Instance.NumeroRandom}");
            Console.WriteLine($"Segunda Prueba {Singleton.Singleton.Instance.NumeroRandom}");
            Console.ReadKey();

        }
    }
}