namespace OnlineMovieTicketBooking
{
    public class TheatreDetails
    {
        private static int s_theatreID = 301;
        public string TheatreID { get; set; }
        public string TheatreName { get; set; }
        public string TheatreLocation { get; set; }
        
        public TheatreDetails(string theatreName,string theatreLocation)
        {
            TheatreID = "TID"+s_theatreID++;
            TheatreName = theatreName;
            TheatreLocation = theatreLocation;
        }
    }
}