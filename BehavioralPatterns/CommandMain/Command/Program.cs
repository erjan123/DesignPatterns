using Command.CommandWithDelegate;
using Command.GoFCommandStructural;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            #region GoF Command Client 

                Console.WriteLine("GoF Command Client");
                GoFCommandClientCode.Run();

            #endregion

            #region Command With Delegate 

            Console.WriteLine("Command With Delegate");
            CommandWithDelegateClientCode.Run();

            #endregion

            Console.Read();
        }
    }
}
