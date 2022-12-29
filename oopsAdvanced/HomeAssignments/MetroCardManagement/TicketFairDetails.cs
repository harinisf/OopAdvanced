namespace MetroCardManagement
{
    public class TicketFairDetails
    {
        private static int s_ticketID = 101;
        public string TicketID { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public int Fair { get; set; }

        public TicketFairDetails(string data)
        {
            string []values = data.Split(",");
            s_ticketID = int.Parse(values[0].Remove(0,2));
            TicketID = values[0];
            FromLocation = values[1];
            ToLocation = values[2];
            Fair = int.Parse(values[3]);
        }
        public TicketFairDetails(string fromLocation,string toLocation,int fair)
        {
            TicketID = "MR"+s_ticketID++;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            Fair = fair;
        }
    }
}