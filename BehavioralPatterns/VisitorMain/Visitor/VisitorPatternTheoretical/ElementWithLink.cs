// Visitor Pattern - Example Judith Bishop October 2007
// Sets up an object structure and visits it

namespace ObjectStructure
{
    class ElementWithLink : Element
    {
        public ElementWithLink(Element link, Element next)
        {
            Next = next;
            Link = link;
        }
        // Added to make the elements Visitor-ready
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
