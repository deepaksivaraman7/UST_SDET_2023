using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Doctor:Calculation,IDoctor,IAppointment
    {
        public int Did { get; set; }
        public string? DName { get; set; }

        public void AddNewDoctor(int did,string? dname)
        {
            Did = did;
            DName = dname;

        }

        public void ModifyDoctor(int did, string? dname)
        {
            Did = did;
            DName = dname;
        }
        public void DisplayDoctorDetails()
        {
            Console.WriteLine("Doctor Id: {0}\nDoctor name:{1}", Did, DName);
        }

        public void BookApp(int did, string? pname)
        {
            Console.WriteLine("Booked appointment for {0} with {1}", pname, did);
        }

        public void DelApp(string? pname)
        {
            Console.WriteLine("Deleted appointment for {0}", pname);

        }
    }
}
