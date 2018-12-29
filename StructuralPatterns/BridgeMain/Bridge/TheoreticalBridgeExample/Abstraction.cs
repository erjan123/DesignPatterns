namespace Bridge.TheoreticalBrideExample
{
    partial class BridgePattern
    {
        class Abstraction
        {
            IBridge bridge;
            public Abstraction(IBridge implementation)
            {
                bridge = implementation;
            }

            public string Operation()
            {
                return "Abstraction" + " <<< BRIDGE >>>> " + bridge.OperationImp();
            }
        }
    }
}
