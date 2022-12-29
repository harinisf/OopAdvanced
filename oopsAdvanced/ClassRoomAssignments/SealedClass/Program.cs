using System;
namespace SealedClass
{
    public class LivingThings
    {
        public virtual void Eat(){}
    }

    public class Animal:LivingThings
    {
        public new void Eat(){}
    }
    //trying to inhert sealed class
    //produce error in code
    public class Dog:Animal
    {
        public override void Eat(){}
        
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
