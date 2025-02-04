using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Patient
    {
        //Attributes
        private static string HospitalName= "Swarg Hospital";
        private static int TotalPatients = 0;
        private string Name;
        private int Age;
        private string Ailment;
        private readonly int PatientID;

        //Constructor
        public Patient(string Name,int Age, string Ailment,int PatientID) {
            this.Name = Name;
            this.Age = Age;
            this.Ailment = Ailment;
            this.PatientID = PatientID;
            TotalPatients++;
        }

        //Getting the number of total patients
        public static void GetTotalPatients() {
            Console.WriteLine("The total number of patients is " + TotalPatients);
        }

        //diplaying the hospital name
        public static void DisplayHospitalName() {
            Console.WriteLine("The name of the hospital is " + HospitalName);
        }

        //Displaying Details
        public void DisplayDetails()
        {
            if (this is Patient) // to check if the instance is the object of the Patients class
            {
                Console.WriteLine("The name of the patient is " + Name);
                Console.WriteLine("The age of the patient is " + Age);
                Console.WriteLine("The ailment of the patient is " + Ailment);
                Console.WriteLine("The Patient ID is " + PatientID);
            }

        }
    }

    class program21
    {
        public static void Main(String[] args)
        {
            Patient.DisplayHospitalName();

            Patient patient1 = new Patient("Ashwin", 78, "Arthritis", 3456);
            patient1.DisplayDetails();

            Patient.GetTotalPatients();
        }
    }
}
