using System;
using ObjectStructure;
// Visitor
class CountVisitor : IVisitor
{
    public int Count { get; set; }
    public void CountElements(Element element)
    {
        element.Accept(this);
        if (element.Link != null) CountElements(element.Link);
        if (element.Next != null) CountElements(element.Next);
    }

    //Elements with links are not counted
    public void Visit(ElementWithLink element)
    {
        Console.WriteLine("Not counting");
    }

    // Only Elements are counted
    public void Visit(Element element)
    {
        Count++;
    }
}
