namespace Session09_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Q2. In Main, create two Patient objects with the same values, then*/
            //Patient p1 = new Patient(1, "NourShabana", "01234", "abc");
            //Patient p2 = new Patient(1, "NourShabana", "01234", "abc");

            //Console.WriteLine(p1.GetHashCode());//hashcode deference they dont have same reference
            //Console.WriteLine(p2.GetHashCode());
            //Console.WriteLine(p1.Equals(p2));//false same reason of hashcode
            //p1 = p2;
            //Console.WriteLine(p1.Equals(p2));//true they have same refrence

            //PatientDto p3 = new PatientDto(1, "NourShabana", "0123");
            //PatientDto p4 = new PatientDto(1, "NourShabana", "0123");
            //Console.WriteLine(p3.GetHashCode());//hashcode true they  record is desined for value equality if value not same the hashecode will not same 
            //Console.WriteLine(p4.GetHashCode());
            //Console.WriteLine(p3.Equals(p4));//true same reason of hashcode

            //PatientDto rp= PatientMapper.MapFromModelToDto(p1); //convert p1 to record of patientdto
            //Console.WriteLine(rp);// return the record rb


            // ---------------- Part2 ------------designpattern (Singleton)
            //AppLogger loog = AppLogger.GetLogger();
            //AppLogger loog1 = AppLogger.GetLogger();
            //AppLogger loog2 = AppLogger.GetLogger();
            //AppLogger loog3 = AppLogger.GetLogger();

            //Console.WriteLine(loog.GetHashCode());
            //Console.WriteLine(loog1.GetHashCode());    ///have same hashcode they pointers in same object this is singletone dessign patern
            //Console.WriteLine(loog2.GetHashCode());
            //Console.WriteLine(loog3.GetHashCode());

            //-------------------------Part 3 — var & dynamic----------------------------
            //Patient patient=new Patient(1, "NourShabana", "01234", "abc");

            // var patient_1= new Patient(1, "NourShabana1", "01234", "abc");//----resolved in compile time 

            // dynamic patient2; ///--------resolved in runtime by CLR
            // patient2 = patient;

            // Console.WriteLine(patient2);
            // Console.WriteLine(patient_1);


            /* ----------------------------Part 4 — Anonymous Types-------------*/
            //var doctor01 = new
            //{
            //    Name = "Sara",
            //    Specialty = "Cardiology1",
            //    ExperienceYears = 8,
            //    Salary = 25_000
            //};
            //var doctor02 = new
            //{
            //    Name = "Sara",
            //    Specialty = "Cardiology",
            //    ExperienceYears = 8,
            //    Salary = 25_000
            //};

            //Console.WriteLine(doctor01.Name);
            //Console.WriteLine(doctor01.Specialty);
            //Console.WriteLine(doctor01.GetHashCode());
            //Console.WriteLine(doctor02.GetHashCode());
            //Console.WriteLine(doctor01.GetType());
            //Console.WriteLine(doctor01.Equals(doctor02));
            //Console.WriteLine(doctor01.ToString());

            /*1. Anonymous Types 
                 *    - Type of Equality: VALUE EQUALITY.
                 *    - The C# compiler automatically overrides Equals() and GetHashCode() for anonymous types.
                 * 2. Standard Classes 
                 *    - Type of Equality: REFERENCE EQUALITY (by default).
                
                 * 3. Records (record Person(string Name, int Age)):
                 *    - Type of Equality: VALUE EQUALITY (Compiler-Generated).
                 *    - The compiler automatically overrides Equals(), GetHashCode(), and the == / != operators.*/


            //--------------Part 5 — Extension Methods---------------------------------

            bool isshorterthan = TextHelper.IsShorterThan("Stethoscope", 5);
            Console.WriteLine(isshorterthan);

            isshorterthan = "Stethoscope".IsShorterThan(13);
            Console.WriteLine(isshorterthan);
            
            string reapeat4times="Ab".Repeat(4);
            Console.WriteLine(reapeat4times);





        }
    }
}
