using System;
using Visitor.Documents;
using Visitor.Visitors.Interfaces;

namespace Visitor.Visitors
{
    public class PdfExportVisitor : IVisitor
    {
        public void Visit(InvoiceDocument invoice)
        {
            Console.WriteLine($"Exporting invoice #{invoice.Number} to PDF.");
        }

        public void Visit(ContractDocument contract)
        {
            Console.WriteLine($"Exporting contract with title '{contract.Title}' to PDF.");
        }

        public void Visit(ReportDocument report)
        {
            Console.WriteLine($"Exporting '{report.Name}' report to PDF.");
        }
    }
}
