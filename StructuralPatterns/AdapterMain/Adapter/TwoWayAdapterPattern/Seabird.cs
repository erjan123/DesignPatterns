namespace Adapter.TwoWayAdapterPattern
{
    // Adapter
    public class Seabird : Seacraft, IAircraft
    {
        // A two-way adapter hides and routes the Target's methods
        // Use Seacraft instructions to implement this one
        public void TakeOff()
        {
            while (!Airborne)
                IncreaseRevs();
        }
        // Routes this straight back to the Aircraft
        public int Height { get; private set; } = 0;

        // This method is common to both Target and Adaptee
        public override void IncreaseRevs()
        {
            base.IncreaseRevs();
            if (Speed > 40)
                Height += 100;
        }
        public bool Airborne
        {
            get { return Height > 50; }
        }
    }
}
