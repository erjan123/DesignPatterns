namespace AbstractFactoryPattern
{
    public static class AbstractFactory
    {
        public static void Run()
        {
            // Call Client twice
            new Client<Poochy>().ClientMain();
            new Client<Gucci>().ClientMain();
            new Client<Groundcover>().ClientMain();
        }
    }
}

 