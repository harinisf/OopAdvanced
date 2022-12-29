using System;
using System.IO;
namespace ReadWriteTxtFile;
class Program
{
    public static void Main(string[] args)
    {
        if(Directory.Exists("TestFolder"))//Relative path
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder created");
        }
        else
        {
            System.Console.WriteLine("Folder exists");
        }

        string path = @"C:\Users\HariniKannan\OneDrive - Syncfusion\Desktop\New folder";
        string myFolder = path+"/Ravi";
        if(Directory.Exists(myFolder))
        {
            Directory.CreateDirectory(myFolder);
            System.Console.WriteLine("Folder created");
        }
        else
        {
            System.Console.WriteLine("Folder exsists");
        }

        if(File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt").Close();
            System.Console.WriteLine("File created");
        }
        else
        {
            System.Console.WriteLine("Fie found");
        }

        System.Console.WriteLine("Select option 1.Read file info 2.Writing file info");
        int option = int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                StreamReader sr = null;
                try
                {
                    //pass the ile path and file name to the stream reader constructor
                    sr = new StreamReader("Test Folder/Test.txt");
                    string line = sr.ReadLine();
                    while(line != null)
                    {
                        System.Console.WriteLine(line);
                        line = sr.ReadLine();
                    }
                }
                catch(Exception e)
                {
                        System.Console.WriteLine("Exception : "+e.Message);
                    }
                    finally
                    {
                        if(sr!=null)
                        {
                            System.Console.WriteLine(  "Executing Finally block");
                            sr.Close();
                        }
                        
                    }
                }
                break;
              
            case 2:
                StreamWriter sw = null;
                try
                {
                    string[] old = File.ReadAllLines("TestFolder/Text.txt");
                    sw = new StreamWriter("TestFolder,Test.txt");
                    System.Console.WriteLine("Enter new content to be placed in file");
                    string info = Console.ReadLine();
                    string old1 = "";
                        foreach(string text in old)
                        {
                            old1 = old1+"\n"+text;
                        }
                        old1 = old1+"\n"+info;
                    sw.WriteLine(old1);
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception "+e.Message);
                }
                finally
                {
                    if(sw != null)
                    {
                        sw.Close();
                    }
                }
                break;
        }
    }
}
