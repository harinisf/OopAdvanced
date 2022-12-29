using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
namespace MetroCardManagement;

public class FilesCSV
{
    public static void Create()
    {
        if(!Directory.Exists("MetroCardManagement"))
        {
            Directory.CreateDirectory("MetroCardManagement");
            System.Console.WriteLine("Folder created");
        }
        else{
            System.Console.WriteLine("Folder found");
        }
        if(!Directory.Exists("MetroCard"))
        {
            Directory.CreateDirectory("MetroCard");
        }
        if(!File.Exists("MetroCard/UserDetails.csv"))
        {
            File.Create("MetroCard/UserDetails.csv");
        }
         if(!File.Exists("MetroCard/Travel.csv"))
        {
            File.Create("MetroCard/Travel.csv");
        }
         if(!File.Exists("MetroCard/TicketFair.csv"))
        {
            File.Create("MetroCard/TicketFair.csv");
        }
    }

    public static void ReadFromCSV()
    {
        string[] text1 = FilesCSV.ReadAllLines("MetroCard/UserDetails.csv");
        foreach(string Data in text1)
        {
            UserDetails user = new UserDetails(Data);
            Operation.userList.Add(user);
        }
    }
}

