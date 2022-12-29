using System;
namespace AbstractClasses
{
    public abstract class Employees
    {
        protected string name; //normal field
        public abstract string Name{get;set;} //Abstract property - Declaration
        public double Amount {get;set;} // Normal property
        public string Display(){return name;}//normal method
        public abstract double Salary(int dates);//abstract Method - only declaration


        //Abstract class - partial abstraction
        //can have both abstract declaration and normal defnitions 
        //can only use with inherited class
        //No objects or constructor for this class
        //not used for multiple inheritance
    }
}