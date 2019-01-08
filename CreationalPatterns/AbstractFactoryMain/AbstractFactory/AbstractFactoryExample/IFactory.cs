namespace AbstractFactoryPattern
{
    interface IFactory<Brand> where Brand : IBrand {
            IBag CreateBag();
            IShoes CreateShoes();
        }
}

 