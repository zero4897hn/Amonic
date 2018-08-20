using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using Utilities;

namespace BU
{
    public class SqlDataAccession
    {
        SqlDataExecution execution = new SqlDataExecution();

        public bool LoginCheck(string username, string password)
        {
            SqlDataReader reader = null;
            try
            {
                execution.OpenConnection("Session1");
                string sql = "select * from Users where Email = @pa0 and Password = @pa1";
                reader = execution.Reader(sql, username, password);
                if (reader.Read()) return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
        }

        public List<string> AirportIATACodeList()
        {
            List<string> Airports = new List<string>();
            SqlDataReader reader = null;
            try
            {
                execution.OpenConnection("Session3");
                reader = execution.Reader("select IATACode from Airports");
                while (reader.Read()) Airports.Add(reader[0] + "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
            return Airports;
        }

        public List<string> CabinTypeList()
        {
            List<string> CabinTypes = new List<string>();
            SqlDataReader reader = null;
            try
            {
                execution.OpenConnection("Session3");
                reader = execution.Reader("select Name from CabinTypes");
                while (reader.Read()) CabinTypes.Add(reader[0] + "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
            return CabinTypes;
        }

        public void UpdateSchedule(int ID, DateTime date, TimeSpan time, int economyPrice)
        {
            try
            {
                execution.OpenConnection("Session2");
                execution.NonQuery("update Schedules set Date = @pa0, Time = @pa1, EconomyPrice = @pa2 where ID = @pa3", date, time, economyPrice, ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Schedule> ScheduleList(string from, string to, int sortByIndex, string outbound, string flightNumber)
        {
            string[] sortBy = { "Schedules.Date, Schedules.Time", "Schedules.EconomyPrice", "Schedules.Confirmed" };
            List<Schedule> Schedules = new List<Schedule>();
            SqlDataReader reader = null;
            try
            {
                execution.OpenConnection("Session2");
                string sql = "select Schedules.ID, Schedules.Date, Schedules.Time, a1.IATACode as 'From', a2.IATACode as 'To', Schedules.FlightNumber, Aircrafts.Name as 'Aircraft', Schedules.EconomyPrice, Schedules.Confirmed from Schedules join Routes on Schedules.RouteID = Routes.ID join Airports a1 on a1.ID = Routes.DepartureAirportID join Airports a2 on a2.ID = Routes.ArrivalAirportID join Aircrafts on Schedules.AircraftID = Aircrafts.ID ";
                string strCondition = StringHandle.GetConditionOfQuery(from, to, outbound, flightNumber);
                string strSort = " order by " + sortBy[sortByIndex] + " desc";
                reader = execution.Reader(sql + strCondition + strSort);
                while (reader.Read())
                {
                    Schedule schedule = new Schedule();
                    schedule.ID = (int)reader[0];
                    schedule.Date = (DateTime)reader[1];
                    schedule.Time = (TimeSpan)reader[2];
                    schedule.IATACodeFrom = reader[3] + "";
                    schedule.IATACodeTo = reader[4] + "";
                    schedule.FlightNumber = reader[5] + "";
                    schedule.Aircraft = reader[6] + "";
                    schedule.EconomyPrice = reader.GetSqlMoney(7).ToInt32();
                    schedule.Confirmed = (bool)reader[8];
                    Schedules.Add(schedule);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
            return Schedules;
        }

        public string GetIATACode(string airportName)
        {
            try
            {
                execution.OpenConnection("Session2");
                return execution.Scalar("select IATACode from Airports where Name = @pa0", airportName) + "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> AirportList()
        {
            List<string> Airports = new List<string>();
            SqlDataReader reader = null;
            try
            {
                execution.OpenConnection("Session2");
                reader = execution.Reader("select Name from Airports");
                while (reader.Read()) Airports.Add(reader[0] + "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
            return Airports;
        }

        public void UpdateTimeLoggingManagement(string email, string reason)
        {
            try
            {
                execution.OpenConnection("Session1");
                execution.NonQuery("update TimeLoginManagement set UnsuccessfulLogoutReason = @pa0 where ID = @pa1", reason, GetLastTimeLoggingID(GetUserID(email)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateSchedule(int ID, bool confirm)
        {
            try
            {
                execution.OpenConnection("Session2");
                execution.NonQuery("update Schedules set Confirmed = @pa0 where ID = @pa1", confirm, ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TimeSpan LastLogoutTime(string email)
        {
            try
            {
                execution.OpenConnection("Session1");
                return (TimeSpan)execution.Scalar("select LogoutTime from TimeLoginManagement where ID = " + GetLastTimeLoggingID(GetUserID(email)));
            }
            catch (Exception)
            {
                return new TimeSpan(0, 0, 0);
            }
        }

        public TimeSpan GetLoginTime(string email)
        {
            try
            {
                execution.OpenConnection("Session1");
                return (TimeSpan)execution.Scalar("select LoginTime from TimeLoginManagement where ID = " + +GetLastTimeLoggingID(GetUserID(email)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DateTime GetLoginDate(string email)
        {
            try
            {
                execution.OpenConnection("Session1");
                return (DateTime)execution.Scalar("select Date from TimeLoginManagement where ID = " + GetLastTimeLoggingID(GetUserID(email)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsEmailActive(string email)
        {
            try
            {
                execution.OpenConnection("Session1");
                return (bool)execution.Scalar("select Users.Active from Users where Users.Email = @pa0", email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TimeLoggingManagement> GetTimeLoggingManagement()
        {
            List<TimeLoggingManagement> TimeLoggingManagements = new List<TimeLoggingManagement>();
            SqlDataReader reader = null;
            try
            {
                execution.OpenConnection("Session1");
                reader = execution.Reader("select * from TimeLoginManagement");
                while (reader.Read())
                {
                    TimeLoggingManagement timeLoggingManagement = new TimeLoggingManagement();
                    timeLoggingManagement.ID = (int)reader[0];
                    timeLoggingManagement.UserID = (int)reader[1];
                    timeLoggingManagement.Date = (DateTime)reader[2];
                    timeLoggingManagement.LoginTime = (TimeSpan)reader[3];
                    if (!reader.IsDBNull(4))
                    {
                        timeLoggingManagement.LogoutTime = (TimeSpan)reader[4];
                        timeLoggingManagement.TimeSpentOnSystem = timeLoggingManagement.LogoutTime - timeLoggingManagement.LoginTime;
                    }
                    timeLoggingManagement.UnsuccessfulLogoutReason = reader[5] + "";
                    TimeLoggingManagements.Add(timeLoggingManagement);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
            return TimeLoggingManagements;
        }

        public void InsertIntoTimeLoggingManagement(string email, DateTime loginTime)
        {
            try
            {
                execution.OpenConnection("Session1");
                execution.NonQuery("insert into TimeLoginManagement (ID, UserID, Date, LoginTime) values (@pa0, @pa1, @pa2, @pa3)", GetLastTimeLoggingID() + 1, GetUserID(email), loginTime, loginTime);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetUserID(string email)
        {
            try
            {
                execution.OpenConnection("Session1");
                return (int)execution.Scalar("select ID from Users where Email = @pa0", email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int GetLastTimeLoggingID()
        {
            try
            {
                execution.OpenConnection("Session1");
                return (int)execution.Scalar("select MAX(ID) from TimeLoginManagement");
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public void UpdateUser(string email, int roleID)
        {
            try
            {
                execution.OpenConnection("Session1");
                execution.NonQuery("update Users set RoleID = @pa0 where Email = @pa1", roleID, email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetUserFirstName(string email)
        {
            try
            {
                execution.OpenConnection("Session1");
                return execution.Scalar("select Users.FirstName from Users where Users.Email = @pa0", email) + "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> OfficeList()
        {
            List<string> Offices = new List<string>();
            SqlDataReader reader = null;
            try
            {
                execution.OpenConnection("Session1");
                string sql = "select Offices.Title from Offices";
                reader = execution.Reader(sql);
                while (reader.Read())
                {
                    string office = reader[0] + "";
                    Offices.Add(office);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
            return Offices;
        }

        public string GetUsersRole(string email)
        {
            try
            {
                execution.OpenConnection("Session1");
                string sql = "select Roles.Title from Roles where ID in (select Users.RoleID from Users where Email = @pa0)";
                return execution.Scalar(sql, email) + "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateTimeLoggingManagement(string email, DateTime logoutTime)
        {
            try
            {
                execution.OpenConnection("Session1");
                execution.NonQuery("update TimeLoginManagement set LogoutTime = @pa0 where ID = @pa1", logoutTime, GetLastTimeLoggingID(GetUserID(email)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetLastTimeLoggingID(int userID)
        {
            try
            {
                execution.OpenConnection("Session1");
                return (int)execution.Scalar("select MAX(ID) from TimeLoginManagement where UserID = " + userID);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public List<User> GetUserFromSQL()
        {
            List<User> Users = new List<User>();
            SqlDataReader reader = null;
            try
            {
                execution.OpenConnection("Session1");
                string sql = "select Users.ID, Users.FirstName, Users.LastName, YEAR(GETDATE()) - YEAR(Users.Birthdate) as 'Age', Roles.Title as 'Role', Users.Email, Offices.Title as 'Office', Users.Active from Users, Roles, Offices where Users.RoleID = Roles.ID and Users.OfficeID = Offices.ID";
                reader = execution.Reader(sql);
                while (reader.Read())
                {
                    User user = new User()
                    {
                        ID = (int)reader[0],
                        FirstName = reader[1] + "",
                        LastName = reader[2] + "",
                        Age = (int)reader[3],
                        UserRole = reader[4] + "",
                        EmailAddress = reader[5] + "",
                        Office = reader[6] + "",
                        Active = (bool)reader[7]
                    };
                    Users.Add(user);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
            return Users;
        }

        public void InsertUser(string email, string password, string firstName, string lastName, int officeID, DateTime birthdate)
        {
            try
            {
                execution.OpenConnection("Session1");
                if (IsEmailExist(email)) throw new Exception(email + " is exist.\r\nPlease choose another email.");
                else execution.NonQuery("insert into Users values (@pa0, @pa1, @pa2, @pa3, @pa4, @pa5, @pa6, @pa7, @pa8)", GetLastUserID() + 1, 2, email, password, firstName, lastName, officeID, birthdate, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool IsEmailExist(string email)
        {
            SqlDataReader reader = null;
            try
            {
                execution.OpenConnection("Session1");
                reader = execution.Reader("select * from Users where Email = @pa0", email);
                if (reader.Read()) return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
        }

        private int GetLastUserID()
        {
            try
            {
                execution.OpenConnection("Session1");
                return (int)execution.Scalar("select MAX(ID) from Users");
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int GetOfficeID(string office)
        {
            try
            {
                execution.OpenConnection("Session1");
                return (int)execution.Scalar("select Offices.ID from Offices where Offices.Title = @pa0", office);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateUser(string email, bool active)
        {
            try
            {
                execution.OpenConnection("Session1");
                return execution.NonQuery("update Users set Active = @pa0 where Email = @pa1", active, email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
