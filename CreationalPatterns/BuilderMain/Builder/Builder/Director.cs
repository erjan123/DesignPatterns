namespace Builder.Builder
{
    class Director
    {
        // Build a Product from several parts
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartB();
        }
    }
}