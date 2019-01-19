using DoFactory.GangOfFour.Visitor.Structural;
using System;
using VistitorTheoreticalExampleClientCode;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DoFactory GangOfFour Visitor Structural

            Console.WriteLine("Gang Of Four Visitor Structural Run Example \n");
            GangOfFourVisitorStructural.Run();

            #endregion

            #region

            Console.WriteLine("Vistitor Theoretical Example");
            VistitorTheoreticalExample.Run();

            #endregion

            Console.Read();
        }
    }
}
