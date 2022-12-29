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

        public Travel(string data)
        {
            string []values = data.Split(",");
            s_travelID = int.Parse(values[0].Remove(0,2));
            CardNumber = values[0];
            FromLocation = values[1];
            ToLocation = values[2];
            DateTime = DateTime.Parse(values[3]);
            TravelCost = int.Parse(values[4]);
        }
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