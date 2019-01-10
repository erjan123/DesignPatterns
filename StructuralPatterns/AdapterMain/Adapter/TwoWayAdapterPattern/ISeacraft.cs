namespace Adapter.TwoWayAdapterPattern
{
    // Adaptee interface
    public interface ISeacraft
    {
        int Speed { get; }
        void IncreaseRevs();
    }
}
