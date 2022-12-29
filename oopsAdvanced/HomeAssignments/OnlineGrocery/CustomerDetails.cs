using System;
namespace OnlineGrocery
{
    public class CustomerDetails:PersonalDetails,IBalance
    {
        private static int s_customerID = 1001;
        public string CustomerID { get; set; }
        public int WalletBalance { get; set; }

        public CustomerDetails(string name,string fatherName,Gender gender,long mobile,DateTime dob,string mailID,int walletBalance):base(name,fatherName,gender,mobile,dob,mailID)
        {
            CustomerID = "CID"+s_customerID++;
            WalletBalance = walletBalance;
        }

        public void ShowCustomerDetails()
        {

        }

        public void WalletRecharge()
        {

        }
    }
}