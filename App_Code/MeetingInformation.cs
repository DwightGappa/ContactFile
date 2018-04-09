using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for AppointmentInformation
/// </summary>
/// 

namespace ContactFile
{
    public class MeetingInformation
    {
        public ContactInformation AntendeeContactInformation { get; set; }

        public DateTime EndDateTimeOffset { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime StartDateTimeOffset { get; set; }

        public string Summary { get; set; }

        public TimeZoneInfo TimeZoneInfo { get; set; }


        public MeetingInformation()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}