using System;
using System.Collections.Generic;
namespace MetroCardManagement
{
    public static class Operation
    {
        public static List<UserDetails> userList = new List<UserDetails>();
        public static List<Travel> travelList = new List<Travel>();
        public static List<TicketFairDetails> ticketlist = new List<TicketFairDetails>();
        public static UserDetails currentUser;

        public static void MainMenu()
        {
            int option = 0;
            do
            {
                System.Console.WriteLine("*****************Main Menu******************");
                System.Console.WriteLine("Enter your option \n1.New User Registration \n2.Login User \n3.Exit");
                option = int.Parse(Console.ReadLine());
                switch(option)
                {
                case 1:
                        System.Console.WriteLine("****User Registration*******");
                        Registration();
                        break;
                case 2:
                        System.Console.WriteLine("*********Login User**********");
                        Login();
                        break;
                case 3:
                        System.Console.WriteLine("****Exit*****");
                        break;
                
                }
            }while(option != 3);
        }

        public static void Registration()
        {
            System.Console.WriteLine("Enter your User Name ");
            string UserName = Console.ReadLine();
            System.Console.WriteLine("Enter your PhoneNumber ");
            long PhoneNumber = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter yout Balance");
            int Balance = int.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(UserName,PhoneNumber,Balance);
            userList.Add(user);
            System.Console.WriteLine($"Your Card Number is : {user.CardNumber}");
        }    
    
        public static void Login()
        {
            System.Console.WriteLine("Enter your Card Number : ");
            string CardNumber = Console.ReadLine().ToUpper();
            bool check = true;
            foreach(UserDetails userinfo in userList)
            {
                if(CardNumber == userinfo.CardNumber)
                {
                    check = false;
                    System.Console.WriteLine("Login Successfull");
                    currentUser = userinfo;
                    SubMenu();
                }
            }
            if(check)
            {
                foreach(UserDetails userinfo in userList)
                {
                    System.Console.WriteLine($"invalid number {userinfo.CardNumber}");
                }
            }
        }
    
        public static void SubMenu()
        {
            int option = 0;
            do
            {
                System.Console.WriteLine("*******Enter the options*******");
                System.Console.WriteLine("1.Balance check \n2.Recharge \n3.View Travel History \n4.Travel \n5.Exit");
                option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                            System.Console.WriteLine("*******Balanace Checking*********");
                            BalanceCheck();
                            break;
                    case 2:
                            System.Console.WriteLine("********Recharge**********");
                            Recharge();
                            break;
                    case 3:
                            System.Console.WriteLine("*******View Travel History********");
                            TravelHistory();
                            break;
                    case 4:
                            System.Console.WriteLine("***********Travel**********");
                            Travel();
                            break;
                    case 5:
                            System.Console.WriteLine("***********Exit sub menu*********");
                            break;
                }
            }while(option != 5);
        }
    
        public static void DefaultDate()
        {
            Travel travel = new Travel("CMRL101","Airport","Egmore",new DateTime(2022,10,10),55);
            travelList.Add(travel);
            Travel travel1 = new Travel("CMRL101","Egmore","Koyambedu",new DateTime(2022,10,10),55);
            travelList.Add(travel1);
            Travel travel2 = new Travel("CMRL102","Alandur","Koyambedu",new DateTime(2022,11,10),55);
            travelList.Add(travel2);
            Travel travel3 = new Travel("CMRL102","Egmore","Thirumangalam",new DateTime(2022,11,10),55);
            travelList.Add(travel3);

            TicketFairDetails ticket = new TicketFairDetails("Airport","Egmore",55);
            ticketlist.Add(ticket);
            TicketFairDetails ticket1 = new TicketFairDetails("Airport","Koyambedu",25);
            ticketlist.Add(ticket1);
            TicketFairDetails ticket2 = new TicketFairDetails("Alandur","Koyambedu",25);
            ticketlist.Add(ticket2);
            TicketFairDetails ticket3 = new TicketFairDetails("Koyambedu","Egmore",32);
            ticketlist.Add(ticket3);
            TicketFairDetails ticket4 = new TicketFairDetails("Vadapalani","Egmore",45);
            ticketlist.Add(ticket4);

            UserDetails user = new UserDetails("Ravi",9678,1000);
            userList.Add(user);
            UserDetails user1 = new UserDetails("Baskaran",99878,1000);
            userList.Add(user1);
        }

        public static void BalanceCheck()
        {
            System.Console.WriteLine($"Balance {currentUser.Balance}");
        }
    
        public static void Recharge()
        {
            System.Console.WriteLine("Enter the amount to be recharge");
            int recharge = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Recharge amount is {currentUser.Recharge(recharge)}");
        }
    
        public static void TravelHistory()
        {
            foreach(Travel travelinfo in travelList)
            {
                if(currentUser.CardNumber == travelinfo.CardNumber)
                {
                    System.Console.WriteLine($"{travelinfo.TravelID} | {travelinfo.FromLocation} | {travelinfo.ToLocation} | {travelinfo.DateTime.ToString("dd/MM/yyyy")} | {travelinfo.TravelCost}");
                }
            }
        }
    
        public static void Travel()
        {
            foreach(TicketFairDetails ticketinfo in ticketlist)
            {
                System.Console.WriteLine($"{ticketinfo.TicketID} {ticketinfo.FromLocation} {ticketinfo.ToLocation} {ticketinfo.Fair}");
            }
            System.Console.WriteLine("Enter Ticket ID");
            string TicketID = Console.ReadLine();
            bool check = true;
            foreach(TicketFairDetails ticketinfo in ticketlist)
            {
                if(TicketID == ticketinfo.TicketID)
                {
                    check = false;
                    if(currentUser.Balance >= ticketinfo.Fair)
                    {
                        TicketFairDetails ticketfair = new TicketFairDetails(ticketinfo.FromLocation,ticketinfo.ToLocation,ticketinfo.Fair);
                        ticketlist.Add(ticketfair);
                        System.Console.WriteLine($"{ticketinfo.TicketID} | {ticketinfo.FromLocation} | {ticketinfo.ToLocation} | {ticketinfo.Fair}");
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine("Recharge the amount");
                        Recharge();
                    }
                }
            }
            if(check)
            {
                System.Console.WriteLine("Invalid User ID");
            }
        }
    
    }
}