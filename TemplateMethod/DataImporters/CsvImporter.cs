using System;
using System.Collections.Generic;
using System.IO;

namespace TemplateMethod.DataImporters
{
    public class CsvImporter : BaseDataImporter
    {
        protected override object ParseData(string rawData)
        {
            Console.WriteLine("Parsing CSV data...");

            // Split into lines, ignoring empty lines
            var lines = rawData.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            if (lines.Length == 0)
            {
                return new List<Dictionary<string, string>>();
            }

            // Assume first line is header
            var headers = lines[0].Split(',');
            var records = new List<Dictionary<string, string>>();

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');

                if (values.Length != headers.Length)
                {
                    throw new InvalidDataException($"Line {i + 1} has {values.Length} fields, expected {headers.Length}");
                }

                var record = new Dictionary<string, string>();

                for (int j = 0; j < headers.Length; j++)
                {
                    record[headers[j].Trim()] = values[j].Trim();
                }

                records.Add(record);
            }

            return records;
        }
    }
}
