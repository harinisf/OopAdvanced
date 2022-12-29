using System;
namespace OverRiding;
class Prgram
{
    public static void Main(string[] args)
    {
        Animalcs animal = new Animalcs(); animal.Eat();
        //object of derived class
        Dog labrador = new Dog();labrador.Eat();
        Pomerian pomerian = new Pomerian();
        pomerian.Eat();
        new Pomerian.Eat();
    }
}