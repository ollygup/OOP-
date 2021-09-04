using System;

namespace PassTask3
{
    class Program
    {
        //Print details - that accepts an array (listdetails) and print out all the values 
        public static void PrintDetails(Patient[] patientDetails){
            foreach(Patient detail in patientDetails){
                Console.WriteLine("Patient Name: " + detail.Name);
                Console.WriteLine("Charge: " + detail.Charges);
                Console.WriteLine("Severity: " + detail.Severity);
                Console.WriteLine("Doctor: " + detail.DocInCharge);
                string message = detail.ListDetails();
                Console.WriteLine(message);
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            Patient[] patientArray = new Patient[2];
            patientArray[0] = new Patient("Alice", 1001, "Dr. Gabby", PatientType.InPatient, SeverityLevel.Low, 100, "Sore throat");
            patientArray[1] = new Patient("Peter", 1001, "Dr. Jacey", PatientType.Outpatient, SeverityLevel.Medium, 250, "Chest pain");
        
            PrintDetails(patientArray);
        }
    }
}
