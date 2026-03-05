using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace TemplateMethod.DataImporters
{
    public class XmlImporter : BaseDataImporter
    {
        protected override object ParseData(string rawData)
        {
            Console.WriteLine("Parsing XML data...");

            try
            {
                // Load the XML string into an XDocument
                var xDocument = XDocument.Parse(rawData);

                // Optional: Validate basic structure (e.g., root element exists)
                if (xDocument.Root == null)
                {
                    throw new InvalidDataException("XML document has no root element.");
                }

                // In a real import, you might map XML elements to a common record format
                // For example, assume we expect <records><record><field>value</field>...</record>...</records>
                // We'll extract a list of dictionaries for demonstration
                var records = new List<Dictionary<string, string>>();

                // Find all record elements (adjust XPath to your actual schema)
                foreach (var recordElement in xDocument.Descendants("record"))
                {
                    var dictionary = new Dictionary<string, string>();

                    foreach (var field in recordElement.Elements())
                    {
                        dictionary[field.Name.LocalName] = field.Value;
                    }

                    records.Add(dictionary);
                }

                // If you extracted records, you could return them; otherwise return the XDocument
                // For now, we return the XDocument (the later steps must know how to handle it)
                return xDocument;
            }
            catch (XmlException ex)
            {
                throw new InvalidDataException($"Invalid XML format: {ex.Message}", ex);
            }
        }
    }
}
