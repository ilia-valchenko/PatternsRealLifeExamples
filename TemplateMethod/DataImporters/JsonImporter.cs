using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TemplateMethod.DataImporters
{
    public class JsonImporter : BaseDataImporter
    {
        protected override object ParseData(string rawData)
        {
            Console.WriteLine("Parsing JSON data...");

            try
            {
                // Parse the raw JSON string into a JsonDocument
                using (JsonDocument document = JsonDocument.Parse(rawData))
                {
                    JsonElement root = document.RootElement;

                    // Expect the root to be an array
                    if (root.ValueKind != JsonValueKind.Array)
                    {
                        throw new InvalidDataException("JSON root is not an array.");
                    }

                    var records = new List<Dictionary<string, string>>();

                    foreach (JsonElement element in root.EnumerateArray())
                    {
                        if (element.ValueKind != JsonValueKind.Object)
                        {
                            throw new InvalidDataException("Array element is not a JSON object.");
                        }

                        var record = new Dictionary<string, string>();

                        // Iterate over all properties in the object
                        foreach (JsonProperty property in element.EnumerateObject())
                        {
                            // Convert property value to string (handling nulls)
                            string value = property.Value.ValueKind == JsonValueKind.Null
                                ? null
                                : property.Value.ToString();

                            record[property.Name] = value;
                        }

                        records.Add(record);
                    }

                    return records;
                }
            }
            catch (JsonException ex)
            {
                throw new InvalidDataException($"Invalid JSON format: {ex.Message}", ex);
            }
        }
    }
}
