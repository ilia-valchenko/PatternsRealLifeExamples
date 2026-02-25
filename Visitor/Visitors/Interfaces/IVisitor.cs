using Visitor.Documents;

namespace Visitor.Visitors.Interfaces
{
    public interface IVisitor
    {
        void Visit(InvoiceDocument invoice);

        void Visit(ContractDocument contract);

        void Visit(ReportDocument report);
    }
}
