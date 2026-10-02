using System;
using System.Collections.Generic;
using System.Text;

namespace Session09_Assignment
{
    /*Q4. Create a static class PatientMapper with a static method MapFromModelToDto(Patient patient) that returns a
        PatientDto. Use it in Main to convert a Patient and print the result*/
    public static class PatientMapper
    {  
        public static PatientDto MapFromModelToDto(this Patient patient)
        {
           return new PatientDto(patient.Id,patient.FullName,patient.PhoneNumber);
        }
    }
}
