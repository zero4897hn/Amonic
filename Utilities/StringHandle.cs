using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class StringHandle
    {
        public static string GetConditionOfQuery(string from, string to, string outbound, string flightNumber)
        {
            string sql = "";
            if (from == "All Airport" && to == "All Airport" && outbound == "  /  /" && flightNumber == "") return sql;
            if (from != "All Airport")
            {
                if (sql.Length != 0) sql += " and ";
                sql += "a1.IATACode = '" + from + "'";
            }
            if (to != "All Airport")
            {
                if (sql.Length != 0) sql += " and ";
                sql += "a2.IATACode = '" + to + "'";
            }
            if (outbound != "  /  /")
            {
                string[] dateParts = outbound.Split('/');
                int day = int.Parse(dateParts[0].Trim());
                int month = int.Parse(dateParts[1].Trim());
                int year = int.Parse(dateParts[2].Trim());
                if (sql.Length != 0) sql += " and ";
                sql += "Schedules.Date = '" + year + "-" + month + "-" + day + "'";
            }
            if (flightNumber != "")
            {
                if (sql.Length != 0) sql += " and ";
                sql += "Schedules.FlightNumber = '" + flightNumber + "'";
            }
            return "where " + sql;
        }
    }
}
