using System;
using System.Collections.Generic;
using System.Text;

namespace Session09_Assignment { 
    /*
     * Q1. Create a class Patient with a primary constructor that takes: Id (int), FullName (string), PhoneNumber (string),
MedicalHistory (string).
Override ToString() to return: Id: {Id} :: FullName: {FullName} :: PhoneNumber: {PhoneNumber} ::
MedicalHistory: {MedicalHistory
     */
    public class Patient(int Id,string FullName,string PhoneNumber,string MedicalHistory)
    {
        public int Id = Id;
        public string FullName = FullName;
        public string PhoneNumber = PhoneNumber;

        public override string ToString()
        {
            return $" Id: {Id} :: FullName: {FullName} :: PhoneNumber: {PhoneNumber} ::  MedicalHistory: {MedicalHistory}";
        }
    }
    /*Q3. Medical history is sensitive. Create a positional record PatientDto that exposes only: Id, FullName, PhoneNumber.*/
    public record PatientDto(int Id, string FullName, string PhoneNumber);
}
