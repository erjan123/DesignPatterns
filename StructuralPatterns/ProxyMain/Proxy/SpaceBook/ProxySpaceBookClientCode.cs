using System;

partial class SpaceBookSystem
{
    public static void Run()
    {
        Console.WriteLine("SpaceBook Proxy example.");
        Console.WriteLine();

        MySpaceBook me = new MySpaceBook();
        me.Add("Hello world");
        me.Add("Today I worked 18 hours");
        MySpaceBook tom = new MySpaceBook();
        tom.Poke("Judith");
        tom.Add("Judith", "Poor you");
        tom.Add("Off to see the Lion King tonight");

        Console.WriteLine();
        Console.WriteLine("******************************************");
        Console.WriteLine();
    }
}