using System;
namespace AbstractClasses
{
    public class Syncfusion
    {
        //Abstract property definitions
        public override string Name {get{return name;} set {name = value;}}
        //Abstract method defnitions
        public override double Salary(int dates)
        {
            Amount = (double)dates*500;
            return Amount;
        }
    }
}