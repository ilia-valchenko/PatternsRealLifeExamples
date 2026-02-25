using System;
using Visitor.Documents.Interfaces;
using Visitor.Visitors.Interfaces;

namespace Visitor.Documents
{
    public class ContractDocument : IDocument
    {
        public string Title { get; set; }

        public DateTime Date {  get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
