
namespace MetroCardManagement
{
    public class UserDetails
    {
        private static int s_cardNumber = 101;
        private int _balance = 0;
        public string CardNumber { get; set; }
        public string UserName { get; set; } 
        public long PhoneNumber { get; set; }
        public int Balance { get; set; }

        public UserDetails(){}

        public UserDetails(string userName,long phoneNumber,int balance)
        {
            CardNumber = "CMRL"+s_cardNumber++;
            UserName = userName;
            PhoneNumber = phoneNumber;
            Balance = balance;
        }

        public UserDetails(string data)
        {
            string []values = data.Split(",");
            s_cardNumber = int.Parse(values[0].Remove(0,2));
            CardNumber = values[0];
            UserName = values[1];
            PhoneNumber = long.Parse(values[2]);
            Balance = int.Parse(values[3]);
        }
        public int Recharge(int recharge)
        {
            _balance = Balance;
            _balance += recharge;
            return _balance;
        }
    }
    
}