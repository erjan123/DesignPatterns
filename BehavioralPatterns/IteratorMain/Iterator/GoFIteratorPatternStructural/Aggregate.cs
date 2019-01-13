﻿namespace DoFactory.GangOfFour.Iterator.Structural
{
    /// <summary>
    /// The 'Aggregate' abstract class
    /// </summary>
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
