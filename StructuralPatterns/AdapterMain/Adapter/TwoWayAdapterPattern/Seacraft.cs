using System;

namespace Adapter.TwoWayAdapterPattern
{
    // Adaptee implementation
    public class Seacraft : ISeacraft
    {
        public virtual void IncreaseRevs()
        {
            Speed += 10;
            Console.WriteLine("Seacraft engine increases revs to " + Speed + " knots");
        }
        public int Speed { get; private set; } = 0;
    }
}
