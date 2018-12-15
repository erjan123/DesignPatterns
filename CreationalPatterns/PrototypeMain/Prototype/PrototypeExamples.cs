using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    // Simple class with Clone method
    public class PrototypeDancer1
    {
        private string _name;
        private string _danceType;

        public PrototypeDancer1() { }
        public PrototypeDancer1(string name, string danceMaster)
        {
            _name = name;
            _danceType = danceMaster;
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

    // Simple class with different Clone method implemenation and different way to implment
    // Properties
    public class PrototypeDancer2
    {
        public PrototypeDancer2() { }
        public PrototypeDancer2(string name, string danceMaster)
        {
            Name = name;
            DanceType = danceMaster;
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
}
