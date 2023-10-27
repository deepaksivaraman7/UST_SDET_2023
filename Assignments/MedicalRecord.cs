using Assignments.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalRecord : Patient
    {
        public MedicalRecord(int patientId, string? name, int age, string? diagnosis, int recordId, int treatmentCost) : base(patientId, name, age, diagnosis)
        {
            RecordId = recordId;
            TreatmentCost = treatmentCost;
        }

        public int RecordId { get; set; }
        public int TreatmentCost { get; set; }
        public static List<MedicalRecord> medicalRecordList = new();
        public static void AddMedicalRecord(MedicalRecord record)
        {
            if(record.Diagnosis=="" || record.Name == "")
            {
                throw new InvalidPatientDataException(CustomException.dmessagelist["String null"]);
            }
            if (record.TreatmentCost < 0)
            {
                throw new InvalidMedicalRecordException(CustomException.dmessagelist["Negative number"]);
            }
            else
            {
                medicalRecordList.Add(record);
                Console.WriteLine("Added");
            }
        }

    }
}
