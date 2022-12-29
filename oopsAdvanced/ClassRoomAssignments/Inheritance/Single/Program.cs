using System;
namespace Single;
class Program
{
    public static void Main(string[] args)
    {
        //personal details
        PersonalDetails personal = new("Harini","Kr","female",new DateTime(2001,11,11));
        System.Console.WriteLine("Aadhar ID"+personal.AadharID+"Name "+personal.Name+"Father Name"+personal.FatherName);
        System.Console.WriteLine("Gender "+personal.Gender+"DOB"+personal.DOB.ToString("dd/MM/yyyy"));

        //student Registration
        StudentDetails student = new(1001,"harini","kannan","female",new DateTime(2001,11,11),"I");
        System.Console.WriteLine("Student ID"+student.StudentID+"Aadhar ID"+student.AadharID+"Name "+student.Name+"Father Name"+student.FatherName);
        System.Console.WriteLine("Gender "+student.Gender+"DOB"+student.DOB.ToString("dd/MM/yyyy")+"Standard"+student.Standard);
    }
}
