using System;
using System.Collections.Generic;
namespace CollegeStudentAdmission;
public class Program
{
    public static void Main(string[] args)
    {
        Files.create();
        //Operatons.DefaultData();
        Files.ReadFromJSON();
        Operatons.MainMenu();
        Files.WriteToJSON();
        
    }
    
 
}