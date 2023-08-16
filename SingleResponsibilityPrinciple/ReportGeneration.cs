namespace SingleResponsibilityPrinciple;

//  We will separate the generation of different types of reports.

#region Not following SRP
public class ReportGenerator
{
    public void GeneratePDFReport(string data)
    {
        // Generate PDF report logic
    }

    public void GenerateCSVReport(string data)
    {
        // Generate CSV report logic
    }
}
#endregion


#region Following SRP
public class PDFReportGenerator
{
    public void GeneratePDFReport(string data)
    {
        // Generate PDF report logic
    }
}

public class CSVReportGenerator
{
    public void GenerateCSVReport(string data)
    {
        // Generate CSV report logic
    }
}
#endregion