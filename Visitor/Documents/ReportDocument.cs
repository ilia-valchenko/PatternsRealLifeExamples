using Visitor.Documents.Interfaces;
using Visitor.Visitors.Interfaces;

namespace Visitor.Documents
{
    public class ReportDocument : IDocument
    {
        public string Name { get; set; }

        public int Pages { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
