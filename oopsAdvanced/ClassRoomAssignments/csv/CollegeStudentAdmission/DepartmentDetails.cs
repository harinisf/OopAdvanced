using System;
namespace CollegeStudentAdmission
{
    public class DepartmentDetails
    {
        private static int s_departmentID = 101;
        public string DepartmentID { get; set; }
        public string Name { get; set; }
        public int NumberOfSeats { get; set; }

         public DepartmentDetails(string name,int numberOfSeats)
        {
            s_departmentID++;
            DepartmentID = "DID"+s_departmentID;
            Name = name;
            NumberOfSeats = numberOfSeats;
        }
    }
   
}

