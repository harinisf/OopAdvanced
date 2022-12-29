using System;
using System.Collections.Generic;
namespace OnlineMovieTicketBooking
{
    
    public class Operation
    {
        static List<UserDetails> userlist = new List<UserDetails>(); 
        static List<TheatreDetails> theatrelist = new List<TheatreDetails>();
        static List<MovieDetails> movielist = new List<MovieDetails>();
        static List<ScreeningDetails> screenlist = new List<ScreeningDetails>();
        static List<BookingDetails> booklist = new List<BookingDetails>();
        static UserDetails Currentuser;
        public static void MainMenu()
        {
            int options = 0;
            do
            {
                System.Console.WriteLine("**********Main Menu*********");
                System.Console.WriteLine("Enter your option : \n1.User Registration \n2.Login \n3.Exit");
                options = int.Parse(Console.ReadLine());
                switch(options)
                {
                    case 1:
                            System.Console.WriteLine("*****User Registration*****");
                            UserRegistration();
                            break;
                    case 2:
                            System.Console.WriteLine("**********Login**********");
                            Login();
                            break;
                    case 3:
                            System.Console.WriteLine("********Exit********");
                            break;
                }
            }while(options != 3);
        }
    
        public static void UserRegistration()
        {
            System.Console.WriteLine("Enter your name");
            string Name = Console.ReadLine();
            System.Console.WriteLine("Enter your age");
            int Age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Phone number");
            long PhoneNumber = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Wallet Balance");
            int WalletBallence = int.Parse(Console.ReadLine());

            UserDetails user1 = new UserDetails(Name,Age,PhoneNumber,WalletBallence);
            userlist.Add(user1);
            System.Console.WriteLine($"Your registration number is {user1.UserID}");
        }
    
        public static void Login()
        {
            System.Console.WriteLine("Enter your User ID");
            string userID = Console.ReadLine();
            bool check = true;
            foreach(UserDetails userinfo in userlist)
            {
                if(userID == userinfo.UserID)
                {
                    check = false;
                    System.Console.WriteLine("Login successfull");
                    Currentuser = userinfo;
                    SubMenu();
                }
            }
            if(check)
            {
                System.Console.WriteLine("Invalid user ID");
            }
        }
    
        public static void SubMenu()
        {
            int option = 0;
            do
            {
                System.Console.WriteLine("**********Main Menu*********");
                System.Console.WriteLine("1.Ticket Booking \n2.Ticket Cancellation \n3.Booking History \n4.Wallet Recharge \n5.Exit");
                option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                            System.Console.WriteLine("*********Booking Ticket********");
                            TicketBooking();
                            break;
                    case 2:
                            System.Console.WriteLine("***********Cancelling Ticket*********");
                            TicketCancel();
                            break;
                    case 3:
                            System.Console.WriteLine("**********Booking History***********");
                            BookingHistory();
                            break;
                    case 4:
                            System.Console.WriteLine("**********Wallet Recharge*********");
                            walletBalance();
                            break;
                    case 5:
                            System.Console.WriteLine("**********Exit***********");
                            break;
                    
                }
            }while(option != 5);
           
        }
    
        public static void DefaultData()
        {
            UserDetails user1 = new UserDetails("Ravi",30,67888878777,1000);
            userlist.Add(user1);
            UserDetails user2 = new UserDetails("Baskar",30,6784536777,2000);
            userlist.Add(user2);

            TheatreDetails theatre = new TheatreDetails("Inbox","Anna Nagar");
            theatrelist.Add(theatre);
            TheatreDetails theatre1 = new TheatreDetails("Ega Theatre","Chetpet");
            theatrelist.Add(theatre1);
            TheatreDetails theatre2 = new TheatreDetails("Kamala","VadaPalani");
            theatrelist.Add(theatre2);

            MovieDetails movie = new MovieDetails("Bahubali 2","Telungu");
            movielist.Add(movie);
            MovieDetails movie1 = new MovieDetails("Ponniyin Selvan","Tamil");
            movielist.Add(movie1);
            MovieDetails movie2 = new MovieDetails("Cobra","Tamil");
            movielist.Add(movie2);
            MovieDetails movie3 = new MovieDetails("Vikram","Hndi");
            movielist.Add(movie3);
            MovieDetails movie4 = new MovieDetails("Vikram","Tamil");
            movielist.Add(movie4);
            MovieDetails movie5 = new MovieDetails("Beast","English");
            movielist.Add(movie5);

            ScreeningDetails screen = new ScreeningDetails(theatre.TheatreID,movie.MovieID,200,5);
            screenlist.Add(screen);
            ScreeningDetails screen1 = new ScreeningDetails(theatre.TheatreID,movie1.MovieID,300,2);
            screenlist.Add(screen1);
            ScreeningDetails screen2 = new ScreeningDetails(theatre.TheatreID,movie5.MovieID,50,1);
            screenlist.Add(screen2);
            ScreeningDetails screen3 = new ScreeningDetails(theatre1.TheatreID,movie.MovieID,400,11);
            screenlist.Add(screen3);
            ScreeningDetails screen4 = new ScreeningDetails(theatre1.TheatreID,movie4.MovieID,300,20);
            screenlist.Add(screen4);

            BookingDetails book = new BookingDetails("UID1001","MID501","TID301",1,200,BookingStatus.Booked);
            booklist.Add(book);
            BookingDetails book1 = new BookingDetails("UID1002","MID504","TID302",1,400,BookingStatus.Booked);
            booklist.Add(book1);
            BookingDetails book2 = new BookingDetails("UID1003","MID505","TID302",1,300,BookingStatus.Booked);
            booklist.Add(book2);
        }

