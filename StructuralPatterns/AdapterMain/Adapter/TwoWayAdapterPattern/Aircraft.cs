using System;

namespace Adapter.TwoWayAdapterPattern
{
    // Target
    public sealed class Aircraft : IAircraft
    {
        public Aircraft()
        {
            Height = 0;
            Airborne = false;
        }
        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeoff");
            Airborne = true;
            Height = 200; // Meters
        }
        public bool Airborne { get; private set; }
        public int Height { get; private set; }
    }
}
