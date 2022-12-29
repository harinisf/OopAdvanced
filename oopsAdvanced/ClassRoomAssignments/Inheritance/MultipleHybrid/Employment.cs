using System;
namespace MultipleHybrid
{
    public class Employment:StudentDetails
    {
        private static int s_employmentID = 100;
        public string EmploymentID { get; set; }
        public DateTime DateOfRegistration { get; set; }

        public Employment(string StudentID,int aadharID,string name,string fatherName,string gender,DateTime dob,string standard,DateTime dateOfRegistration):base(StudentID,aadharID,name,fatherName,gender,dob,standard)
        {
            EmploymentID = "ER"+s_employmentID;
            DateOfRegistration = dateOfRegistration;
        }
    }
}