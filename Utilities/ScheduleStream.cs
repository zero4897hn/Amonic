using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class ScheduleStream
    {
        public string Operation { get; set; }
        public DateTime DepartureDate { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureAirportIATACode { get; set; }
        public string ArrivalAirportIATACode { get; set; }
        public string AircraftCode { get; set; }
        public double EconomyPrice { get; set; }
        public bool Confirmation { get; set; }
    }
}
