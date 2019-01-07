using System;
using System.Collections.Generic;
using PrototypePattern;

namespace Prototype.PrototypeTheoreticalExample
{
    public static partial class TheoreticalPrototypeClientCode
    {
        [Serializable()]
        class PrototypeManager : IPrototype<Prototype>
        {
            public Dictionary<string, Prototype> prototypes
            = new Dictionary<string, Prototype> {
                                      {"Germany", new Prototype("Germany", "Berlin", "German")},
                                      {"Italy", new Prototype("Italy", "Rome", "Italian")},
                                      {"Australia", new Prototype("Australia", "Canberra", "English")}};
        }
    }
}
