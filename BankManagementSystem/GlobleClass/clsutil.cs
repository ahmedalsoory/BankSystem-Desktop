using System;
using System.Diagnostics;
namespace BankManagementSystem.GlobleClass
{
    public class clsutil
    {
        static string sourceName = "Bank Manngmnt System";
        public static string GetRandomNumber()
        {
            Random r = new Random();
            return r.Next(100000, 999999).ToString();
        }
        public static void EventLoggerEx( string DescriptionError, EventLogEntryType logEntryType)
        {
      
           if (!EventLog.SourceExists(sourceName))
           {
               EventLog.CreateEventSource(sourceName, "Application");
           }
            EventLog.WriteEntry(sourceName, DescriptionError, logEntryType);
        }
    }
}
