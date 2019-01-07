using System;
using System.Runtime.Serialization;
using PrototypePattern;

namespace Prototype.PrototypeTheoreticalExample
{
    public static partial class TheoreticalPrototypeClientCode
    {

        static void Report(string s, Prototype a, Prototype b)
        {
            Console.WriteLine("\n" + s);
            Console.WriteLine("Prototype " + a + "\nClone " + b);
        }

        public static void Run()
        {

            PrototypeManager manager = new PrototypeManager();
            Prototype c2, c3;

            // Make a copy of Australia's data
            c2 = manager.prototypes["Australia"].Clone();
            Report("Shallow cloning Australia\n===============",
            manager.prototypes["Australia"], c2);

            // Change the capital of Australia to Sydney
            c2.Capital = "Sydney";
            Report("Altered Clone's shallow state, prototype unaffected",
            manager.prototypes["Australia"], c2);

            // Change the language of Australia (deep data)
            c2.Language.Data = "Chinese";
            Report("Altering Clone deep state: prototype affected *****",
            manager.prototypes["Australia"], c2);

            // Make a copy of Germany's data
            c3 = manager.prototypes["Germany"].DeepCopy();
            Report("Deep cloning Germany\n============",
            manager.prototypes["Germany"], c3);

            // Change the capital of Germany
            c3.Capital = "Munich";
            Report("Altering Clone shallow state, prototype unaffected",
            manager.prototypes["Germany"], c3);

            // Change the language of Germany (deep data)
            c3.Language.Data = "Turkish";
            Report("Altering Clone deep state, prototype unaffected",
            manager.prototypes["Germany"], c3);
        }

    }
}
