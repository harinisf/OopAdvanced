namespace OnlineMovieTicketBooking
{
    public class UserDetails
    {
        private static int s_userID = 1001;
        public string UserID { get; set; }
        private int _balance = 0;
        public string Name { get; set; }
        public int Age { get; set; }
        public long PhoneNumber { get; set; }
        public int WalletBalance { get; set; }

        public UserDetails(string name,int age,long phoneNumber,int walletBalance)
        {
            UserID = "UID"+s_userID++;
            Name = name;
            Age = age;
            PhoneNumber = phoneNumber;
            WalletBalance = walletBalance;
        }
        public int RechargeWallet(int TotalAmount)
        {
            _balance = WalletBalance;
            _balance += TotalAmount;
            return _balance;
        }
    }
}