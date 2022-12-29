namespace OnlineMovieTicketBooking
{
    public class MovieDetails
    {
        private static int s_movieID = 501;
        public string MovieID { get; set; }
        public string MovieName { get; set; }
        public string Language { get; set; }
        public MovieDetails(string movieName,string language)
        {
            MovieID = "MID"+s_movieID++;
            MovieName = movieName;
            Language = language;
        }
    }
}