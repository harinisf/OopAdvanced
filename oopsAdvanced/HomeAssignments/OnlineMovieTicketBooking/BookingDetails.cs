namespace OnlineMovieTicketBooking
{
    public enum BookingStatus{Select,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID = 7001;
        public string BookID { get; set; }
        public string UserID { get; set; }
        public string MovieID { get; set; }
        public string TheatreID { get; set; }
        public int SeatCount { get; set; }
        public int TotalAmount { get; set; }
        public BookingStatus BookingStatus{ get; set; }

        public BookingDetails(string userID,string movieID,string theatreID,int seatCount,int totalAmount,BookingStatus bookingStatus)
        {
            BookID = "BID"+s_bookingID++;
            UserID = userID;
            MovieID = movieID;
            TheatreID = theatreID;
            SeatCount = seatCount;
            TotalAmount = totalAmount;
            BookingStatus = bookingStatus;
        }
    }
}