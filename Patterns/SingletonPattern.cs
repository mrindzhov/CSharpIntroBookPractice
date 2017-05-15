namespace Patterns
{
    public class Singleton
    {
        // Single instance
        private static Singleton instance;
        // Initialize the single instance
        static Singleton()
        {
            instance = new Singleton();
        }
        // The property for taking the single instance
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
        // Private constructor – protects direct instantiation
        private Singleton() { }
    }

}
