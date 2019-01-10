namespace Adapter.TwoWayAdapterPattern
{
    // Embedded system for a Seabird flying plane
    // ITarget interface
    public interface IAircraft
    {
        bool Airborne { get; }
        void TakeOff();
        int Height { get; }
    }
}
