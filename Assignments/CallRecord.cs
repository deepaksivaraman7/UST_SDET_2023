using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CallRecord
    {
        public CallRecord(int callId, long phoneNumber, TimeOnly callTime)
        {
            CallId = callId;
            PhoneNumber = phoneNumber;
            CallTime = callTime;
        }

        public int CallId { get; set; }
        public long PhoneNumber { get; set; }
        public TimeOnly CallTime { get; set; }
    }
}
