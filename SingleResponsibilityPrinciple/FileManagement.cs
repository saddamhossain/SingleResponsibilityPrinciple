namespace SingleResponsibilityPrinciple;

// Suppose we have a class that's responsible for both reading and writing data to a file. To adhere to SRP, we can separate these responsibilities.

#region Not following SRP
public class FileReadWrite
{
    public void ReadFromFile(string filePath)
    {
        // Read from file logic
    }

    public void WriteToFile(string filePath, string content)
    {
        // Write to file logic
    }
}
#endregion


#region Following SRP
public class FileReader
{
    public void ReadFromFile(string filePath)
    {
        // Read from file logic
    }
}

public class FileWriter
{
    public void WriteToFile(string filePath, string content)
    {
        // Write to file logic
    }
}
#endregion