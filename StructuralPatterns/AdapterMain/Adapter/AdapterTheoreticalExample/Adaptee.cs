namespace Adapter.AdapterTheoreticalExample
{
    // Existing way requests are implemented
    class Adaptee
    {
        // Provide full precision
        public double SpecificRequest(double a, double b)
        {
            return a / b;
        }
    }
}
