using System;

// Template method lets subclasses redefine certain steps of an algorithm without changing its structure.
// Template Method pattern demo consolidated into Program.cs
// GoF roles:
// - Abstract class: DataProcessor (defines template method Process())
// - Concrete classes: CsvProcessor, JsonProcessor override primitive operations

public abstract class DataProcessor
{
    // Template method
    public void Process()
    {
        ReadData();
        ProcessData();
        SaveData();
    }

    protected abstract void ReadData();
    protected abstract void ProcessData();
    protected abstract void SaveData();
}

public class CsvProcessor : DataProcessor
{
    protected override void ReadData() => Console.WriteLine("CsvProcessor: Reading CSV data");
    protected override void ProcessData() => Console.WriteLine("CsvProcessor: Processing CSV data");
    protected override void SaveData() => Console.WriteLine("CsvProcessor: Saving CSV data");
}

public class JsonProcessor : DataProcessor
{
    protected override void ReadData() => Console.WriteLine("JsonProcessor: Reading JSON data");
    protected override void ProcessData() => Console.WriteLine("JsonProcessor: Transforming JSON data");
    protected override void SaveData() => Console.WriteLine("JsonProcessor: Persisting JSON data");
}

// Demo
Console.WriteLine("-- Template Method: CSV --");
new CsvProcessor().Process();
Console.WriteLine("-- Template Method: JSON --");
new JsonProcessor().Process();