        public static void TicketBooking()
        {
            System.Console.WriteLine("Select a TheatreID");
            foreach(TheatreDetails theatreinfo in theatrelist)
            {
                System.Console.WriteLine($"{theatreinfo.TheatreID} | {theatreinfo.TheatreName} | {theatreinfo.TheatreLocation}");
            }
            string TheatreID = Console.ReadLine().ToUpper();
            System.Console.WriteLine("Select a movieID");
            foreach(MovieDetails movieinfo in movielist)
            {
                System.Console.WriteLine($"{movieinfo.MovieID} | {movieinfo.MovieName} | {movieinfo.Language}");
            }
            string MovieID = Console.ReadLine().ToUpper();
            System.Console.WriteLine("Enter the seat count");
            int seatCount = int.Parse(Console.ReadLine());
            int TotalAmount;
            bool check = true;
            foreach(ScreeningDetails screeninfo in screenlist)
            {
                if((screeninfo.TheatreID == TheatreID)&&(screeninfo.MovieID == MovieID))
                {
                    check = false;
                    if(screeninfo.SeatAvailablity >= seatCount)
                    {
                        TotalAmount = seatCount*screeninfo.TicketPrice+18/100;
                        System.Console.WriteLine($"Total Price {TotalAmount}");
                        if(Currentuser.WalletBalance < TotalAmount)
                        {
                            System.Console.WriteLine("Insufficient Balance Recharge your Wallet");   
                            System.Console.WriteLine($"Recharged amount is { Currentuser.RechargeWallet(TotalAmount)}");
                            System.Console.WriteLine("BOOKED SUCCESSFULLY");
                            foreach(BookingDetails bookinfo in booklist)
                            {
                                bookinfo.BookingStatus = BookingStatus.Booked;
                                System.Console.WriteLine($"{bookinfo.BookID} | {Currentuser.UserID} | {bookinfo.MovieID} | {bookinfo.TheatreID}");
                            }
                        }
                        else
                        {
                            Currentuser.WalletBalance = Currentuser.WalletBalance - TotalAmount;
                            System.Console.WriteLine($"Your Wallet Balance {Currentuser.WalletBalance}");
                            System.Console.WriteLine("BOOKED SUCCESSFULLY");
                             foreach(BookingDetails bookinfo in booklist)
                            {
                                bookinfo.BookingStatus = BookingStatus.Booked;
                            }
                        }
                    }
                }
            }
            if(check)
            {
                System.Console.WriteLine("Required Seat count not available");
            }
            
        } 
    
        public static void walletBalance()
        {
            System.Console.WriteLine($"Your Wallet Balance{Currentuser.WalletBalance}");
        }
    
        public static void TicketCancel()
        {
            foreach(BookingDetails bookinginfo in booklist)
            {
                if(bookinginfo.BookingStatus == BookingStatus.Booked)
                {
                    System.Console.WriteLine($" {bookinginfo.BookID}| {bookinginfo.MovieID}| {bookinginfo.TheatreID} | {bookinginfo.BookingStatus} ");
                }
            }
                System.Console.WriteLine("Enter book ID you want to cancel");
                string BookID = Console.ReadLine();
                int BookCount;
            foreach(BookingDetails bookinginfo in booklist)
            {
                if(bookinginfo.BookingStatus == BookingStatus.Booked)
                {
                    BookCount = bookinginfo.SeatCount;
                    foreach(ScreeningDetails screeninfo in screenlist)
                    {
                        if(bookinginfo.MovieID == screeninfo.MovieID)
                        {
                            screeninfo.SeatAvailablity += BookCount;
                            Currentuser.WalletBalance = Currentuser.WalletBalance-20;
                            bookinginfo.BookingStatus = BookingStatus.Cancelled;
                        }
                    }
                }
            }
            System.Console.WriteLine("The book was successfully cancelled");

        }
    
        public static void BookingHistory()
        {
            foreach(BookingDetails bookinfo in booklist)
            {
                System.Console.WriteLine($"Customer ID {bookinfo.UserID} Movie ID {bookinfo.MovieID} Theatre ID {bookinfo.TheatreID} Seat Count {bookinfo.SeatCount} Total Amount {bookinfo.TotalAmount} Booking Status {bookinfo.BookingStatus}");
            }
        }
    }
}