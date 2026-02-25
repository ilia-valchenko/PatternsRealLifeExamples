using Visitor.Documents.Interfaces;
using Visitor.Visitors.Interfaces;

namespace Visitor.Documents
{
    public class InvoiceDocument : IDocument
    {
        public string Number { get; set; }

        public decimal Amount { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
