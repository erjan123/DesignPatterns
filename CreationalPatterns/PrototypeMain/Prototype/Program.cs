using Prototype.PrototypeTheoreticalExample;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Simple Prototype Example without Prototype Manager class

                PrototypeDancer1 salsaDancer = new PrototypeDancer1("Marc", "Salsa");
                PrototypeDancer1 newSalsaDancer = salsaDancer.Clone();
                newSalsaDancer.Name = "Tom";
                Console.WriteLine("salsaDancers Name = {0}", salsaDancer.Name);
                Console.WriteLine("Cloned newSalsaDancers Name = {0}", newSalsaDancer.Name);
                Console.WriteLine("\r\n");

            #endregion

            #region

                TheoreticalPrototypeClientCode.Run();

            #endregion

            Console.Read();
        }
    }
}
