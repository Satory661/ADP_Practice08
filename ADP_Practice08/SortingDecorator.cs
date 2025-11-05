namespace ADP_Practice08;
public class SortingDecorator: ReportDecorator
{
    public SortingDecorator(IReport report) : base(report)
    { }

    public override string Generate()
    
    {
        var report = base.Generate();
        return $"Value Sorted{report}";
    }
    
}