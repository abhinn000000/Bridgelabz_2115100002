using System;
using System.Collections.Generic;
namespace HospitalManagement
{
    class Patient
    {
        public string PatientName { get; set; }

        public Patient(string patientName)
        {
            PatientName = patientName;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Patient Name: " + PatientName);
        }
    }

    class Doctor
    {
        public string DoctorName { get; set; }
        private List<Patient> Patients { get; set; }

        public Doctor(string doctorName)
        {
            DoctorName = doctorName;
            Patients = new List<Patient>();
        }

        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public void Consult(Patient patient)
        {
            Console.WriteLine(DoctorName + " is consulting Patient " + patient.PatientName);
        }

        public void DisplayPatients()
        {
            Console.WriteLine("Patients under " + DoctorName + ":");
            foreach (var patient in Patients)
            {
                patient.DisplayDetails();
            }
        }
    }

    class Hospital
    {
        public string HospitalName { get; set; }
        private List<Doctor> Doctors { get; set; }

        public Hospital(string hospitalName)
        {
            HospitalName = hospitalName;
            Doctors = new List<Doctor>();
        }

        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Hospital Name: " + HospitalName);
            Console.WriteLine("Doctors:");
            foreach (var doctor in Doctors)
            {
                doctor.DisplayPatients();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Hospital hospital = new Hospital("City Hospital");

            Doctor doc1 = new Doctor("Dr. Jhatka");
            Doctor doc2 = new Doctor("Dr. Haathi");

            Patient pat1 = new Patient("Sujal");
            Patient pat2 = new Patient("Vedant");

            doc1.AddPatient(pat1);
            doc1.AddPatient(pat2);
            doc2.AddPatient(pat1);

            doc1.Consult(pat1);
            doc2.Consult(pat2);

            hospital.AddDoctor(doc1);
            hospital.AddDoctor(doc2);

            hospital.DisplayDetails();
        }
    }
}