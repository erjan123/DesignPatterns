namespace FactoryMethod.FactoryMethodAvocadoShopExample
{
    partial class FactoryPattern
    {
        class DefaultProduct : IProduct
        {
            public string ShipFrom()
            {
                return "not available";
            }
        }
    }
}
