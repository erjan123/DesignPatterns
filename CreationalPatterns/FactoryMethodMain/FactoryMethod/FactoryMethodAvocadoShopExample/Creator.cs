namespace FactoryMethod.FactoryMethodAvocadoShopExample
{
    partial class FactoryPattern
    {
        class Creator
        {
            public IProduct FactoryMethod(int month)
            {
                if (month >= 4 && month <= 11)
                    return new ProductA();
                else
                    if (month == 1 || month == 2 || month == 12)
                    return new ProductB();
                else return new DefaultProduct();
            }
        }
    }
}
