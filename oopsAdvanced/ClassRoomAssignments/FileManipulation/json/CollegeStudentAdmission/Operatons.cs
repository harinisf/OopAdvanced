using System;
using System.Collections.Generic;
namespace CollegeStudentAdmission
{
    public delegate void EventManager();
    public static class Operatons
    {
        public static event EventManager starter;
        public static List<StudentDetails> studentlist = new List<StudentDetails>();
        public static List<DepartmentDetails> departmentlist = new List<DepartmentDetails>();
        public static List<AdmissionDetails> admissionlist = new List<AdmissionDetails>();
        public static StudentDetails currentStudent;
        
        
        public static void Subscribe()
        {
            starter += new EventManager(Files.create);
            starter += new EventManager(Files.ReadFromJSON);
            starter += new EventManager(Operatons.MainMenu);
            starter += new EventManager(Files.WriteToJSON);
        }
        
        public static void start()
        {
            Subscribe();
            starter();//Trigerring event.
        }
        public static void MainMenu()

        {
            int option = 0;
            do
            {
                System.Console.WriteLine("Inside looop");
                System.Console.WriteLine("*************Main Menu**************");
                System.Console.WriteLine(" \n 1.Student Registration \n 2.Student Login \n 3.Check Department wise seat availablity \n 4.Exit");
                option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("*********Registation Form********");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("**********Student Login***********");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("*************Check Department Wise Check Availablity**********");
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("********Exit*********");
                        break;
                    }
                            
                }
               
            } while(option != 4);
            
        }
        
        public static void Registration()
        {
            System.Console.Write("\nEnter your Name : ");
            string name = Console.ReadLine();
            System.Console.Write("\nEnter your Father Name : ");
            string fatherName = Console.ReadLine();

            System.Console.Write("\nEnter your DOB - dd/MM/yyyy");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.Write("\nEnter your Gender \nMale \nFemale \nTransGender ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
           
            System.Console.Write("\nEnter your Phone Number");
            long PhoneNumber = long.Parse(Console.ReadLine());
           
            System.Console.WriteLine("\nEnter Physics Mark");
            int Physics = int.Parse(Console.ReadLine());
            System.Console.Write("\nEnter Chemistry mark");
            int Chemistry = int.Parse(Console.ReadLine());
            System.Console.Write("\nEnter Maths Mark");
            int maths = int.Parse(Console.ReadLine());
            StudentDetails student = new StudentDetails(name,fatherName,dob,gender,Physics,Chemistry,maths);
            studentlist.Add(student);
            System.Console.Write($"\nRegistration Successfull your ID is {student.StudentID}");
            
        }
    
        static void Login()
        {
            System.Console.WriteLine("Enter your Student ID : ");
            string studentID = Console.ReadLine().ToUpper();
            bool check = true;

            foreach(StudentDetails studentinfo in studentlist)
            {
                if(studentinfo.StudentID == studentID)
                {
                    check = false;
                    System.Console.WriteLine("Login Successfull");
                    currentStudent = studentinfo;
                    SubMenu();
                }
            }
            if(check)
            {
                System.Console.WriteLine("Invalid ID");
            }
        }
    
        public static void SubMenu()
        {
            int option = 0;
            do
            {
                System.Console.WriteLine("***********Sub Menu*************");
                System.Console.WriteLine("\n1.Check Eligiblity \n2.Show Details \n3.Take Admission");
                System.Console.WriteLine("\n4.Cancel Admission \n5.Show Admission Details \n6.Exit");
                option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        System.Console.WriteLine("**********Check Eligiblity***************");
                        CheckEligiblity();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("**************Show Details****************\n");
                        ShowDetails();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("************Take Admission*************");
                        TakeAdmission();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("**************Cancel Admission**********");
                        CancelAdmission();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("***********Show Admission Details*********");
                        ShowAdmissionHistory();
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("****************Exit************");
                        break;
                    }
                }
            }while(option != 6);
           
        }
    
        public static void DefaultData()
        {
            StudentDetails student1 = new StudentDetails("RaviChandran E","EttapaRajan",new DateTime(1999,11,11),Gender.Male,95,95,95);
            studentlist.Add(student1);
            StudentDetails student2 = new StudentDetails("Baskaran S","Sethurajan",new DateTime(1999,11,11),Gender.Male,95,95,95);
            studentlist.Add(student1);

            DepartmentDetails  department1 = new DepartmentDetails("EEE",29);
            departmentlist.Add(department1);
            DepartmentDetails department2 = new DepartmentDetails("CSE",29);
            departmentlist.Add(department2);
            DepartmentDetails department3 = new DepartmentDetails("MECH",30);
            departmentlist.Add(department3);
            DepartmentDetails department4 = new DepartmentDetails("ECE",30);
            departmentlist.Add(department4);

            AdmissionDetails admission1 = new AdmissionDetails(student1.StudentID,department1.DepartmentID,new DateTime(2022,05,11),AdmissionStatus.Admitted);
            admissionlist.Add(admission1);
            AdmissionDetails admission2 = new AdmissionDetails(student1.StudentID,department1.DepartmentID,new DateTime(2022,05,11),AdmissionStatus.Admitted);
            admissionlist.Add(admission1);
        }
    
        public static void CheckEligiblity()
        {
            bool eligiblity = currentStudent.CheckEligiblity(75.0);
            if(eligiblity)
            {
                System.Console.WriteLine("You are eligible");
            }
            else
            {
                System.Console.WriteLine("You are not eligible");
            }
        }
    
        public static void ShowDetails()
        {
            System.Console.WriteLine($"Name : {currentStudent.Name} \nFather Name : {currentStudent.FatherName} \nGender : {currentStudent.Gender}");
            System.Console.WriteLine($"Phone {currentStudent.DOB} \nDob : {currentStudent.DOB} \nPhysics : {currentStudent.PhysicsMark}");
            System.Console.WriteLine($"Chemistry : {currentStudent.ChemistryMark} \nMaths : {currentStudent.MathsMark}");
        }
    
        public static void ShowAdmissionHistory()
        {
            bool condition = true;
            foreach(AdmissionDetails admission in admissionlist)
            {
                if(currentStudent.StudentID == admission.StudentID)
                {
                    condition = false;
                    System.Console.WriteLine($"Admission ID : {admission.AdmissionID} Student ID {admission.StudentID} Department ID {admission.DepartmentID}");
                    System.Console.WriteLine($"Admission Date : {admission.AdmissionDate.ToString("dd/MM/yyyy")} \nAdmission Status {admission.AdmissionStatus}");
                }
            }
            if(condition)
            {
                System.Console.WriteLine("You are not get Admission");
            }
        }
    
        public static void CancelAdmission()
        {
            //fetch admission list
            foreach(AdmissionDetails admissioninfo in admissionlist)
            {
            //check studentid and admission status is checked
                if((currentStudent.StudentID == admissioninfo.StudentID)&&(admissioninfo.AdmissionStatus==AdmissionStatus.Admitted))
                {
                    admissioninfo.AdmissionStatus = AdmissionStatus.Cancelled;
                }
            //admission status is cancelled
            //return seat to department
                foreach(DepartmentDetails departmentinfo in departmentlist)
                {
                    if(departmentinfo.DepartmentID == admissioninfo.DepartmentID)
                    {
                        departmentinfo.NumberOfSeats++;
                    }
                }
            //show your admission cancelled
            System.Console.WriteLine("your admission is canelled successfully");
            } 
        }
    
        public static void TakeAdmission()
        {
            //show department Id
            foreach(DepartmentDetails department in departmentlist)
            {
                System.Console.WriteLine($"Department ID {department.DepartmentID} Name {department.Name} No of Seats {department.NumberOfSeats}");
            }
            //ask department id for process admission
            System.Console.WriteLine("Enter Department ID : ");
            string departmentID = Console.ReadLine().ToUpper();
            
            bool temp = true;
            foreach(DepartmentDetails department in departmentlist)
            {
                //fetch department details
                //check it has valid department- no - invald department
                if(department.DepartmentID == departmentID)
                {
                    temp = false;
                    //yes -- check no of seats - no seat available
                    if(department.NumberOfSeats > 0)
                    {
                        //yes -- check he is eligible - no - not eligible to take admission
                        if(currentStudent.CheckEligiblity(75.0))
                        {
                            int count = 0 ;
                            foreach(AdmissionDetails admission in admissionlist)
                            {
                                if((currentStudent.StudentID == admission.StudentID)&&(admission.AdmissionStatus == AdmissionStatus.Admitted))
                                {
                                    count++;
                                }
                            }
                            if(count > 0)
                            {
                                System.Console.WriteLine("You have already take admission");
                            }
                            else
                            {
                                //no - create admission, reduce seat count in department
                                department.NumberOfSeats--;
                                AdmissionDetails admission = new AdmissionDetails(department.DepartmentID,currentStudent.StudentID,DateTime.Now,AdmissionStatus.Admitted);
                                admissionlist.Add(admission);
                                //show admission successfull
                            }
                        }
                        //yes -- fetch admission list - count if he had admission - yes- show you have already taken admission
                        else
                        {
                            System.Console.WriteLine("you are not required to take admission");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No seat available");
                    }
                }
              
               
            }
             if(temp == true)
            {
                System.Console.WriteLine("Invalid Department ID");
            }
           
        }
    }
}