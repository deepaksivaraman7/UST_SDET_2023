using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Patient
    {
        public Patient(int patientId, string? name, int age, string? diagnosis)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
            Diagnosis = diagnosis;
        }

        public int PatientId { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Diagnosis { get; set; }
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
        public static void CreatePatientFile()
        {
            FileStream fs = new("D:\\Training Handson\\Basic Solution\\Assignments\\Files\\Patient.txt", FileMode.Create, FileAccess.Write);

        }
        public static void AddPatientRecord(Patient patient)
        {

            FileInfo fi = new("D:\\Training Handson\\Basic Solution\\Assignments\\Files\\Patient.txt");
            if (!fi.Exists)
            {
                CreatePatientFile();
            }
            else
            {
                using StreamWriter str = fi.AppendText();
                str.Write("Patient ID: " + patient.PatientId + "  ");
                str.Write("Patient Name: " + patient.Name + "  ");
                str.Write("Patient Age: " + patient.Age + "  ");
                str.Write("Patient Diagnosis: " + patient.Diagnosis);
                str.WriteLine(" ");
                Console.WriteLine("Created file");
            }
        }
        public static void ViewPatientData()
        {
            FileStream fs = new("D:\\Training Handson\\Basic Solution\\Assignments\\Files\\Patient.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
    }
    
}
