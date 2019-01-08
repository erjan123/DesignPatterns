namespace Builder.Builder
{
    class Builder2 : IBuilder
    {
        private Product product = new Product();
        public void BuildPartA()
        {
            product.Add("PartX ");
        }

        public void BuildPartB()
        {
            product.Add("PartY ");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}