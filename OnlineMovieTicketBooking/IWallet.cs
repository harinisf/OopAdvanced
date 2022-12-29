namespace OnlineMovieTicketBooking
{
    public interface IWallet
    {
        public int WalletBalance { get; set; }

        void RechargeWallet();
    }
}