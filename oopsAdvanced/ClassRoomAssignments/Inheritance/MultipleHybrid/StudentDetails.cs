using System;
namespace MultipleHybrid;
public class StudentDetails:PersonalDetails,IMarkDetails
{
    private static int s_studentID = 1000;
    public string StudentID { get; set; }
    public string Standard { get; set; }
    public int Mark1 {get; set;}
    public int Mark2 {get; set;}
    public int Mark3 {get; set;}
    public double Average { get; set; }
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

    public void GetMarks(int mark1,int mark2,int mark3)
    {
        Mark1 = mark1;
        Mark2 = mark2;
        Mark3 = mark3;
    }

    public void Calculate()
    {
        Average = (double) Mark1+Mark2+Mark3;
    }
}
