using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BU
{
    public class Schedule
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string IATACodeFrom { get; set; }
        public string IATACodeTo { get; set; }
        public string FlightNumber { get; set; }
        public string Aircraft { get; set; }
        public int EconomyPrice { get; set; }
        public bool Confirmed { get; set; }
    }
}
