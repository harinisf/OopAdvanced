namespace PartialClass
{
    public partial class Employee
    {
        public int EmployeeID {get; set; }
        public string Name {get;set;}
        public partial string ShowName(); //Partial method - used to guide users about the eistence of thos method
        public int ShowID(){return EmployeeID;}//Normal method

        //used to place a class code in separate files or easy programing
        //It behaves like a normal class no restritions
    }
}