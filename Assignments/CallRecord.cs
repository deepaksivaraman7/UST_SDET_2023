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
        public static List<CallRecord> calls = new();
        public static void CallHistory(long phone)
        {
            foreach (var call in calls)
            {
                if (call.PhoneNumber == phone)
                {
                    Console.WriteLine("Call ID: {0}   Call Time: {1}", call.CallId, call.CallTime);
                }
            }
        }
        public static void TotalCalls()
        {
            Dictionary<long, int> dict = new();
            int count = 1;
            foreach (var call in calls)
            {
                if (!dict.ContainsKey(call.PhoneNumber))
                {
                    dict[call.PhoneNumber] = count;
                }
                else
                {
                    dict[call.PhoneNumber] += 1;
                }
            }
            foreach (var number in dict)
            {
                Console.WriteLine("Phone Number: {0}   Number of calls: {1}", number.Key, number.Value);
            }
        }
    }
}
