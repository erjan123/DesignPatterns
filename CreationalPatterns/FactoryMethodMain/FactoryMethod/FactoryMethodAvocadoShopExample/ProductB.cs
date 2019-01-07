namespace FactoryMethod.FactoryMethodAvocadoShopExample
{
    partial class FactoryPattern
    {
        class ProductB : IProduct
        {
            public string ShipFrom()
            {
                return "from Spain";
            }
        }
    }
}
