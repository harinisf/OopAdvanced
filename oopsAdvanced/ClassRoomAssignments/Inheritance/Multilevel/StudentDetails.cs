using System;
namespace Multilevel;
public class StudentDetails:PersonalDetails
{
    private static int s_studentID = 1000;
    public string StudentID { get; set; }

    public string Standard { get; set; }
    public StudentDetails(int aadharID,string name,string fatherName,string gender,DateTime dob,string standard):base(aadharID,name,fatherName,gender,dob)
    {
        s_studentID++;
        StudentID = "SF"+s_studentID;
        Standard = standard;
    }
     public StudentDetails(string studentID,int aadharID,string name,string fatherName,string gender,DateTime dob,string standard):base(aadharID,name,fatherName,gender,dob)
    {
        
        StudentID = studentID;
        Standard = standard;
    }
}
