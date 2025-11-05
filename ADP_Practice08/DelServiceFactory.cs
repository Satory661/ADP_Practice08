namespace ADP_Practice08;
public static class DelServiceFactory
{
    public static IInternalDelService CreateDeliveryService(string type)
    {
        switch (type)
        {
            
            case "B":
                return new LogAdapterB(new ExtDeliveryServiceB());
            
            case "A":
                return new LogisticAdapterA(new ExtDeliveryServiceA());
            
            default:
                
                throw new Exception("Chto za service??");
        }
    }
}