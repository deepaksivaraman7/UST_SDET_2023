﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class TeachingStaff:StaffDetails
    {
        public string? Specializations { get; set; }
        public int Sem { get; set; }
        public void DisplayStaffDetails()
        {
            Console.WriteLine("Spec: {0}\nSem: {1}", Specializations, Sem);
        }

    }
}
