using System;
namespace MetroCardManagement
{
    public class Travel
    {
        private static int s_travelID = 101;
        public string TravelID { get; set; }
        public string CardNumber { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime DateTime {get; set; }
        public int TravelCost { get; set; }

        public Travel(string cardNumber,string fromLocation,string toLocation,DateTime dateTime,int travelCost)
        {
            TravelID = "TID"+s_travelID++;
            CardNumber = cardNumber;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            DateTime = dateTime;
            TravelCost = travelCost;
        }
    }
}