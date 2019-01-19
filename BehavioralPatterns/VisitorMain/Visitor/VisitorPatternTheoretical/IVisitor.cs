using ObjectStructure;
// Visitor interface
interface IVisitor
    {
        void Visit(Element element);
        void Visit(ElementWithLink element);
    }
