using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Patient
    {
        public Patient(int patientId, string name, int age, string diagnosis)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
            Diagnosis = diagnosis;
        }

        public int PatientId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Diagnosis { get; set; }
        public static List<Patient> patients = new();
        public static void AddPatient(Patient patient)
        {

            if (patient.Age < 0 || patient.Age > 120)
            {
                throw new ArgumentException("Age should be between 0 and 100");
            }
            if (patient.Name == "" || patient.Diagnosis == "")
            {
                throw new ArgumentException("Name and diagnosis should not be null");
            }
            else
            {
                patients.Add(patient);
                Console.WriteLine("Added");
            }

        }

    }
}
