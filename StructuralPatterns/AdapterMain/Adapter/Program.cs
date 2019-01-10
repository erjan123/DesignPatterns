using Adapter.AdapterTheoreticalExample;
using Adapter.TwoWayAdapterPattern;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Adapter Pattern Example

                AdapterClient.Run();

            #endregion

            #region Two Way Adapter Pattern Example 

            TwoWayAdapter.Run();

            #endregion

            Console.Read();
        }
    }
}
