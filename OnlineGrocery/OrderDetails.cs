namespace OnlineGrocery
{
    public class OrderDetails
    {
        private static int s_orderID = 101;
        public string OrderID { get; set; }
        public string BookingID { get; set; }
        public string ProductID { get; set; }
        public int PurchaseCount { get; set; }
        public int PriceOfOrder { get; set; }
        public OrderDetails(string bookingID,string productID,int purchaseCount,int priceOfOrder)
        {
            OrderID = "OID"+s_orderID++;
            BookingID = bookingID;
            ProductID = productID;
            PurchaseCount = purchaseCount;
            PriceOfOrder = priceOfOrder;
        }
    }
}