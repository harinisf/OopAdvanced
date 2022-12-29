using System;
namespace OnlineGrocery
{
    public enum BookingStatus{Select,Booked,Cancelled,Intiated};
    public class BookingDetails
    {
        private static int s_bookingID = 3001;
        public string BookingID { get; set; }
        public string CustomerID { get; set; }
        public int TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }

        public BookingDetails(string customerID,int totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            BookingID = "BID"+s_bookingID;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfBooking = dateOfBooking;
            BookingStatus = bookingStatus;
        }
    }
}