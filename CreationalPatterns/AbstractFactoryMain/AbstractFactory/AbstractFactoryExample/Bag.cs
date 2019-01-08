namespace AbstractFactoryPattern
{
    // All concrete ProductA's
    class Bag<Brand> : IBag where Brand : IBrand, new()
    {
        private Brand myBrand;
        public Bag()
        {
            myBrand = new Brand();
        }

        public string Material { get { return myBrand.Material; } }
    }
}

 