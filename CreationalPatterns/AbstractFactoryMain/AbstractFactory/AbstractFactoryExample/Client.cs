
using System;

namespace AbstractFactoryPattern
{
    class Client<Brand> where Brand : IBrand, new()
    {
        public void ClientMain() //IFactory<Brand> factory) 
        {
            IFactory<Brand> factory = new Factory<Brand>();

            IBag bag = factory.CreateBag();
            IShoes shoes = factory.CreateShoes();

            Console.WriteLine("I bought a Bag which is made from " + bag.Material);
            Console.WriteLine("I bought some shoes which cost " + shoes.Price);
        }
    }
}

 