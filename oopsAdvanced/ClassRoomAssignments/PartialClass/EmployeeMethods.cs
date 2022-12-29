using System;
namespace PartialClass
{
     public partial class Employee
    {
        public Employee(int employeeID,string name)
        {
            this.EmployeeID = employeeID;
            this.Name = name;
        }

        public void DisplayEmpinfo()
        {
            System.Console.WriteLine("Employee ID: "+this.EmployeeID+"\t Employee Name "+this.Name);
        }
        //partial method
        public partial string ShowName(){return Name;}
    }
}