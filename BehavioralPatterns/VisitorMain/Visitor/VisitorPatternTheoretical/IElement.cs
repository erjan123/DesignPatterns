// Visitor Pattern - Example Judith Bishop October 2007
// Sets up an object structure and visits it

namespace ObjectStructure
{
    abstract class IElement
    {
        // Added to make the elements Visitor-ready
        public abstract void Accept(IVisitor visitor);
    }
}
