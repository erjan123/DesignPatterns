namespace Builder.Builder
{
    interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }
}