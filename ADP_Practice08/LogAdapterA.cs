namespace ADP_Practice08;
public class LogAdapterA: IInternalDeliveryService
{
    private readonly ExtDeliveryServiceA _extDeliveryService;
    public LogAdapterA(ExtDeliveryServiceA extDeliveryService)
    {
        _extDeliveryService = extDeliveryService;
    }

    
    public void DeliveryOrder(string orderId)
    {
        int order = Convert.ToInt32(orderId);
        _extDeliveryService.ShipItem(order);
    }
    public void GetDeliveryOrder(string orderId)
    {
        int  order = Convert.ToInt32(orderId);
        _extDeliveryService.TrackShipment(order);
    }
}