using Chain_of_Resp.ChainOfResponsibilityTheoretical;
using DoFactory.GangOfFour.ChainOfResponsibility.Structural;
using System;

namespace Chain_of_Resp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Chain Of Responsibility Structural

                Console.WriteLine("Chain Of Responsibility Structural");
                Console.WriteLine();
                ChainOfResponsibilityStructural.Run();

            #endregion

            #region Chain with State Pattern Theoretical

            Console.WriteLine("Chain with State Pattern Theoretical");
            Console.WriteLine();
            ChainwithStatePattern.Run();

            #endregion
        }
    }
}
