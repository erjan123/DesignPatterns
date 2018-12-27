using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    #region Examples of Shallow copy

        // Simple class with Clone method
        public class PrototypeDancer1
        {
            private string _name;
            private string _danceType;

            public PrototypeDancer1(string name, string danceType)
            {
                _name = name;
                _danceType = danceType;
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public string DanceType
            {
                get { return _danceType; }
                set { _danceType = value; }
            }

            public PrototypeDancer1 Clone()
            {
                return (PrototypeDancer1)MemberwiseClone();
            }
        }

        // Simple class with different Clone method implemenation and different way to implment Properties
        public class PrototypeDancer2
        {
            public PrototypeDancer2(string name, string danceType)
            {
                Name = name;
                DanceType = danceType;
            }

            // No need to declare private field (auto property)
            // No need to implement get or set like in PropertyDancer1 example
            public string Name { get; set; }
            public string DanceType { get; set; }

            // Another way to return a clone
            public PrototypeDancer2 Clone()
            {
                return MemberwiseClone() as PrototypeDancer2;
            }
        }

        // Another way to implement Clone() method
        public class PrototypeDancer3
        {
            public PrototypeDancer3(string name, string danceType)
            {
                Name = name;
                DanceType = danceType;
            }

            // No need to declare private field (auto property)
            // No need to implement get or set like in PropertyDancer1 example
            public string Name { get; set; }
            public string DanceType { get; set; }

            // Another way to implement Clone()
            public PrototypeDancer3 Clone()
            {
                return new PrototypeDancer3(Name, DanceType);
            }
        }

        #region PrototypeDancer4 with abstract class

            public abstract class Dancer
            {
                public abstract Dancer Clone();
            }
            // Check the test case - Clone() a instance is slightly different
            public class PrototypeDancer4 : Dancer
            {
                public PrototypeDancer4(string name, string danceType)
                {
                    Name = name;
                    DanceType = danceType;
                }

                // No need to declare private field (auto property)
                // No need to implement get or set like in PropertyDancer1 example
                public string Name { get; set; }
                public string DanceType { get; set; }

                public override Dancer Clone()
                {
                    return MemberwiseClone() as Dancer;
                }
            }

        #endregion

    #endregion
}
