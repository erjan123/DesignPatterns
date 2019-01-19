﻿namespace DoFactory.GangOfFour.Visitor.Structural
{
    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
