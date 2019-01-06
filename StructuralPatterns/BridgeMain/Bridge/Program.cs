using Bridge.TheoreticalBrideExample;
using DoFactory.GangOfFour.Bridge.Structural;
using System;
using Bridge.OpenBook;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Bridge Example

                BridgePattern.Run();
           
            #endregion

            #region Gang Of Four Bridge Structural

                GoFTheoreticalBridgeClient.Run();

            #endregion

            #region Open Book Bridge Pattern

                OpenBookBridgePattern.Run();

            #endregion

            Console.Read();
        }
    }
}
