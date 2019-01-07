using System;
using PrototypePattern;

namespace Prototype.PrototypeTheoreticalExample
{
    public static partial class TheoreticalPrototypeClientCode
    {
        [Serializable()]
        class Prototype : IPrototype<Prototype>
        {

            // Content members
            public string Country { get; set; }
            public string Capital { get; set; }
            public DeeperData Language { get; set; }

            public Prototype(string country, string capital, string language)
            {
                Country = country;
                Capital = capital;
                Language = new DeeperData(language);
            }

            public override string ToString()
            {
                return Country + "\t\t" + Capital + "\t\t->" + Language;
            }

        }
    }
}
