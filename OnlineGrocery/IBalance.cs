namespace OnlineGrocery
{
    public interface IBalance
    {
        public int WalletBalance { get; set; }
        
        public void WalletRecharge()
        {
            
        }
    }
}