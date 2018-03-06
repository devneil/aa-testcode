namespace DesignPatterns
{
    public class Singleton
    {
        private Singleton _instance;

        public Singleton GetInstance()
        {
            return _instance ?? (_instance = new Singleton());
        }
    }
}
