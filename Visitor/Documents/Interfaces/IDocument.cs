using Visitor.Visitors.Interfaces;

namespace Visitor.Documents.Interfaces
{
    public interface IDocument
    {
        void Accept(IVisitor visitor);
    }
}
