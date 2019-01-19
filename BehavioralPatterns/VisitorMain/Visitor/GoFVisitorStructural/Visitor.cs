﻿namespace DoFactory.GangOfFour.Visitor.Structural
{
    /// <summary>
    /// The 'Visitor' abstract class
    /// </summary>
    abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }
}
