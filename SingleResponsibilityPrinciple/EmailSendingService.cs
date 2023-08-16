namespace SingleResponsibilityPrinciple;

// In an email sending service, we can separate the email sending logic from email content generation.

#region Not following SRP
public class EmailServiceWrongWay
{
    public void SendEmail(string to, string subject, string body)
    {
        // Email sending logic
    }

    public void GenerateEmailBody(string content)
    {
        // Generate email body logic
    }
}
#endregion


#region Following SRP
public class EmailSender
{
    public void SendEmail(string to, string subject, string body)
    {
        // Email sending logic
    }
}

public class EmailContentGenerator
{
    public void GenerateEmailBody(string content)
    {
        // Generate email body logic
    }
}
#endregion