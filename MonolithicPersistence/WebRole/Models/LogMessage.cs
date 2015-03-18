﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebRole.Models
{
    [DataContract]
    public class LogMessage
    {
        [DataMember]
        public string LogId { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public DateTime LogTime { get; set; }

        public LogMessage()
        {
            LogId = Guid.NewGuid().ToString();
            Message = "My Log Message " + new Random().Next();
            LogTime = DateTime.UtcNow;
        }
    }
}