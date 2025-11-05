namespace ADP_Practice08;
public abstract class ReportDecorator: IReport
{
    
    private readonly IReport _report;

    protected ReportDecorator(IReport report)
    {
        _report = report;
    }

    public virtual string Generate()
    {
        return _report.Generate();
        
    }
}