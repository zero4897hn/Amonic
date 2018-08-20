using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BU
{
    public class TimeLoggingManagement
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan LoginTime { get; set; }
        public TimeSpan LogoutTime { get; set; }
        public TimeSpan TimeSpentOnSystem { get; set; }
        public string UnsuccessfulLogoutReason { get; set; }
    }
}
