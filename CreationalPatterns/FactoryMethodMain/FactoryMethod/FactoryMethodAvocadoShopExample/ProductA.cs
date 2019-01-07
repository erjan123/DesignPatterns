namespace FactoryMethod.FactoryMethodAvocadoShopExample
{
    partial class FactoryPattern
    {
        class ProductA : IProduct
        {
            public string ShipFrom()
            {
                return " from South Africa";
            }
        }
    }
}
