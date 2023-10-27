using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalHistory
    {
        public MedicalHistory(int recordId, int patientId, string? description, DateOnly date)
        {
            RecordId = recordId;
            PatientId = patientId;
            Description = description;
            Date = date;
        }

        public int RecordId { get; set; }
        public int PatientId { get; set; }
        public string? Description { get; set; }
        public DateOnly Date { get; set; }
        public static List<MedicalHistory> medicalHistoryList = new();
        public static void AddMedicalHistoryToList(MedicalHistory medicalHistory)
        {
                medicalHistoryList.Add(medicalHistory);
                Console.WriteLine("Added to list");
        }
        public static void CreateMedicalHistory()
        {
            _ = new FileStream("D:\\Training Handson\\Basic Solution\\Assignments\\Files\\MedicalHistory.txt", FileMode.Create, FileAccess.Write);

        }
        public static void AddMedicalHistory(MedicalHistory medicalHistory)
        {

            FileInfo fi = new("D:\\Training Handson\\Basic Solution\\Assignments\\Files\\MedicalHistory.txt");
            if (!fi.Exists)
            {
                CreateMedicalHistory();
            }
            else
            {
                using StreamWriter str = fi.AppendText();
                str.Write("Record ID: " + medicalHistory.RecordId + "  ");
                str.Write("Patient ID: " + medicalHistory.PatientId + "  ");
                str.Write("Description: " + medicalHistory.Description + "  ");
                str.Write("Date: " + medicalHistory.Date);
                str.WriteLine(" ");
                Console.WriteLine("Created medical record");
            }
        }
        public static void ViewMedicalHistory(int patientId)
        {

            FileInfo fi = new("D:\\Training Handson\\Basic Solution\\Assignments\\Files\\MedicalHistory.txt");
            if (fi.Exists)
            {
                FileStream fs = new("D:\\Training Handson\\Basic Solution\\Assignments\\Files\\MedicalHistory.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new(fs);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                string? str = sr.ReadLine();
                int flag = 0;
                while (str != null)
                {
                    if (str.Split("  ")[1]=="Patient ID: "+patientId)
                    {
                        Console.WriteLine(str);
                        flag = 1;
                    }
                    str = sr.ReadLine();
                }
                
                sr.Close();
                fs.Close();
                if (flag == 0)
                {
                    Console.WriteLine("No record found for the Patient ID");
                }
                
            }
            else
            {
                Console.WriteLine("No files found, create one file to view");
            }
        }
    }
}
