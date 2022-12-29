using System;
using System.Collections.Generic;
namespace OnlineGrocery;

    public class Operation
    {
        static List<CustomerDetails> customerlist = new List<CustomerDetails>();
        static List<ProductDetails> productlist = new List<ProductDetails>();
        static List<OrderDetails> tempOrderList = new List<OrderDetails>();
        static CustomerDetails currentcustomer;
        public static void MainMenu()
        {
            int options = 0;
            do
            {
                    
                System.Console.WriteLine("***********Main Menu***************");
                System.Console.WriteLine("1.Customer Registration \n2.Customer Login \n3.Exit");
                options = int.Parse(Console.ReadLine());
                switch(options)
                {
                    case 1:
                            System.Console.WriteLine("**********Customer Registration*********");
                            UserRegistration();
                            break;
                    case 2:
                            System.Console.WriteLine("********Customer Login**************");
                            UserLogin();
                            break;
                    case 3:
                            System.Console.WriteLine("**********Exit***********");
                            break;

                }
            }while(options != 3);
        }
        //User Registration Method
        public static void UserRegistration()
        {
            System.Console.WriteLine("Enter your name");
            string Name = Console.ReadLine();
            System.Console.WriteLine("Enter your Father Name");
            string FatherName = Console.ReadLine();
            System.Console.WriteLine("Enter our Gender");
            Gender Gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.WriteLine("Enter your Mobile Number");
            long MobileNumber = long.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Date of Birth");
            DateTime DOB = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter your MailID");
            string MailID = Console.ReadLine();
            System.Console.WriteLine("Enter your WalletBalance");
            int WalletBalance = int.Parse(Console.ReadLine());

            CustomerDetails customer = new CustomerDetails(Name,FatherName,Gender,MobileNumber,DOB,MailID,WalletBalance);
            customerlist.Add(customer);
            System.Console.WriteLine($"Your Customer ID is {customer.CustomerID}");
        }
    
        public static void UserLogin()
        {
            System.Console.WriteLine("Enter your Customer ID");
            string CustomerID = Console.ReadLine();
            bool check = true;
            foreach(CustomerDetails customerinfo in customerlist)
            {
                if(CustomerID == customerinfo.CustomerID)
                {
                    check = false;
                    System.Console.WriteLine("Login Successfull");
                    currentcustomer = customerinfo;
                    SubMenu();
                }
            }
            if(check)
            {
                System.Console.WriteLine("Invalid ID");
            }
           
        }
    
        public static void DefaultData()
        {
            CustomerDetails customer1 = new CustomerDetails("Ravi","Ettaparajan",Gender.Male,4567864567,new DateTime(1999,11,11),"ravi@gmail.com",10000);
            customerlist.Add(customer1);   
            CustomerDetails customer2 = new CustomerDetails("Baskaran","Sethurajan",Gender.Male,9567864567,new DateTime(1999,11,11),"baskar@gmail.com",15000);
            customerlist.Add(customer2);   
            
            ProductDetails product1  = new ProductDetails("Sugar",20,40);
            productlist.Add(product1);
            ProductDetails product2  = new ProductDetails("Rice",100,50);
            productlist.Add(product2);
            ProductDetails product3  = new ProductDetails("Milk",10,40);
            productlist.Add(product3);
            ProductDetails product4  = new ProductDetails("Coffee",10,10);
            productlist.Add(product4);
            ProductDetails product5  = new ProductDetails("Tea",10,10);
            productlist.Add(product5);
            ProductDetails product6  = new ProductDetails("Masala Powder",10,20);
            productlist.Add(product6);
            ProductDetails product7  = new ProductDetails("Salt",10,10);
            productlist.Add(product7);

        }
        public static void SubMenu()
        {
            int option = 0;
            do
            {
                System.Console.WriteLine("***********Sub Menu**************");
                System.Console.WriteLine("1.Show Customer Details \n2.Show product Details \n3.Wallet Recharge \n4.Take Order \n5.Modify Order Quantity \n6.Cancel Order \n7.Exit");
                option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                            System.Console.WriteLine("********Show Customer Details*********");
                            ShowCustomerDetails();
                            break;
                    case 2:
                            System.Console.WriteLine("**********Show product Details*********");
                            ShowProductDetails();
                            break;
                    case 3:
                            System.Console.WriteLine("************Wallet Recharge**********");
                            break;
                    case 4:
                            System.Console.WriteLine("************Take Order************");
                            break;
                    case 5:
                            System.Console.WriteLine("*************Modify Order Quantity**********");
                            break;
                    case 6:
                            System.Console.WriteLine("***********Cancel Order***********");
                            break;
                    case 7:
                            System.Console.WriteLine("**********Exit************");
                            break;
                }
            }while(option != 7);
            
        }

        public static void ShowCustomerDetails()
        {
            //show the Details of the customer
            foreach(CustomerDetails customerinfo in customerlist)
            {
                System.Console.WriteLine($"Customer ID {customerinfo.CustomerID} | Customer Name {customerinfo.Name} | Father Name {customerinfo.FatherName} | Gender {customerinfo.Gender} | Mobile Number {customerinfo.MobileNumber} | DOB {customerinfo.DOB} | MailID {customerinfo.MailID}");
            }
        }
    
        public static void ShowProductDetails()
        {
            foreach(ProductDetails productinfo in productlist)
            {
                System.Console.WriteLine($"Product ID {productinfo.ProductID} | Product Name {productinfo.ProductName}| Quantity Available {productinfo.QuantityAvailable} | Price Per Quantity {productinfo.PricePerQuantity}");
            }
            
        }
    
        public static void TakeOrder()
        {
            /*.createbooking object total amount status initiated 
                2.create local order list using order class, double  totalAmount = 0;
                3.show product details
                4.ask product id, product count
                5.using foreach check product id present in product list no -(invalid product id)
                6.yes - check available count no - there is no stock in requested quantity
                7.yes - reduce product count from stock
                8.double amount = price(product*count); totalAmount += amount;
                9.create order class object price = amount; product id, booking id taken from step 1,count
                10.Add order object to local cart list
                11.Show product added to cart
                12.Ask do you want to add another product - no - exit
                13.yes - repeat from step3*/
            BookingDetails booking = new BookingDetails(currentcustomer.CustomerID,0,new DateTime(1999,11,11),BookingStatus.Intiated);
            double TotalAmount = 0;
            foreach(ProductDetails productinfo in productlist)
            {
                System.Console.WriteLine($"Product ID {productinfo.ProductID} | Product Name {productinfo.ProductName}| Quantity Available {productinfo.QuantityAvailable} | Price Per Quantity {productinfo.PricePerQuantity}");
            }
            System.Console.WriteLine("Enter product ID : ");
            string ProductID = Console.ReadLine();
            System.Console.WriteLine("Enter your product Count ");
            int productCount = int.Parse(Console.ReadLine());
            bool check = true;
            foreach(ProductDetails productinfo in productlist)
            {
                if(ProductID == productinfo.ProductID)
                {
                    if(productCount <= productinfo.QuantityAvailable)
                    {
                        productinfo.QuantityAvailable = productinfo.QuantityAvailable - 1;
                        double amount = productinfo.PricePerQuantity* productCount;
                    }
                    else
                    {
                        System.Console.WriteLine("There is no stock available");
                    }
                }
            }
            if(check)
            {
                System.Console.WriteLine("Invalid Product ID");
            }
            
        }
    }
