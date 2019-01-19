// Visitor Pattern - Example Judith Bishop October 2007
// Sets up an object structure and visits it

namespace ObjectStructure
{
    class Element : IElement
    {
        public Element Next { get; set; }
        public Element Link { get; set; }
        public Element() { }
        public Element(Element next)
        {
            Next = next;
        }
        // Added to make the elements Visitor-ready
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
