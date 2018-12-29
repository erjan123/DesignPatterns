using Bridge.TheoreticalBrideExample;
using DoFactory.GangOfFour.Bridge.Structural;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Bridge Example

                BridgePattern.Run();

            #endregion

            #region

                GoFTheoreticalBridgeClient.Run();

            #endregion

            Console.Read();
        }
    }
}
