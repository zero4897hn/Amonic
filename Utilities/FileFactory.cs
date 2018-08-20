using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Utilities
{
    public class FileFactory
    {
        public static int MissingFieldCount { get; set; }
        public static int SuccessfullyChangesCount { get; set; }
        public static int DuplicateRecordCount { get; set; }
        public static List<ScheduleStream> ImportScheduleFromTextFile(string path)
        {
            List<ScheduleStream> ScheduleStreams = new List<ScheduleStream>();
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(path, Encoding.UTF8);
                while (true)
                {
                    string readLine = streamReader.ReadLine();
                    if (readLine == null) break;
                    string[] str = readLine.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (str.Length == 9)
                    {
                        try
                        {
                            ScheduleStream scheduleStream = new ScheduleStream();
                            scheduleStream.Operation = str[0];
                            string[] dateParts = str[1].Split('-');
                            int year = int.Parse(dateParts[0]);
                            int month = int.Parse(dateParts[1]);
                            int day = int.Parse(dateParts[2]);
                            scheduleStream.DepartureDate = new DateTime(year, month, day);
                            scheduleStream.DepartureTime = TimeSpan.Parse(str[2]);
                            scheduleStream.FlightNumber = str[3];
                            scheduleStream.DepartureAirportIATACode = str[4];
                            scheduleStream.ArrivalAirportIATACode = str[5];
                            scheduleStream.AircraftCode = str[6];
                            scheduleStream.EconomyPrice = double.Parse(str[7]);
                            scheduleStream.Confirmation = str[8] == "OK" ? true : false;
                            ScheduleStreams.Add(scheduleStream);
                        }
                        catch (Exception)
                        {
                            MissingFieldCount++;
                        }
                    }
                    else MissingFieldCount++;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                streamReader.Close();
            }
            return ScheduleStreams;
        }
    }
}
