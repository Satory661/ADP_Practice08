using ADP_Practice08;
namespace ADP_Practice08;
internal class Program
{
    
    public static void Main(string[] args)
    
    {
        IReport report = new SalesReport();
        
        report = new SortingDecorator(report);
        
        report = new SortingDecorator(report);
        
        
    }
}