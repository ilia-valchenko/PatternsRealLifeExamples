using System;
using Visitor.Documents;
using Visitor.Visitors.Interfaces;

namespace Visitor.Visitors
{
    public class EmailVisitor : IVisitor
    {
        public void Visit(InvoiceDocument invoice)
        {
            Console.WriteLine($"Sending invoice #{invoice.Number} by email.");
        }

        public void Visit(ContractDocument contract)
        {
            Console.WriteLine($"Sending '{contract.Title}' contract by email.");
        }

        public void Visit(ReportDocument report)
        {
            Console.WriteLine($"Sending '{report.Name}' report by email.");
        }
    }
}
