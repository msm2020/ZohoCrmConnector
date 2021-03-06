﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    public class Events
    {
        public string ACTIVITYID { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }

        public string Event_Owner { get; set; }
        public string Subject { get; set; }
        public string Start_DateTime { get; set; }
        public string End_DateTime { get; set; }
        public string Venue { get; set; }
        public string CONTACTID { get; set; }
        public string Contact_Name { get; set; }
        public string RELATEDTOID { get; set; }
        public string Related_To { get; set; }
        public string Send_Notification_Email { get; set; }
        public string Created_By { get; set; }
        public string Modified_By { get; set; }
        public string Recurring_Activity { get; set; }
        public string Description { get; set; }

        public string SEMODULE { get; set; }
    }
}
