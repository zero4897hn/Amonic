using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Valid
    {
        public static bool Date(string strDate)
        {
            string[] dateParts = strDate.Split(new char[] { '/', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (dateParts.Length == 3)
            {
                int day = int.Parse(dateParts[0].Trim());
                int month = int.Parse(dateParts[1].Trim());
                int year = int.Parse(dateParts[2].Trim());
                if (year < 1) return false;
                if (month < 1 || month > 12) return false;
                if (day < 1 || day > TotalDayOfMonth(month, year)) return false;
                return true;
            }
            else return false;
        }

        public static bool Time(string strTime)
        {
            string[] timeParts = strTime.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (timeParts.Length == 2)
            {
                int hour = int.Parse(timeParts[0].Trim());
                int minute = int.Parse(timeParts[1].Trim());
                if (hour < 0 || hour > 23) return false;
                if (minute < 0 || minute > 59) return false;
                return true;
            }
            else return false;
        }

        private static int TotalDayOfMonth(int month, int year)
        {
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12: return 31;
                case 2: return (year % 4 == 0 && year % 100 == 0) || year % 400 == 0 ? 29 : 28;
                default: return 30;
            }
        }
    }
}
