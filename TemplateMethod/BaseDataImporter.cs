using System;

namespace TemplateMethod
{
    // Abstract base class (the template)
    public abstract class BaseDataImporter
    {
        public void Import(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("The file path is null or a white-space.", nameof(filePath));
            }

            this.OpenFile(filePath);
            string rawData = this.ReadFile();
            var parsedData = this.ParseData(rawData);
            this.ValidateData(parsedData);
            this.SaveToDatabase(parsedData);
            this.CloseFile();
        }

        protected virtual void OpenFile(string filePath)
        {
            Console.WriteLine($"Opening file: '{filePath}'.");

            // TODO: Actual file opening logic.
        }

        protected virtual string ReadFile()
        {
            Console.WriteLine("Reading raw data from file...");

            // TODO: Simulate reading.

            return "raw;data;example";
        }

        // NOTE: Must be implemented by subclasses.
        protected abstract object ParseData(string rawData);

        protected virtual void ValidateData(object data)
        {
            Console.WriteLine("Validating data (common validation).");

            // TODO: Common validation logic.
        }

        protected virtual void SaveToDatabase(object data)
        {
            Console.WriteLine("Saving data to database...");

            // TODO: Common save logic.
        }

        protected virtual void CloseFile()
        {
            Console.WriteLine("Closing file");
        }
    }
}
