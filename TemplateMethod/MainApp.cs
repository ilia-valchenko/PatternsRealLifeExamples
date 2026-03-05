using TemplateMethod.DataImporters;

namespace TemplateMethod
{
    // NOTE: Template Method is a behavioral design pattern that defines the skeleton of an algorithm in the superclass
    // but lets subclasses override specific steps of the algorithm without changing its structure.

    // Why this is useful:
    // * Code reuse: The common workflow is written once in the base class.
    // * Consistency: All importers follow the same steps, ensuring no step is missed.
    // * Flexibility: Subclasses can override any step (even non-abstract ones) if needed.
    // * Easy to add new formats: Just create a new subclass and implement ParseData.
    public static class MainApp
    {
        public static void Main()
        {
            BaseDataImporter dataImporter = new CsvImporter();
            dataImporter.Import("data.csv");

            dataImporter = new XmlImporter();
            dataImporter.Import("data.xml");
        }
    }
}
