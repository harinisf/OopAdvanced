namespace OnlineGrocery
{
    public class ProductDetails
    {
        private static int s_productID = 101;
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        public int PricePerQuantity { get; set; }

        public ProductDetails(string productName,int quantityAvailable,int pricePerQuantity)
        {
            ProductID = "PID"+s_productID++;
            ProductName = productName;
            QuantityAvailable = quantityAvailable;
            PricePerQuantity = pricePerQuantity;
        }
    }
}