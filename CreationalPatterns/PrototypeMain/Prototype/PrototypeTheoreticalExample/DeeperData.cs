using System;

namespace Prototype.PrototypeTheoreticalExample
{
    public static partial class TheoreticalPrototypeClientCode
    {
        // Prototype Pattern Judith Bishop Dec 2006, Nov 2007
        // Serializable is used for the deep copy option

        [Serializable()]
        // Helper class used to create a second level data structure
        class DeeperData
        {
            public string Data { get; set; }

            public DeeperData(string s)
            {
                Data = s;
            }
            public override string ToString()
            {
                return Data;
            }
        }
    }
}
