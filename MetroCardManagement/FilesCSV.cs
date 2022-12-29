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
        string[]text1 = File.ReadAllLines("MetroCard/UserDetails.csv");
        foreach(string data in text1)
        {
            UserDetails user = new UserDetails(data);
            Operation.userList.Add(user);
        }
        string[]text2 = File.ReadAllLines("MetroCard/Travel.csv");
        foreach(string data in text2)
        {
            Travel travel = new Travel(data);
            Operation.travelList.Add(travel);
        }
        string[]text3 = File.ReadAllLines("MetroCard/TicketFairDetails.csv");
        foreach(string data in text3)
        {
            TicketFairDetails ticketfair = new TicketFairDetails(data);
            Operation.ticketlist.Add(ticketfair);
        }
    }

     public static void WriteToFiles()
    {
        string[] UserDetails = new String[Operation.userList.Count];
        for(int i= 0;i<Operation.userList.Count;i++)
        {
            UserDetails[i] = Operation.userList[i].CardNumber+","+Operation.userList[i].UserName+","+Operation.userList[i].PhoneNumber+","+Operation.userList[i].Balance;
        }
        string[] Travel = new String[Operation.travelList.Count];
        for(int i = 0;i<Operation.travelList.Count;i++)
        {
            Travel[i] = Operation.travelList[i].CardNumber+","+Operation.travelList[i].FromLocation+","+Operation.travelList[i].ToLocation+","+Operation.travelList[i].DateTime.ToString("dd/MM/yyyy")+","+Operation.travelList[i].TravelCost;
        }
        string[] TicketFairDetails = new String[Operation.ticketlist.Count];
        for(int i=0;i<Operation.ticketlist.Count;i++)
        {
            TicketFairDetails[i] = Operation.ticketlist[i].TicketID+","+Operation.ticketlist[i].FromLocation+","+Operation.ticketlist[i].ToLocation+","+Operation.ticketlist[i].Fair;
        }
    }

}

