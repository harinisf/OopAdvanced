using System;
namespace Hierarchical;
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

        //Ration details
        String[] family = {"Harini - 21","kannan - 50"};
        RationDetails ration = new(112,"harini","kannan","female",new DateTime(2000,11,11),family);
        System.Console.WriteLine("Ration ID"+ration.CardID+"Aadhar ID"+ration.AadharID+"Name "+ration.Name+"Father Name"+ration.FatherName);
        System.Console.WriteLine("Gender "+ration.Gender+"DOB"+ration.DOB.ToString("dd/MM/yyyy")+"Standard"+student.Standard);

        foreach(string member in ration.FamilyMembers)
        {
            System.Console.WriteLine(member);
        }

    }
}
