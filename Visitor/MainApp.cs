using System;
using System.Collections.Generic;
using Visitor.Documents;
using Visitor.Documents.Interfaces;
using Visitor.Visitors;

namespace Visitor
{
    public static class MainApp
    {

        // Note: Visitor Pattern in simple words — it's a way to add new behavior to a group of related objects
        // without changing the objects themselves.

        // When to use?
        // * When you need to perform many different operations on objects of a complex structure.
        // * When the object structure rarely changes, but new operations are added frequently.
        public static void Main()
        {
            var documents = new List<IDocument>
            {
                new InvoiceDocument
                {
                    Number = "INV-001",
                    Amount = 15000
                },
                new ContractDocument
                {
                    Title = "Equipment supply",
                    Date = DateTime.Now
                },
                new ReportDocument
                {
                    Name = "Annual report",
                    Pages = 42
                }
            };

            var pdfVisitor = new PdfExportVisitor();
            var emailSender = new EmailVisitor();

            // Export all documents to PDF
            foreach (var document in documents)
            {
                document.Accept(pdfVisitor);
            }

            // Send all documents by email
            foreach (var document in documents)
            {
                document.Accept(emailSender);
            }
        }
    }
}
