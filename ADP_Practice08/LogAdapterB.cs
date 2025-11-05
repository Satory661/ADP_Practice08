namespace ADP_Practice08;
public class LogAdapterB: IInternalDelService
{
    private readonly ExtDeliveryServiceB _extDel;
    public LogAdapterB(ExtDeliveryServiceB extDel)
    {
        
        _extDel = extDel;
        
    }

    
    public void DeliveryOrder(string orderId)
    {
        _extDel.SendPackage(orderId);
    }

    
    public void GetDeliveryOrder(string orderId)
    {
        _extDel.CheckPackageStatus(orderId);
    }
}