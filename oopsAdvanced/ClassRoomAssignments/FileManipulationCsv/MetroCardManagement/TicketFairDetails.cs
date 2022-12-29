namespace MetroCardManagement
{
    public class TicketFairDetails
    {
        private static int s_ticketID = 101;
        public string TicketID { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public int Fair { get; set; }

        public TicketFairDetails(string fromLocation,string toLocation,int fair)
        {
            TicketID = "MR"+s_ticketID++;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            Fair = fair;
        }
    }
}