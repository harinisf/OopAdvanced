using System;
namespace MetroCardManagement;
class Program
{
    public static void Main(string[] args)
    {
        FilesCSV.Create();
        Operation.DefaultDate();
        Operation.MainMenu();
    }
}