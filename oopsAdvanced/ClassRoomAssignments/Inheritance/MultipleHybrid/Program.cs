using System;
namespace MultipleHybrid;
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
        student.GetMarks(90,90,90);
        student.Calculate();
        System.Console.WriteLine("Mark 1"+student.Mark1+"Mark 2"+student.Mark2+"Mark 3"+student.Mark3);

        //Ration details
        String[] family = {"Harini - 21","kannan - 50"};
        RationDetails ration = new(112,"harini","kannan","female",new DateTime(2000,11,11),family);
        System.Console.WriteLine("Ration ID"+ration.CardID+"Aadhar ID"+ration.AadharID+"Name "+ration.Name+"Father Name"+ration.FatherName);
        System.Console.WriteLine("Gender "+ration.Gender+"DOB"+ration.DOB.ToString("dd/MM/yyyy")+"Standard"+student.Standard);

        foreach(string member in ration.FamilyMembers)
        {
            System.Console.WriteLine(member);
        }

        //Employment Application
        Employment user = new("SF102",112,"harini","kannan","female",new DateTime(2022,11,11),"XII",DateTime.Now);
        System.Console.WriteLine("Employment ID"+user.EmploymentID+"Student ID"+user.StudentID+"Aadhar ID"+user.AadharID+"Name "+user.Name+"Father Name "+user.FatherName);
        System.Console.WriteLine("Gender "+user.Gender+"DOB"+user.DOB.ToString("dd/MM/yyyy")+"Standar "+user.Standard+"Date of Registration "+user.DateOfRegistration.ToString("dd/MM/yyyy"));
        user.GetMarks(90,90,90);
        user.Calculate();
        System.Console.WriteLine("Mark 1"+student.Mark1+"Mark 2"+student.Mark2+"Mark 3"+student.Mark3);
    }
}
