using System;
using ObjectStructure;

// Visitor Pattern - Example Judith Bishop October 2007
// Sets up an object structure and visits it

namespace VistitorTheoreticalExampleClientCode
{
    public static class VistitorTheoreticalExample
    {
        public static void Run()
        {
            // Set up the object structure
            Element objectStructure = new Element(new Element(new ElementWithLink(new Element(new Element(
                        new ElementWithLink(new Element(null),new Element(null)))),new Element(new Element(new Element(null))))));

            Console.WriteLine("Count the Elements");
            CountVisitor visitor = new CountVisitor();
            visitor.CountElements(objectStructure);
            Console.WriteLine("Number of Elements is: " + visitor.Count);

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();
        }
    }
}



