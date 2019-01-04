namespace DoFactory.GangOfFour.FactoryMethod.Structural
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}
