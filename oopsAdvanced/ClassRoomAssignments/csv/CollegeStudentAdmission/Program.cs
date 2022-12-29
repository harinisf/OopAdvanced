using System;
using System.Collections.Generic;
namespace CollegeStudentAdmission;
public class Program
{
    public static void Main(string[] args)
    {
        Files.create();
        Files.ReadFromJSON();
        Operatons.MainMenu();
        Files.WriteToCSV();
        
    }
    
 
}