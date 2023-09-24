namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance = null;
        public string Mensaje = string.Empty;
        public int NumeroRandom = 0;
        protected Singleton()
        {
            Mensaje = "Hola Mundo!";
            NumeroRandom = new Random().Next();
        }
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }
    }
}