namespace AbstractFactoryPattern
{
    // All concrete ProductB's
    class Shoes<Brand> : IShoes where Brand : IBrand, new()
    {
        private Brand myBrand;
        public Shoes()
        {
            myBrand = new Brand();
        }

        public int Price { get { return myBrand.Price; } }
    }
}

 