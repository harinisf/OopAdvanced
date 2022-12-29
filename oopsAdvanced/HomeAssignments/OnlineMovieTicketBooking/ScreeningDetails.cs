namespace OnlineMovieTicketBooking
{
    public class ScreeningDetails
    {
        public string MovieID { get; set; }
        public string TheatreID { get; set; }
        public int TicketPrice { get; set; }
        public int SeatAvailablity { get; set; }

        public ScreeningDetails(string theatreID,string movieID,int ticketPrice,int seatAvailablity)
        {
            TheatreID = theatreID;
            MovieID = movieID;
            TicketPrice = ticketPrice;
            SeatAvailablity = seatAvailablity;
        }
    }
}