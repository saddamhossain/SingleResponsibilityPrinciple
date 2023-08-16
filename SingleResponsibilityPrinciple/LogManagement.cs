namespace SingleResponsibilityPrinciple;

// In a logging system, we can separate different types of logging (e.g., file logging, database logging).

#region Not following SRP
public class Logger
{
    public void LogToFile(string message)
    {
        // Log to file logic
    }

    public void LogToDatabase(string message)
    {
        // Log to database logic
    }
}
#endregion


#region Following SRP
public class FileLogger
{
    public void LogToFile(string message)
    {
        // Log to file logic
    }
}

public class DatabaseLogger
{
    public void LogToDatabase(string message)
    {
        // Log to database logic
    }
}
#endregion
